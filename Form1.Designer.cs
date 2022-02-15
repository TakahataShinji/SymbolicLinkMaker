
namespace SymbolicLinkMaker
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.TextBox_Linkee = new System.Windows.Forms.TextBox();
            this.Button_Browse_Linkee = new System.Windows.Forms.Button();
            this.Button_Browse_Location = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Location = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_LinkName = new System.Windows.Forms.TextBox();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Execute = new System.Windows.Forms.Button();
            this.RadioButton_File = new System.Windows.Forms.RadioButton();
            this.RadioButton_Folder = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_Linkee
            // 
            this.TextBox_Linkee.Location = new System.Drawing.Point(13, 20);
            this.TextBox_Linkee.Name = "TextBox_Linkee";
            this.TextBox_Linkee.Size = new System.Drawing.Size(521, 21);
            this.TextBox_Linkee.TabIndex = 0;
            // 
            // Button_Browse_Linkee
            // 
            this.Button_Browse_Linkee.AutoSize = true;
            this.Button_Browse_Linkee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Browse_Linkee.Location = new System.Drawing.Point(540, 18);
            this.Button_Browse_Linkee.Name = "Button_Browse_Linkee";
            this.Button_Browse_Linkee.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Button_Browse_Linkee.Size = new System.Drawing.Size(35, 25);
            this.Button_Browse_Linkee.TabIndex = 1;
            this.Button_Browse_Linkee.Text = ">>";
            this.Button_Browse_Linkee.UseVisualStyleBackColor = true;
            this.Button_Browse_Linkee.Click += new System.EventHandler(this.Button_Browse_Linkee_Click);
            // 
            // Button_Browse_Location
            // 
            this.Button_Browse_Location.AutoSize = true;
            this.Button_Browse_Location.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Browse_Location.Location = new System.Drawing.Point(552, 96);
            this.Button_Browse_Location.Name = "Button_Browse_Location";
            this.Button_Browse_Location.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Button_Browse_Location.Size = new System.Drawing.Size(35, 25);
            this.Button_Browse_Location.TabIndex = 5;
            this.Button_Browse_Location.Text = ">>";
            this.Button_Browse_Location.UseVisualStyleBackColor = true;
            this.Button_Browse_Location.Click += new System.EventHandler(this.Button_Browse_Location_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "作成先";
            // 
            // TextBox_Location
            // 
            this.TextBox_Location.Location = new System.Drawing.Point(59, 98);
            this.TextBox_Location.Name = "TextBox_Location";
            this.TextBox_Location.Size = new System.Drawing.Size(487, 21);
            this.TextBox_Location.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "リンク名";
            // 
            // TextBox_LinkName
            // 
            this.TextBox_LinkName.Location = new System.Drawing.Point(59, 131);
            this.TextBox_LinkName.Name = "TextBox_LinkName";
            this.TextBox_LinkName.Size = new System.Drawing.Size(487, 21);
            this.TextBox_LinkName.TabIndex = 6;
            // 
            // Button_Exit
            // 
            this.Button_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Exit.Location = new System.Drawing.Point(605, 85);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Button_Exit.Size = new System.Drawing.Size(134, 67);
            this.Button_Exit.TabIndex = 8;
            this.Button_Exit.Text = "終了";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Execute
            // 
            this.Button_Execute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Execute.Location = new System.Drawing.Point(605, 12);
            this.Button_Execute.Name = "Button_Execute";
            this.Button_Execute.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Button_Execute.Size = new System.Drawing.Size(134, 67);
            this.Button_Execute.TabIndex = 7;
            this.Button_Execute.Text = "作成";
            this.Button_Execute.UseVisualStyleBackColor = true;
            this.Button_Execute.Click += new System.EventHandler(this.Button_Execute_Click);
            // 
            // RadioButton_File
            // 
            this.RadioButton_File.AutoSize = true;
            this.RadioButton_File.Location = new System.Drawing.Point(75, 47);
            this.RadioButton_File.Name = "RadioButton_File";
            this.RadioButton_File.Size = new System.Drawing.Size(55, 18);
            this.RadioButton_File.TabIndex = 2;
            this.RadioButton_File.Text = "ファイル";
            this.RadioButton_File.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Folder
            // 
            this.RadioButton_Folder.AutoSize = true;
            this.RadioButton_Folder.Checked = true;
            this.RadioButton_Folder.Location = new System.Drawing.Point(13, 47);
            this.RadioButton_Folder.Name = "RadioButton_Folder";
            this.RadioButton_Folder.Size = new System.Drawing.Size(56, 18);
            this.RadioButton_Folder.TabIndex = 3;
            this.RadioButton_Folder.TabStop = true;
            this.RadioButton_Folder.Text = "フォルダ";
            this.RadioButton_Folder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButton_File);
            this.groupBox1.Controls.Add(this.RadioButton_Folder);
            this.groupBox1.Controls.Add(this.TextBox_Linkee);
            this.groupBox1.Controls.Add(this.Button_Browse_Linkee);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 76);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参照先";
            // 
            // Form1
            // 
            this.AcceptButton = this.Button_Execute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.Button_Exit;
            this.ClientSize = new System.Drawing.Size(751, 165);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_LinkName);
            this.Controls.Add(this.Button_Execute);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Browse_Location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Location);
            this.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "シンボリックリンクメイカー";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Linkee;
        private System.Windows.Forms.Button Button_Browse_Linkee;
        private System.Windows.Forms.Button Button_Browse_Location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Location;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_LinkName;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Execute;
        private System.Windows.Forms.RadioButton RadioButton_File;
        private System.Windows.Forms.RadioButton RadioButton_Folder;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

