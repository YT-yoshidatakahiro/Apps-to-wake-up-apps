using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace appswakeup
{
    public partial class AppsWakeUp : Form
    {

        /// <summary>
        ///iniファイル読み込み設定
        /// </summary>
        [DllImport("kernel32.dll",
                EntryPoint = "GetPrivateProfileStringW",
                CharSet = CharSet.Unicode,
                SetLastError = true)]
                static extern uint GetPrivateProfileString(
                string lpAppName,
                string lpKeyName,
                string lpDefault,
                StringBuilder lpReturnedString,
                uint nSize,
                string lpFileName);

        private String fln1 = @"./appssetup.ini";

        private string[] appname1 = new string[1];
        private string[] apppath1 = new string[1];

        /// <summary>
        /// 当アプリのコンストラクタ
        /// </summary>
        public AppsWakeUp()
        {
            InitializeComponent();

            cmbResult.Text = "検索結果";

            cmbAppList.Click += new EventHandler(cmbAppList_Click);
            tbSerch.Click += new EventHandler(tbSerch_Click);
            tbfile.Click += new EventHandler(tbfile_Click);

            //ウィンドウの右上のバツボタンなど非表示
            ControlBox = false;

            if (!(System.IO.File.Exists(fln1)))
            {
                //起動ファイルのない場合の処理
                MessageBox.Show("起動アプリリストがありません", "読込不可");

                //終了ボタン以外操作不可
                btnWake.Enabled = false;

                cmbAppList.Enabled = false;

            }
            //iniファイルの有無
            else if (System.IO.File.Exists(fln1))
            {

                //終了以外のボタン操作可
                btnWake.Enabled = true;

                cmbAppList.Enabled = true;

                fln1 = @"./appssetup.ini";

                //iniファイル読込処理開始
                int capacitySize = 256;

                StringBuilder sb = new StringBuilder(capacitySize);

                //コンボボックスへの読み込み
                //iniファイルの登録分，動的に配列を増減させる
                for (int j = 0; j < appname1.Length; j++)
                {

                    if (j >= appname1.Length)
                    {
                        MessageBox.Show("アプリ登録数とリスト登録数の不一致", "読込不可");

                        btnWake.Enabled = false;

                        cmbAppList.Enabled = false;

                    }
                    else
                    {
                        //アプリ名の設定
                        GetPrivateProfileString("listname", string.Format("name" + j), "", sb, Convert.ToUInt32(sb.Capacity), fln1);

                        appname1[j] = @sb.ToString();

                        if (!(appname1[j].Equals("")))
                        {
                            cmbAppList.Items.Add(appname1[j]);
                            Array.Resize(ref appname1, appname1.Length + 1);
                            //Array.Sort(appname1);
                        }

                        //アプリパスの設定
                        GetPrivateProfileString("apppath", string.Format("app" + j), "", sb, Convert.ToUInt32(sb.Capacity), fln1);

                        //stringUTF8に何らかUTF8の文字列が入ってくる
                        apppath1[j] = @sb.ToString();
                        if (!(apppath1[j].Equals("")))
                        {
                            Array.Resize(ref apppath1, apppath1.Length + 1);

                        }
                        cmbAppList.SelectedIndex = 0;
                    }
                }
            }
            //iniファイル読込処理終了
        }

        /// <summary>
        /// アプリ終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 選択アプリの起動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWake_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i < appname1.Length; i++)
                {
                    if (cmbAppList.Text == appname1[i])
                    {
                        ProcessStartInfo pInfo = new ProcessStartInfo();
                        pInfo.FileName = apppath1[i];

                        Process p = Process.Start(pInfo);

                        p.WaitForExit();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("開けません", "パスの確認");
            }
        }

        /// <summary>
        /// 起動アプリ選択・登録（登録後，更新）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAppList_Click(object sender, EventArgs e)
        {
            cmbAppList.Items.Clear();

            //iniファイル読込処理開始
            int capacitySize = 256;

            StringBuilder sb = new StringBuilder(capacitySize);

            for (int j = 0; j < appname1.Length; j++)
            {
                //アプリ名の設定
                GetPrivateProfileString("listname", string.Format("name" + j), "", sb, Convert.ToUInt32(sb.Capacity), fln1);

                appname1[j] = @sb.ToString();

                if (!(appname1[j].Equals("")))
                {
                    cmbAppList.Items.Add(appname1[j]);
                    Array.Resize(ref appname1, appname1.Length + 1);
                }

                //アプリパスの設定
                GetPrivateProfileString("apppath", string.Format("app" + j), "", sb, Convert.ToUInt32(sb.Capacity), fln1);

                //stringUTF8に何らかUTF8の文字列が入ってくる
                apppath1[j] = @sb.ToString();
                if (!(apppath1[j].Equals("")))
                {
                    Array.Resize(ref apppath1, apppath1.Length + 1);

                }

                cmbAppList.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 登録したいアプリの検索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerchStart_Click(object sender, EventArgs e)
        {
            //C直下のファイル検索
            string serchpath = @"C:\";

            try
            {
                //ディレクトリのみしかわからない場合
                if (tbfile.Text == ".拡張子名（不明可）" || tbfile.Text.Equals(""))
                {
                    string[] filepath = Directory.GetFiles(serchpath + tbSerch.Text, tbfile.Text, SearchOption.AllDirectories);

                    for (int i = 0; i < filepath.Length; i++)
                    {
                        cmbResult.Items.Add(filepath[i]);
                    }
                }
                //ファイル名＋拡張子が判明する場合
                else
                {
                    string[] filepath = Directory.GetFiles(serchpath + tbSerch.Text, "*." + tbfile.Text, SearchOption.AllDirectories);

                    for (int i = 0; i < filepath.Length; i++)
                    {
                        cmbResult.Items.Add(filepath[i]);
                    }
                }
            }
            catch (Exception ignored)
            {
            }
        }

        /// <summary>
        /// 検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSerch_Click(object sender, EventArgs e)
        {
            cmbResult.Items.Clear();
            cmbResult.Text = "";
        }

        /// <summary>
        /// 検索ファイル
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbfile_Click(object sender, EventArgs e)
        {
            cmbResult.Items.Clear();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "EXPLORER.EXE", @"C:\");
        }


        /// <summary>
        /// 不使用ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppsWakeUp_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 検索ディレクトリ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSerch_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbAppList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tbfile_TextChanged(object sender, EventArgs e)
        {
        }

    }
}


