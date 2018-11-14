namespace POS.Views
{
    partial class StartUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            /*if (disposing && (components != null))
            {
                components.Dispose();
            }*/
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._customLayout1 = new System.Windows.Forms.TableLayoutPanel();
            this._customLayout2 = new System.Windows.Forms.TableLayoutPanel();
            this._exit = new System.Windows.Forms.Button();
            this._front = new System.Windows.Forms.Button();
            this._back = new System.Windows.Forms.Button();
            this._customLayout1.SuspendLayout();
            this._customLayout2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _customLayout1
            // 
            this._customLayout1.ColumnCount = 1;
            this._customLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this._customLayout1.Controls.Add(this._customLayout2, 0, 2);
            this._customLayout1.Controls.Add(this._front, 0, 0);
            this._customLayout1.Controls.Add(this._back, 0, 1);
            this._customLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout1.Location = new System.Drawing.Point(0, 0);
            this._customLayout1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._customLayout1.Name = "_customLayout1";
            this._customLayout1.RowCount = 3;
            this._customLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._customLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._customLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._customLayout1.Size = new System.Drawing.Size(615, 522);
            this._customLayout1.TabIndex = 0;
            // 
            // _customLayout2
            // 
            this._customLayout2.ColumnCount = 4;
            this._customLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._customLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._customLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._customLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._customLayout2.Controls.Add(this._exit, 3, 0);
            this._customLayout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout2.Location = new System.Drawing.Point(7, 354);
            this._customLayout2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._customLayout2.Name = "_customLayout2";
            this._customLayout2.RowCount = 1;
            this._customLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this._customLayout2.Size = new System.Drawing.Size(601, 162);
            this._customLayout2.TabIndex = 0;
            // 
            // _exit
            // 
            this._exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._exit.Location = new System.Drawing.Point(457, 6);
            this._exit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._exit.Name = "_exit";
            this._exit.Size = new System.Drawing.Size(137, 150);
            this._exit.TabIndex = 0;
            this._exit.Text = "Exit";
            this._exit.UseVisualStyleBackColor = true;
            this._exit.Click += new System.EventHandler(this.ClickExit);
            // 
            // _front
            // 
            this._front.Dock = System.Windows.Forms.DockStyle.Fill;
            this._front.Location = new System.Drawing.Point(7, 6);
            this._front.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._front.Name = "_front";
            this._front.Size = new System.Drawing.Size(601, 162);
            this._front.TabIndex = 1;
            this._front.Text = "Start the Customer Program (Frontend)";
            this._front.UseVisualStyleBackColor = true;
            this._front.Click += new System.EventHandler(this.ClickFront);
            // 
            // _back
            // 
            this._back.Dock = System.Windows.Forms.DockStyle.Fill;
            this._back.Location = new System.Drawing.Point(7, 180);
            this._back.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._back.Name = "_back";
            this._back.Size = new System.Drawing.Size(601, 162);
            this._back.TabIndex = 2;
            this._back.Text = "Start the Restaurant Program (Backend)";
            this._back.UseVisualStyleBackColor = true;
            this._back.Click += new System.EventHandler(this.ClickBack);
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 522);
            this.Controls.Add(this._customLayout1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "StartUpForm";
            this.Text = "StartUp";
            this._customLayout1.ResumeLayout(false);
            this._customLayout2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _customLayout1;
        private System.Windows.Forms.TableLayoutPanel _customLayout2;
        private System.Windows.Forms.Button _exit;
        private System.Windows.Forms.Button _front;
        private System.Windows.Forms.Button _back;
    }
}