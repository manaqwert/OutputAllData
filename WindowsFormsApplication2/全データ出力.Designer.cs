namespace WindowsFormsApplication2
{
    partial class データ出力
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Get_FileList = new System.Windows.Forms.Button();
            this.File_List_Box = new System.Windows.Forms.ListBox();
            this.Folder_place = new System.Windows.Forms.TextBox();
            this.Number_of_files = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.opening_Bar = new System.Windows.Forms.ProgressBar();
            this.opening_progress_num = new System.Windows.Forms.TextBox();
            this.opeing_total_num = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.opening_price = new System.Windows.Forms.CheckBox();
            this.closing_price = new System.Windows.Forms.CheckBox();
            this.highest_price = new System.Windows.Forms.CheckBox();
            this.lowest_price = new System.Windows.Forms.CheckBox();
            this.trading_amount = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.closing_total_num = new System.Windows.Forms.TextBox();
            this.closing_progress_num = new System.Windows.Forms.TextBox();
            this.closing_Bar = new System.Windows.Forms.ProgressBar();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lowest_total_num = new System.Windows.Forms.TextBox();
            this.lowest_progress_num = new System.Windows.Forms.TextBox();
            this.lowest_Bar = new System.Windows.Forms.ProgressBar();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.highest_total_num = new System.Windows.Forms.TextBox();
            this.highest_progress_num = new System.Windows.Forms.TextBox();
            this.highest_Bar = new System.Windows.Forms.ProgressBar();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.trading_total_num = new System.Windows.Forms.TextBox();
            this.trading_progress_num = new System.Windows.Forms.TextBox();
            this.trading_Bar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Get_FileList
            // 
            this.Get_FileList.Location = new System.Drawing.Point(1199, 42);
            this.Get_FileList.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Get_FileList.Name = "Get_FileList";
            this.Get_FileList.Size = new System.Drawing.Size(194, 37);
            this.Get_FileList.TabIndex = 1;
            this.Get_FileList.Text = "File List";
            this.Get_FileList.UseVisualStyleBackColor = true;
            this.Get_FileList.Click += new System.EventHandler(this.Get_file_List_Button);
            // 
            // File_List_Box
            // 
            this.File_List_Box.FormattingEnabled = true;
            this.File_List_Box.ItemHeight = 21;
            this.File_List_Box.Location = new System.Drawing.Point(15, 159);
            this.File_List_Box.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.File_List_Box.Name = "File_List_Box";
            this.File_List_Box.Size = new System.Drawing.Size(1377, 340);
            this.File_List_Box.TabIndex = 2;
            this.File_List_Box.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Folder_place
            // 
            this.Folder_place.Location = new System.Drawing.Point(15, 42);
            this.Folder_place.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Folder_place.Name = "Folder_place";
            this.Folder_place.Size = new System.Drawing.Size(1172, 28);
            this.Folder_place.TabIndex = 3;
            this.Folder_place.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Number_of_files
            // 
            this.Number_of_files.Location = new System.Drawing.Point(216, 84);
            this.Number_of_files.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Number_of_files.Name = "Number_of_files";
            this.Number_of_files.Size = new System.Drawing.Size(189, 28);
            this.Number_of_files.TabIndex = 4;
            this.Number_of_files.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(28, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "ファイル数：";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(1190, 739);
            this.exit_button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(202, 40);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "終了";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.Quit_Button);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(22, 128);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 21);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "ファイルリスト：";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // opening_Bar
            // 
            this.opening_Bar.Location = new System.Drawing.Point(175, 527);
            this.opening_Bar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.opening_Bar.Name = "opening_Bar";
            this.opening_Bar.Size = new System.Drawing.Size(930, 30);
            this.opening_Bar.TabIndex = 10;
            this.opening_Bar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // opening_progress_num
            // 
            this.opening_progress_num.Location = new System.Drawing.Point(1117, 527);
            this.opening_progress_num.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.opening_progress_num.Name = "opening_progress_num";
            this.opening_progress_num.Size = new System.Drawing.Size(110, 28);
            this.opening_progress_num.TabIndex = 12;
            this.opening_progress_num.TextChanged += new System.EventHandler(this.progress_num_TextChanged);
            // 
            // opeing_total_num
            // 
            this.opeing_total_num.Location = new System.Drawing.Point(1280, 527);
            this.opeing_total_num.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.opeing_total_num.Name = "opeing_total_num";
            this.opeing_total_num.Size = new System.Drawing.Size(110, 28);
            this.opeing_total_num.TabIndex = 13;
            this.opeing_total_num.TextChanged += new System.EventHandler(this.total_num_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(1241, 536);
            this.textBox7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(28, 21);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = "/";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // opening_price
            // 
            this.opening_price.AutoSize = true;
            this.opening_price.Location = new System.Drawing.Point(56, 532);
            this.opening_price.Name = "opening_price";
            this.opening_price.Size = new System.Drawing.Size(89, 25);
            this.opening_price.TabIndex = 16;
            this.opening_price.Text = "：始値";
            this.opening_price.UseVisualStyleBackColor = true;
            this.opening_price.CheckedChanged += new System.EventHandler(this.opening_price_CheckedChanged);
            // 
            // closing_price
            // 
            this.closing_price.AutoSize = true;
            this.closing_price.Location = new System.Drawing.Point(56, 570);
            this.closing_price.Name = "closing_price";
            this.closing_price.Size = new System.Drawing.Size(89, 25);
            this.closing_price.TabIndex = 18;
            this.closing_price.Text = "：終値";
            this.closing_price.UseVisualStyleBackColor = true;
            this.closing_price.CheckedChanged += new System.EventHandler(this.closing_price_CheckedChanged);
            // 
            // highest_price
            // 
            this.highest_price.AutoSize = true;
            this.highest_price.Location = new System.Drawing.Point(56, 610);
            this.highest_price.Name = "highest_price";
            this.highest_price.Size = new System.Drawing.Size(89, 25);
            this.highest_price.TabIndex = 20;
            this.highest_price.Text = "：高値";
            this.highest_price.UseVisualStyleBackColor = true;
            this.highest_price.CheckedChanged += new System.EventHandler(this.highest_price_CheckedChanged);
            // 
            // lowest_price
            // 
            this.lowest_price.AutoSize = true;
            this.lowest_price.Location = new System.Drawing.Point(56, 650);
            this.lowest_price.Name = "lowest_price";
            this.lowest_price.Size = new System.Drawing.Size(89, 25);
            this.lowest_price.TabIndex = 22;
            this.lowest_price.Text = "：安値";
            this.lowest_price.UseVisualStyleBackColor = true;
            this.lowest_price.CheckedChanged += new System.EventHandler(this.lowest_price_CheckedChanged);
            // 
            // trading_amount
            // 
            this.trading_amount.AutoSize = true;
            this.trading_amount.Location = new System.Drawing.Point(56, 690);
            this.trading_amount.Name = "trading_amount";
            this.trading_amount.Size = new System.Drawing.Size(110, 25);
            this.trading_amount.TabIndex = 25;
            this.trading_amount.Text = "：出来高";
            this.trading_amount.UseVisualStyleBackColor = true;
            this.trading_amount.CheckedChanged += new System.EventHandler(this.trading_amount_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1009, 739);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(1241, 576);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(28, 21);
            this.textBox3.TabIndex = 31;
            this.textBox3.Text = "/";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closing_total_num
            // 
            this.closing_total_num.Location = new System.Drawing.Point(1280, 567);
            this.closing_total_num.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.closing_total_num.Name = "closing_total_num";
            this.closing_total_num.Size = new System.Drawing.Size(110, 28);
            this.closing_total_num.TabIndex = 30;
            this.closing_total_num.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // closing_progress_num
            // 
            this.closing_progress_num.Location = new System.Drawing.Point(1117, 567);
            this.closing_progress_num.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.closing_progress_num.Name = "closing_progress_num";
            this.closing_progress_num.Size = new System.Drawing.Size(110, 28);
            this.closing_progress_num.TabIndex = 29;
            this.closing_progress_num.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // closing_Bar
            // 
            this.closing_Bar.Location = new System.Drawing.Point(175, 567);
            this.closing_Bar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.closing_Bar.Name = "closing_Bar";
            this.closing_Bar.Size = new System.Drawing.Size(930, 30);
            this.closing_Bar.TabIndex = 28;
            this.closing_Bar.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(1241, 656);
            this.textBox6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(28, 21);
            this.textBox6.TabIndex = 35;
            this.textBox6.Text = "/";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lowest_total_num
            // 
            this.lowest_total_num.Location = new System.Drawing.Point(1280, 647);
            this.lowest_total_num.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lowest_total_num.Name = "lowest_total_num";
            this.lowest_total_num.Size = new System.Drawing.Size(110, 28);
            this.lowest_total_num.TabIndex = 34;
            this.lowest_total_num.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // lowest_progress_num
            // 
            this.lowest_progress_num.Location = new System.Drawing.Point(1117, 647);
            this.lowest_progress_num.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lowest_progress_num.Name = "lowest_progress_num";
            this.lowest_progress_num.Size = new System.Drawing.Size(110, 28);
            this.lowest_progress_num.TabIndex = 33;
            this.lowest_progress_num.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // lowest_Bar
            // 
            this.lowest_Bar.Location = new System.Drawing.Point(175, 647);
            this.lowest_Bar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lowest_Bar.Name = "lowest_Bar";
            this.lowest_Bar.Size = new System.Drawing.Size(930, 30);
            this.lowest_Bar.TabIndex = 32;
            this.lowest_Bar.Click += new System.EventHandler(this.progressBar3_Click);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(1241, 616);
            this.textBox10.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(28, 21);
            this.textBox10.TabIndex = 39;
            this.textBox10.Text = "/";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // highest_total_num
            // 
            this.highest_total_num.Location = new System.Drawing.Point(1280, 607);
            this.highest_total_num.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.highest_total_num.Name = "highest_total_num";
            this.highest_total_num.Size = new System.Drawing.Size(110, 28);
            this.highest_total_num.TabIndex = 38;
            this.highest_total_num.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // highest_progress_num
            // 
            this.highest_progress_num.Location = new System.Drawing.Point(1117, 607);
            this.highest_progress_num.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.highest_progress_num.Name = "highest_progress_num";
            this.highest_progress_num.Size = new System.Drawing.Size(110, 28);
            this.highest_progress_num.TabIndex = 37;
            this.highest_progress_num.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // highest_Bar
            // 
            this.highest_Bar.Location = new System.Drawing.Point(175, 607);
            this.highest_Bar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.highest_Bar.Name = "highest_Bar";
            this.highest_Bar.Size = new System.Drawing.Size(930, 30);
            this.highest_Bar.TabIndex = 36;
            this.highest_Bar.Click += new System.EventHandler(this.progressBar4_Click);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(1241, 696);
            this.textBox13.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(28, 21);
            this.textBox13.TabIndex = 43;
            this.textBox13.Text = "/";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trading_total_num
            // 
            this.trading_total_num.Location = new System.Drawing.Point(1280, 687);
            this.trading_total_num.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.trading_total_num.Name = "trading_total_num";
            this.trading_total_num.Size = new System.Drawing.Size(110, 28);
            this.trading_total_num.TabIndex = 42;
            this.trading_total_num.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // trading_progress_num
            // 
            this.trading_progress_num.Location = new System.Drawing.Point(1117, 687);
            this.trading_progress_num.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.trading_progress_num.Name = "trading_progress_num";
            this.trading_progress_num.Size = new System.Drawing.Size(110, 28);
            this.trading_progress_num.TabIndex = 41;
            this.trading_progress_num.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // trading_Bar
            // 
            this.trading_Bar.Location = new System.Drawing.Point(175, 687);
            this.trading_Bar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.trading_Bar.Name = "trading_Bar";
            this.trading_Bar.Size = new System.Drawing.Size(930, 30);
            this.trading_Bar.TabIndex = 40;
            this.trading_Bar.Click += new System.EventHandler(this.progressBar5_Click);
            // 
            // データ出力
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 801);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.trading_total_num);
            this.Controls.Add(this.trading_progress_num);
            this.Controls.Add(this.trading_Bar);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.highest_total_num);
            this.Controls.Add(this.highest_progress_num);
            this.Controls.Add(this.highest_Bar);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lowest_total_num);
            this.Controls.Add(this.lowest_progress_num);
            this.Controls.Add(this.lowest_Bar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.closing_total_num);
            this.Controls.Add(this.closing_progress_num);
            this.Controls.Add(this.closing_Bar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trading_amount);
            this.Controls.Add(this.lowest_price);
            this.Controls.Add(this.highest_price);
            this.Controls.Add(this.closing_price);
            this.Controls.Add(this.opening_price);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.opeing_total_num);
            this.Controls.Add(this.opening_progress_num);
            this.Controls.Add(this.opening_Bar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Number_of_files);
            this.Controls.Add(this.Folder_place);
            this.Controls.Add(this.File_List_Box);
            this.Controls.Add(this.Get_FileList);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "データ出力";
            this.Text = "全データ出力";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Get_FileList;
        private System.Windows.Forms.ListBox File_List_Box;
        private System.Windows.Forms.TextBox Folder_place;
        private System.Windows.Forms.TextBox Number_of_files;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ProgressBar opening_Bar;
        private System.Windows.Forms.TextBox opening_progress_num;
        private System.Windows.Forms.TextBox opeing_total_num;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.CheckBox opening_price;
        private System.Windows.Forms.CheckBox closing_price;
        private System.Windows.Forms.CheckBox highest_price;
        private System.Windows.Forms.CheckBox lowest_price;
        private System.Windows.Forms.CheckBox trading_amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox closing_total_num;
        private System.Windows.Forms.TextBox closing_progress_num;
        private System.Windows.Forms.ProgressBar closing_Bar;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox lowest_total_num;
        private System.Windows.Forms.TextBox lowest_progress_num;
        private System.Windows.Forms.ProgressBar lowest_Bar;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox highest_total_num;
        private System.Windows.Forms.TextBox highest_progress_num;
        private System.Windows.Forms.ProgressBar highest_Bar;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox trading_total_num;
        private System.Windows.Forms.TextBox trading_progress_num;
        private System.Windows.Forms.ProgressBar trading_Bar;
    }
}

