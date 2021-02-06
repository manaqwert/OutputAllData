using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class データ出力 : Form
    {
        //３次元配列用係数準備
        int days = 1;
        int stock_num = 0;
        //int value = 0;
        int Min_stock_num = 1000;
        int Max_stock_num = 10000;
        //3839行前後


        int progress_status;
        int num_files = 0;
               
        string folder_name;
        string num_files_st;
        string days_st;
        
        //ファイル数にあった３次元配列を用意
        string[,,] data_file = new string[400, 10001, 7];
        //ファイル数は3474個まではOK。3475個以上はエラー発生。

        public データ出力()
        {
            InitializeComponent();
 
        }

        private void Get_file_List_Button(object sender, EventArgs e)
        {
            FolderBrowserDialog folder_sel = new FolderBrowserDialog();

            //フォルダ選択ダイアログの初期値指定
            folder_sel.SelectedPath = @"M:\Manabu MyDocuments\ドキュメント\stock";

            //フォルダ選択のダイアログでフォルダ選択
            if (DialogResult.OK == folder_sel.ShowDialog())
            {
                folder_name = folder_sel.SelectedPath;
                //選択したフォルダ名をテキストボックスに入れる
                Folder_place.Text = folder_name;
            }

            //dnameにテキストボックスのフォルダ名を入れる
            string dname = Folder_place.Text;


            if (System.IO.Directory.Exists(dname) == false)
            {
                MessageBox.Show(dname + "が見つかりません。", "通知");
                return;
            }


            int Max_value = 6;

            int Max_stock_num_setting = Max_stock_num + 1;
            int Max_value_setting = Max_value + 1;

            //リストボックスにファイル名を追加する。
            //ファイルの個数を数えて、num_filesに格納
            File_List_Box.Items.Clear();
            foreach (string fName in System.IO.Directory.GetFiles(dname))
            {
                ++num_files;

                data_file[num_files, 0, 0] = fName;

                //ファイルパスをリストボックスに記載
                File_List_Box.Items.Add(num_files + ", " + data_file[num_files, 0, 0] + ", ");
            }

            //ファイル数を表示
            //string num_files_st;

            num_files_st = num_files.ToString();
            Number_of_files.Text = num_files_st;

            int stock_num2 = 0;

            //
            //ここからファイルの中身読み込み
            //

            for (days = 1; days <= num_files; days++)
            {

                //ファイルが存在しなければforを抜ける
                if (System.IO.File.Exists(data_file[days, 0, 0]) == false)
                {
                    //
                    // 2017/6/1時点　ここにはまっていた。
                    // days = 0からdays = 1に変更するとここではまらなくなった。
                    //

                    //最後のファイル読み込み後の終了処置
                    days = num_files;
                }

                //ファイルが存在する場合
                else
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(data_file[days, 0, 0], Encoding.GetEncoding("Shift_JIS"));

                    for (stock_num = Min_stock_num; stock_num <= Max_stock_num; stock_num++)
                    {
                        if (sr.EndOfStream == false)
                        {
                            //ファイル一行読み込み、タブ区切り毎にfield[]に格納
                            string file_contents_2 = sr.ReadLine();

                            //2012年データ異常対策
                            file_contents_2 = file_contents_2.Replace("・", "\t");

                            string[] fields = file_contents_2.Split('\t');

                            //stringをintに変換
                            int fields_int = int.Parse(fields[0]);
                            //string stock_num_st = stock_num.ToString;

                            if (fields_int == stock_num)
                            {
                                data_file[days, stock_num, 0] = fields[0];
                                data_file[days, stock_num, 1] = fields[1];
                                data_file[days, stock_num, 2] = fields[2];
                                data_file[days, stock_num, 3] = fields[3];
                                data_file[days, stock_num, 4] = fields[4];
                                data_file[days, stock_num, 5] = fields[5];
                                data_file[days, stock_num, 6] = fields[6];

                            }
                            else
                            {
                                if (fields_int > 20000000)
                                {
                                    data_file[days, stock_num, 0] = fields[0];
                                }
                                else
                                {
                                    stock_num = fields_int;
                                    data_file[days, stock_num, 0] = fields[0];
                                    data_file[days, stock_num, 1] = fields[1];
                                    data_file[days, stock_num, 2] = fields[2];
                                    data_file[days, stock_num, 3] = fields[3];
                                    data_file[days, stock_num, 4] = fields[4];
                                    data_file[days, stock_num, 5] = fields[5];
                                    data_file[days, stock_num, 6] = fields[6];

                                }

                            }

                            //リストボックスへの書き出し
                            if (stock_num == Min_stock_num)
                            {


                            }
                            else
                            {
                                //file_contents_Box.Items.Add(data_file[days, 1000, 0] + ", " + stock_num + ", " + data_file[days, stock_num, 0] + ", " + data_file[days, stock_num, 1] + ", " + data_file[days, stock_num, 2] + ", " + data_file[days, stock_num, 3] + ", " + data_file[days, stock_num, 4] + ", " + data_file[days, stock_num, 5] + ", " + data_file[days, stock_num, 6] + ", ");

                            }

                        }
                        else
                        {
                            //最後の行まで読み終わった場合の終了処置
                            //file_contents_Box.Items.Add(days + ", " + stock_num + ", " + "EndOfStream");
                            stock_num2 = stock_num;
                            stock_num = Max_stock_num;

                        }

                    }


                }

            }
            //
            //ここまでファイル内容読み込み
            //
        }

        //
        //Computeボタン押してからの処理
        //
        private void button1_Click(object sender, EventArgs e)
        {
            //
            //ここからファイル書き出し
            //

            //進捗率表示用
            opeing_total_num.Text = num_files_st;
            //progress_num.Text = days_st;


            //
            //データ・フォーマット
            // 0：銘柄コード   brand_code
            // 1：企業名       brand_name 
            // 2：始値         opening_price
            // 3：当日高値     high_price
            // 4：当日安値     low_price
            // 5：終値         closing_price
            // 6：出来高（1000株） trading_vol
            //

            //
            //ここから始値処理
            //

            //プログレスバーの設定
            opening_Bar.Minimum = 0;
            opening_Bar.Maximum = num_files;

            if (opening_price.Checked == true)
            {
                int value = 2;
                string file_name;

                if (value == 0)
                {
                    file_name = "brand_code";
                }
                else if (value == 1)
                {
                    file_name = "brand_name";
                }
                else if (value == 2)
                {
                    file_name = "opening_price";
                }
                else if (value == 3)
                {
                    file_name = "high_price";
                }
                else if (value == 4)
                {
                    file_name = "low_price";
                }
                else if (value == 5)
                {
                    file_name = "closing_price";
                }
                else if (value == 6)
                {
                    file_name = "trading_vol";
                }
                else
                {
                    file_name = "";
                }

                //System.IO.Path.GetDirectoryName(Folder_place.Text );

                //
                //新たなファイルを用意する前に既存ファイル削除
                //

                //System.IO.File.Delete(@"M:\Manabu MyDocuments\ドキュメント\stock\test_mod.csv");
                System.IO.File.Delete(@Folder_place.Text + "_" + file_name + ".csv");

                Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                System.IO.StreamWriter writer = new System.IO.StreamWriter(@Folder_place.Text + "_" + file_name + ".csv", true, sjisEnc);

                ////
                ////１行目のラベル（銘柄コード）
                ////
                writer.Write(",");

                for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                {
                    for (days = 1; days <= num_files; days++)
                    {
                        if (data_file[days, stock_num, 0] == null)
                        {
                            //飛ばすだけなので空白でOK。
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, 0] + ",");
                            days = num_files;
                        }
                    }
                }
                writer.Write("\r\n");


                ////
                ////２行目のラベル（企業名）
                ////
                writer.Write(",");

                for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                {
                    for (days = 1; days <= num_files; days++)
                    {
                        if (data_file[days, stock_num, 1] == null)
                        {
                            //飛ばすだけなので空白でOK。
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, 1] + ",");
                            days = num_files;
                        }
                    }
                }
                writer.Write("\r\n");


                //
                //日々の値
                //
                for (days = 1; days <= num_files; days++)
                {
                    writer.Write(data_file[days, 1000, 0] + ",");

                    for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                    {
                        if (data_file[days, stock_num, value] == null)
                        {
                            for (int days2 = 1; days2 <= num_files; days2++)
                            {
                                if (data_file[days2, stock_num, 0] == null)
                                {
                                    //飛ばすだけなので空白でOK。
                                }
                                else
                                {
                                    writer.Write(",");
                                    days2 = num_files;
                                }

                            }
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, value] + ",");
                        }
                    }
                    writer.Write("\r\n");


                    //プログレスバーの設置
                    progress_status = (int)((days / num_files) * 100);
                    //progressBar1.Increment(progress_status);
                    opening_Bar.PerformStep();

                    //intをstringに変換
                    num_files_st = num_files.ToString();
                    days_st = days.ToString();

                    //進捗率表示用
                    //total_num.Text = num_files_st;
                    opening_progress_num.Text = days_st;


                }

                writer.Close();

                //
                //ここまでファイル書き出し
                //
            }
            else
            {

            }
            //
            //ここまで始値処理
            //

            //
            //ここから終値処理
            //

            //プログレスバーの設定
            closing_Bar.Minimum = 0;
            closing_Bar.Maximum = num_files;

            if (closing_price.Checked == true)
            {
                int value = 5;
                string file_name;

                if (value == 0)
                {
                    file_name = "brand_code";
                }
                else if (value == 1)
                {
                    file_name = "brand_name";
                }
                else if (value == 2)
                {
                    file_name = "opening_price";
                }
                else if (value == 3)
                {
                    file_name = "high_price";
                }
                else if (value == 4)
                {
                    file_name = "low_price";
                }
                else if (value == 5)
                {
                    file_name = "closing_price";
                }
                else if (value == 6)
                {
                    file_name = "trading_vol";
                }
                else
                {
                    file_name = "";
                }

                //System.IO.Path.GetDirectoryName(Folder_place.Text );

                //
                //新たなファイルを用意する前に既存ファイル削除
                //

                //System.IO.File.Delete(@"M:\Manabu MyDocuments\ドキュメント\stock\test_mod.csv");
                System.IO.File.Delete(@Folder_place.Text + "_" + file_name + ".csv");

                Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                System.IO.StreamWriter writer = new System.IO.StreamWriter(@Folder_place.Text + "_" + file_name + ".csv", true, sjisEnc);

                ////
                ////１行目のラベル（銘柄コード）
                ////
                writer.Write(",");

                for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                {
                    for (days = 1; days <= num_files; days++)
                    {
                        if (data_file[days, stock_num, 0] == null)
                        {
                            //飛ばすだけなので空白でOK。
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, 0] + ",");
                            days = num_files;
                        }
                    }
                }
                writer.Write("\r\n");


                ////
                ////２行目のラベル（企業名）
                ////
                writer.Write(",");

                for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                {
                    for (days = 1; days <= num_files; days++)
                    {
                        if (data_file[days, stock_num, 1] == null)
                        {
                            //飛ばすだけなので空白でOK。
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, 1] + ",");
                            days = num_files;
                        }
                    }
                }
                writer.Write("\r\n");


                //
                //日々の値
                //
                for (days = 1; days <= num_files; days++)
                {
                    writer.Write(data_file[days, 1000, 0] + ",");

                    for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                    {
                        if (data_file[days, stock_num, value] == null)
                        {
                            for (int days2 = 1; days2 <= num_files; days2++)
                            {
                                if (data_file[days2, stock_num, 0] == null)
                                {
                                    //飛ばすだけなので空白でOK。
                                }
                                else
                                {
                                    writer.Write(",");
                                    days2 = num_files;
                                }

                            }
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, value] + ",");
                        }
                    }
                    writer.Write("\r\n");


                    //プログレスバーの設置
                    progress_status = (int)((days / num_files) * 100);
                    //progressBar1.Increment(progress_status);
                    closing_Bar.PerformStep();

                    //intをstringに変換
                    num_files_st = num_files.ToString();
                    days_st = days.ToString();

                    //進捗率表示用
                    closing_total_num.Text = num_files_st;
                    closing_progress_num.Text = days_st;


                }

                writer.Close();

                //
                //ここまでファイル書き出し
                //
            }
            else
            {

            }
            //
            //ここまで終値処理
            //

            //
            //ここから高値処理
            //

            //プログレスバーの設定
            highest_Bar.Minimum = 0;
            highest_Bar.Maximum = num_files;

            if (highest_price.Checked == true)
            {
                int value = 3;
                string file_name;

                if (value == 0)
                {
                    file_name = "brand_code";
                }
                else if (value == 1)
                {
                    file_name = "brand_name";
                }
                else if (value == 2)
                {
                    file_name = "opening_price";
                }
                else if (value == 3)
                {
                    file_name = "high_price";
                }
                else if (value == 4)
                {
                    file_name = "low_price";
                }
                else if (value == 5)
                {
                    file_name = "closing_price";
                }
                else if (value == 6)
                {
                    file_name = "trading_vol";
                }
                else
                {
                    file_name = "";
                }

                //System.IO.Path.GetDirectoryName(Folder_place.Text );

                //
                //新たなファイルを用意する前に既存ファイル削除
                //

                //System.IO.File.Delete(@"M:\Manabu MyDocuments\ドキュメント\stock\test_mod.csv");
                System.IO.File.Delete(@Folder_place.Text + "_" + file_name + ".csv");

                Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                System.IO.StreamWriter writer = new System.IO.StreamWriter(@Folder_place.Text + "_" + file_name + ".csv", true, sjisEnc);

                ////
                ////１行目のラベル（銘柄コード）
                ////
                writer.Write(",");

                for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                {
                    for (days = 1; days <= num_files; days++)
                    {
                        if (data_file[days, stock_num, 0] == null)
                        {
                            //飛ばすだけなので空白でOK。
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, 0] + ",");
                            days = num_files;
                        }
                    }
                }
                writer.Write("\r\n");


                ////
                ////２行目のラベル（企業名）
                ////
                writer.Write(",");

                for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                {
                    for (days = 1; days <= num_files; days++)
                    {
                        if (data_file[days, stock_num, 1] == null)
                        {
                            //飛ばすだけなので空白でOK。
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, 1] + ",");
                            days = num_files;
                        }
                    }
                }
                writer.Write("\r\n");


                //
                //日々の値
                //
                for (days = 1; days <= num_files; days++)
                {
                    writer.Write(data_file[days, 1000, 0] + ",");

                    for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                    {
                        if (data_file[days, stock_num, value] == null)
                        {
                            for (int days2 = 1; days2 <= num_files; days2++)
                            {
                                if (data_file[days2, stock_num, 0] == null)
                                {
                                    //飛ばすだけなので空白でOK。
                                }
                                else
                                {
                                    writer.Write(",");
                                    days2 = num_files;
                                }

                            }
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, value] + ",");
                        }
                    }
                    writer.Write("\r\n");


                    //プログレスバーの設置
                    progress_status = (int)((days / num_files) * 100);
                    //progressBar1.Increment(progress_status);
                    highest_Bar.PerformStep();

                    //intをstringに変換
                    num_files_st = num_files.ToString();
                    days_st = days.ToString();

                    //進捗率表示用
                    highest_total_num.Text = num_files_st;
                    highest_progress_num.Text = days_st;


                }

                writer.Close();

                //
                //ここまでファイル書き出し
                //
            }
            else
            {

            }
            //
            //ここまで高値処理
            //

            //
            //ここから安値処理
            //

            //プログレスバーの設定
            lowest_Bar.Minimum = 0;
            lowest_Bar.Maximum = num_files;

            if (lowest_price.Checked == true)
            {
                int value = 4;
                string file_name;

                if (value == 0)
                {
                    file_name = "brand_code";
                }
                else if (value == 1)
                {
                    file_name = "brand_name";
                }
                else if (value == 2)
                {
                    file_name = "opening_price";
                }
                else if (value == 3)
                {
                    file_name = "high_price";
                }
                else if (value == 4)
                {
                    file_name = "low_price";
                }
                else if (value == 5)
                {
                    file_name = "closing_price";
                }
                else if (value == 6)
                {
                    file_name = "trading_vol";
                }
                else
                {
                    file_name = "";
                }

                //System.IO.Path.GetDirectoryName(Folder_place.Text );

                //
                //新たなファイルを用意する前に既存ファイル削除
                //

                //System.IO.File.Delete(@"M:\Manabu MyDocuments\ドキュメント\stock\test_mod.csv");
                System.IO.File.Delete(@Folder_place.Text + "_" + file_name + ".csv");

                Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                System.IO.StreamWriter writer = new System.IO.StreamWriter(@Folder_place.Text + "_" + file_name + ".csv", true, sjisEnc);

                ////
                ////１行目のラベル（銘柄コード）
                ////
                writer.Write(",");

                for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                {
                    for (days = 1; days <= num_files; days++)
                    {
                        if (data_file[days, stock_num, 0] == null)
                        {
                            //飛ばすだけなので空白でOK。
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, 0] + ",");
                            days = num_files;
                        }
                    }
                }
                writer.Write("\r\n");


                ////
                ////２行目のラベル（企業名）
                ////
                writer.Write(",");

                for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                {
                    for (days = 1; days <= num_files; days++)
                    {
                        if (data_file[days, stock_num, 1] == null)
                        {
                            //飛ばすだけなので空白でOK。
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, 1] + ",");
                            days = num_files;
                        }
                    }
                }
                writer.Write("\r\n");


                //
                //日々の値
                //
                for (days = 1; days <= num_files; days++)
                {
                    writer.Write(data_file[days, 1000, 0] + ",");

                    for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                    {
                        if (data_file[days, stock_num, value] == null)
                        {
                            for (int days2 = 1; days2 <= num_files; days2++)
                            {
                                if (data_file[days2, stock_num, 0] == null)
                                {
                                    //飛ばすだけなので空白でOK。
                                }
                                else
                                {
                                    writer.Write(",");
                                    days2 = num_files;
                                }

                            }
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, value] + ",");
                        }
                    }
                    writer.Write("\r\n");


                    //プログレスバーの設置
                    progress_status = (int)((days / num_files) * 100);
                    //progressBar1.Increment(progress_status);
                    lowest_Bar.PerformStep();

                    //intをstringに変換
                    num_files_st = num_files.ToString();
                    days_st = days.ToString();

                    //進捗率表示用
                    lowest_total_num.Text = num_files_st;
                    lowest_progress_num.Text = days_st;


                }

                writer.Close();

                //
                //ここまでファイル書き出し
                //
            }
            else
            {

            }
            //
            //ここまで安値処理
            //

            //
            //ここから出来高処理
            //

            //プログレスバーの設定
            trading_Bar.Minimum = 0;
            trading_Bar.Maximum = num_files;

            if (trading_amount.Checked == true)
            {
                int value = 6;
                string file_name;
                               
                if (value == 0)
                {
                    file_name = "brand_code";
                }
                else if (value == 1)
                {
                    file_name = "brand_name";
                }
                else if (value == 2)
                {
                    file_name = "opening_price";
                }
                else if (value == 3)
                {
                    file_name = "high_price";
                }
                else if (value == 4)
                {
                    file_name = "low_price";
                }
                else if (value == 5)
                {
                    file_name = "closing_price";
                }
                else if (value == 6)
                {
                    file_name = "trading_vol";
                }
                else
                {
                    file_name = "";
                }

                //System.IO.Path.GetDirectoryName(Folder_place.Text );

                //
                //新たなファイルを用意する前に既存ファイル削除
                //

                //System.IO.File.Delete(@"M:\Manabu MyDocuments\ドキュメント\stock\test_mod.csv");
                System.IO.File.Delete(@Folder_place.Text + "_" + file_name + ".csv");

                Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                System.IO.StreamWriter writer = new System.IO.StreamWriter(@Folder_place.Text + "_" + file_name + ".csv", true, sjisEnc);

                ////
                ////１行目のラベル（銘柄コード）
                ////
                writer.Write(",");

                for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                {
                    for (days = 1; days <= num_files; days++)
                    {
                        if (data_file[days, stock_num, 0] == null)
                        {
                            //飛ばすだけなので空白でOK。
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, 0] + ",");
                            days = num_files;
                        }
                    }
                }
                writer.Write("\r\n");


                ////
                ////２行目のラベル（企業名）
                ////
                writer.Write(",");

                for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                {
                    for (days = 1; days <= num_files; days++)
                    {
                        if (data_file[days, stock_num, 1] == null)
                        {
                            //飛ばすだけなので空白でOK。
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, 1] + ",");
                            days = num_files;
                        }
                    }
                }
                writer.Write("\r\n");


                //
                //日々の値
                //
                for (days = 1; days <= num_files; days++)
                {
                    writer.Write(data_file[days, 1000, 0] + ",");

                    for (stock_num = Min_stock_num + 1; stock_num <= Max_stock_num; stock_num++)
                    {
                        if (data_file[days, stock_num, value] == null)
                        {
                            for (int days2 = 1; days2 <= num_files; days2++)
                            {
                                if (data_file[days2, stock_num, 0] == null)
                                {
                                    //飛ばすだけなので空白でOK。
                                }
                                else
                                {
                                    writer.Write(",");
                                    days2 = num_files;
                                }

                            }
                            //writer.Write(",");
                        }
                        else
                        {
                            writer.Write(data_file[days, stock_num, value] + ",");
                        }
                    }
                    writer.Write("\r\n");


                    //プログレスバーの設置
                    progress_status = (int)((days / num_files) * 100);
                    //progressBar1.Increment(progress_status);
                    trading_Bar.PerformStep();

                    //intをstringに変換
                    num_files_st = num_files.ToString();
                    days_st = days.ToString();

                    //進捗率表示用
                    trading_total_num.Text = num_files_st;
                    trading_progress_num.Text = days_st;


                }

                writer.Close();

                //
                //ここまでファイル書き出し
                //
            }
            else
            {

            }
            //
            //ここまで出来高処理
            //

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Quit_Button(object sender, EventArgs e)
        {
            MessageBox.Show("終了します。", "通知");
            //アプリケーションを終了する。
            Application.Exit();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progress_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void highest_price_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void opening_price_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void closing_price_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void lowest_price_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void trading_amount_CheckedChanged(object sender, EventArgs e)
        {
     
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void progressBar5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
