using System;
using System.Drawing;
using System.Windows.Forms;
using DataGridViewNumericUpDownElements;

namespace POS.Views
{
    partial class POSCustomerSideForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
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
            this._customLayout3 = new System.Windows.Forms.TableLayoutPanel();
            this._total = new System.Windows.Forms.Label();
            this._record = new System.Windows.Forms.DataGridView();
            this._mealGroupBox = new System.Windows.Forms.GroupBox();
            this._customLayout4 = new System.Windows.Forms.TableLayoutPanel();
            this._detail = new System.Windows.Forms.RichTextBox();
            this._customLayout5 = new System.Windows.Forms.TableLayoutPanel();
            this._page = new System.Windows.Forms.Label();
            this._previous = new System.Windows.Forms.Button();
            this._next = new System.Windows.Forms.Button();
            this._add = new System.Windows.Forms.Button();
            this._categoryTab = new System.Windows.Forms.TabControl();
            this._mealList = new System.Windows.Forms.TableLayoutPanel();
            this._mealButton0 = new System.Windows.Forms.Button();
            this._mealButton1 = new System.Windows.Forms.Button();
            this._mealButton2 = new System.Windows.Forms.Button();
            this._mealButton3 = new System.Windows.Forms.Button();
            this._mealButton4 = new System.Windows.Forms.Button();
            this._mealButton5 = new System.Windows.Forms.Button();
            this._mealButton6 = new System.Windows.Forms.Button();
            this._mealButton7 = new System.Windows.Forms.Button();
            this._mealButton8 = new System.Windows.Forms.Button();
            this._deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._unitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantityValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantity = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._unitTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._customLayout1.SuspendLayout();
            this._customLayout2.SuspendLayout();
            this._customLayout3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._record)).BeginInit();
            this._mealGroupBox.SuspendLayout();
            this._customLayout4.SuspendLayout();
            this._customLayout5.SuspendLayout();
            this._mealList.SuspendLayout();
            this.SuspendLayout();
            // 
            // _customLayout1
            // 
            this._customLayout1.ColumnCount = 2;
            this._customLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._customLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._customLayout1.Controls.Add(this._customLayout2, 1, 0);
            this._customLayout1.Controls.Add(this._mealGroupBox, 0, 0);
            this._customLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout1.Location = new System.Drawing.Point(0, 0);
            this._customLayout1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._customLayout1.Name = "_customLayout1";
            this._customLayout1.RowCount = 1;
            this._customLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 871F));
            this._customLayout1.Size = new System.Drawing.Size(1306, 871);
            this._customLayout1.TabIndex = 0;
            // 
            // _customLayout2
            // 
            this._customLayout2.ColumnCount = 1;
            this._customLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout2.Controls.Add(this._customLayout3, 0, 1);
            this._customLayout2.Controls.Add(this._record, 0, 0);
            this._customLayout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout2.Location = new System.Drawing.Point(660, 6);
            this._customLayout2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._customLayout2.Name = "_customLayout2";
            this._customLayout2.RowCount = 2;
            this._customLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this._customLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._customLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._customLayout2.Size = new System.Drawing.Size(639, 859);
            this._customLayout2.TabIndex = 0;
            // 
            // _customLayout3
            // 
            this._customLayout3.ColumnCount = 2;
            this._customLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._customLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._customLayout3.Controls.Add(this._total, 1, 0);
            this._customLayout3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout3.Location = new System.Drawing.Point(3, 776);
            this._customLayout3.Name = "_customLayout3";
            this._customLayout3.RowCount = 1;
            this._customLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this._customLayout3.Size = new System.Drawing.Size(633, 80);
            this._customLayout3.TabIndex = 0;
            // 
            // _total
            // 
            this._total.AutoSize = true;
            this._total.Dock = System.Windows.Forms.DockStyle.Fill;
            this._total.ForeColor = System.Drawing.Color.DarkRed;
            this._total.Location = new System.Drawing.Point(319, 0);
            this._total.Name = "_total";
            this._total.Size = new System.Drawing.Size(311, 80);
            this._total.TabIndex = 0;
            this._total.Text = "Total: 0元";
            this._total.SizeChanged += new System.EventHandler(this.ChangeTotalSize);
            // 
            // _record
            // 
            this._record.AllowUserToAddRows = false;
            this._record.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._record.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._deleteColumn,
            this._unitName,
            this._category,
            this._unitPrice,
            this._quantityValue,
            this._quantity,
            this._unitTotal});
            this._record.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._record.Dock = System.Windows.Forms.DockStyle.Fill;
            this._record.Location = new System.Drawing.Point(3, 3);
            this._record.Name = "_record";
            this._record.RowHeadersVisible = false;
            this._record.RowTemplate.Height = 38;
            this._record.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._record.Size = new System.Drawing.Size(633, 767);
            this._record.TabIndex = 1;
            this._record.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCell);
            this._record.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateCell);
            // 
            // _mealGroupBox
            // 
            this._mealGroupBox.Controls.Add(this._customLayout4);
            this._mealGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealGroupBox.Location = new System.Drawing.Point(3, 3);
            this._mealGroupBox.Name = "_mealGroupBox";
            this._mealGroupBox.Size = new System.Drawing.Size(647, 865);
            this._mealGroupBox.TabIndex = 0;
            this._mealGroupBox.TabStop = false;
            this._mealGroupBox.Text = "Meals";
            // 
            // _customLayout4
            // 
            this._customLayout4.ColumnCount = 1;
            this._customLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._customLayout4.Controls.Add(this._detail, 0, 1);
            this._customLayout4.Controls.Add(this._customLayout5, 0, 2);
            this._customLayout4.Controls.Add(this._categoryTab, 0, 0);
            this._customLayout4.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout4.Location = new System.Drawing.Point(3, 32);
            this._customLayout4.Name = "_customLayout4";
            this._customLayout4.RowCount = 3;
            this._customLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this._customLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._customLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._customLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._customLayout4.Size = new System.Drawing.Size(641, 830);
            this._customLayout4.TabIndex = 1;
            // 
            // _detail
            // 
            this._detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this._detail.Location = new System.Drawing.Point(3, 667);
            this._detail.Name = "_detail";
            this._detail.ReadOnly = true;
            this._detail.Size = new System.Drawing.Size(635, 77);
            this._detail.TabIndex = 0;
            this._detail.Text = "";
            // 
            // _customLayout5
            // 
            this._customLayout5.ColumnCount = 4;
            this._customLayout5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._customLayout5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._customLayout5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._customLayout5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._customLayout5.Controls.Add(this._page, 0, 1);
            this._customLayout5.Controls.Add(this._previous, 2, 1);
            this._customLayout5.Controls.Add(this._next, 3, 1);
            this._customLayout5.Controls.Add(this._add, 3, 0);
            this._customLayout5.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout5.Location = new System.Drawing.Point(3, 750);
            this._customLayout5.Name = "_customLayout5";
            this._customLayout5.RowCount = 2;
            this._customLayout5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._customLayout5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._customLayout5.Size = new System.Drawing.Size(635, 77);
            this._customLayout5.TabIndex = 1;
            // 
            // _page
            // 
            this._page.AutoSize = true;
            this._page.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._page.ForeColor = System.Drawing.Color.Blue;
            this._page.Location = new System.Drawing.Point(3, 53);
            this._page.Name = "_page";
            this._page.Size = new System.Drawing.Size(152, 24);
            this._page.TabIndex = 0;
            this._page.Text = "Page: 1/1";
            // 
            // _previous
            // 
            this._previous.Dock = System.Windows.Forms.DockStyle.Fill;
            this._previous.Enabled = false;
            this._previous.Location = new System.Drawing.Point(319, 41);
            this._previous.Name = "_previous";
            this._previous.Size = new System.Drawing.Size(152, 33);
            this._previous.TabIndex = 1;
            this._previous.Text = "Previous";
            this._previous.UseVisualStyleBackColor = true;
            this._previous.Click += new System.EventHandler(this.ClickPrevious);
            // 
            // _next
            // 
            this._next.Dock = System.Windows.Forms.DockStyle.Fill;
            this._next.Enabled = false;
            this._next.Location = new System.Drawing.Point(477, 41);
            this._next.Name = "_next";
            this._next.Size = new System.Drawing.Size(155, 33);
            this._next.TabIndex = 2;
            this._next.Text = "Next";
            this._next.UseVisualStyleBackColor = true;
            this._next.Click += new System.EventHandler(this.ClickNext);
            // 
            // _add
            // 
            this._add.Dock = System.Windows.Forms.DockStyle.Fill;
            this._add.Enabled = false;
            this._add.Location = new System.Drawing.Point(477, 3);
            this._add.Name = "_add";
            this._add.Size = new System.Drawing.Size(155, 32);
            this._add.TabIndex = 3;
            this._add.Text = "Add";
            this._add.UseVisualStyleBackColor = true;
            this._add.Click += new System.EventHandler(this.ClickAdd);
            // 
            // _categoryTab
            // 
            this._categoryTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this._categoryTab.Location = new System.Drawing.Point(3, 3);
            this._categoryTab.Name = "_categoryTab";
            this._categoryTab.SelectedIndex = 0;
            this._categoryTab.Size = new System.Drawing.Size(635, 658);
            this._categoryTab.TabIndex = 2;
            this._categoryTab.SelectedIndexChanged += new System.EventHandler(this.ClickTab);
            // 
            // _mealList
            // 
            this._mealList.ColumnCount = 3;
            this._mealList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._mealList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._mealList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._mealList.Controls.Add(this._mealButton0, 0, 0);
            this._mealList.Controls.Add(this._mealButton1, 1, 0);
            this._mealList.Controls.Add(this._mealButton2, 2, 0);
            this._mealList.Controls.Add(this._mealButton3, 0, 1);
            this._mealList.Controls.Add(this._mealButton4, 1, 1);
            this._mealList.Controls.Add(this._mealButton5, 2, 1);
            this._mealList.Controls.Add(this._mealButton6, 0, 2);
            this._mealList.Controls.Add(this._mealButton7, 1, 2);
            this._mealList.Controls.Add(this._mealButton8, 2, 2);
            this._mealList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealList.Location = new System.Drawing.Point(3, 3);
            this._mealList.Name = "_mealList";
            this._mealList.RowCount = 3;
            this._mealList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._mealList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._mealList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._mealList.Size = new System.Drawing.Size(613, 615);
            this._mealList.TabIndex = 2;
            // 
            // _mealButton0
            // 
            this._mealButton0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._mealButton0.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealButton0.ForeColor = System.Drawing.Color.White;
            this._mealButton0.Location = new System.Drawing.Point(3, 3);
            this._mealButton0.Name = "_mealButton0";
            this._mealButton0.Size = new System.Drawing.Size(198, 199);
            this._mealButton0.TabIndex = 0;
            this._mealButton0.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._mealButton0.UseVisualStyleBackColor = true;
            this._mealButton0.Click += new System.EventHandler(this.ClickMealButton);
            // 
            // _mealButton1
            // 
            this._mealButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._mealButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealButton1.ForeColor = System.Drawing.Color.White;
            this._mealButton1.Location = new System.Drawing.Point(207, 3);
            this._mealButton1.Name = "_mealButton1";
            this._mealButton1.Size = new System.Drawing.Size(198, 199);
            this._mealButton1.TabIndex = 1;
            this._mealButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._mealButton1.UseVisualStyleBackColor = true;
            this._mealButton1.Click += new System.EventHandler(this.ClickMealButton);
            // 
            // _mealButton2
            // 
            this._mealButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._mealButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealButton2.ForeColor = System.Drawing.Color.White;
            this._mealButton2.Location = new System.Drawing.Point(411, 3);
            this._mealButton2.Name = "_mealButton2";
            this._mealButton2.Size = new System.Drawing.Size(199, 199);
            this._mealButton2.TabIndex = 2;
            this._mealButton2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._mealButton2.UseVisualStyleBackColor = true;
            this._mealButton2.Click += new System.EventHandler(this.ClickMealButton);
            // 
            // _mealButton3
            // 
            this._mealButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._mealButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealButton3.ForeColor = System.Drawing.Color.White;
            this._mealButton3.Location = new System.Drawing.Point(3, 208);
            this._mealButton3.Name = "_mealButton3";
            this._mealButton3.Size = new System.Drawing.Size(198, 199);
            this._mealButton3.TabIndex = 3;
            this._mealButton3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._mealButton3.UseVisualStyleBackColor = true;
            this._mealButton3.Click += new System.EventHandler(this.ClickMealButton);
            // 
            // _mealButton4
            // 
            this._mealButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._mealButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealButton4.ForeColor = System.Drawing.Color.White;
            this._mealButton4.Location = new System.Drawing.Point(207, 208);
            this._mealButton4.Name = "_mealButton4";
            this._mealButton4.Size = new System.Drawing.Size(198, 199);
            this._mealButton4.TabIndex = 4;
            this._mealButton4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._mealButton4.UseVisualStyleBackColor = true;
            this._mealButton4.Click += new System.EventHandler(this.ClickMealButton);
            // 
            // _mealButton5
            // 
            this._mealButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._mealButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealButton5.ForeColor = System.Drawing.Color.White;
            this._mealButton5.Location = new System.Drawing.Point(411, 208);
            this._mealButton5.Name = "_mealButton5";
            this._mealButton5.Size = new System.Drawing.Size(199, 199);
            this._mealButton5.TabIndex = 5;
            this._mealButton5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._mealButton5.UseVisualStyleBackColor = true;
            this._mealButton5.Click += new System.EventHandler(this.ClickMealButton);
            // 
            // _mealButton6
            // 
            this._mealButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._mealButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealButton6.ForeColor = System.Drawing.Color.White;
            this._mealButton6.Location = new System.Drawing.Point(3, 413);
            this._mealButton6.Name = "_mealButton6";
            this._mealButton6.Size = new System.Drawing.Size(198, 199);
            this._mealButton6.TabIndex = 6;
            this._mealButton6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._mealButton6.UseVisualStyleBackColor = true;
            this._mealButton6.Click += new System.EventHandler(this.ClickMealButton);
            // 
            // _mealButton7
            // 
            this._mealButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._mealButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealButton7.ForeColor = System.Drawing.Color.White;
            this._mealButton7.Location = new System.Drawing.Point(207, 413);
            this._mealButton7.Name = "_mealButton7";
            this._mealButton7.Size = new System.Drawing.Size(198, 199);
            this._mealButton7.TabIndex = 7;
            this._mealButton7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._mealButton7.UseVisualStyleBackColor = true;
            this._mealButton7.Click += new System.EventHandler(this.ClickMealButton);
            // 
            // _mealButton8
            // 
            this._mealButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._mealButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealButton8.ForeColor = System.Drawing.Color.White;
            this._mealButton8.Location = new System.Drawing.Point(411, 413);
            this._mealButton8.Name = "_mealButton8";
            this._mealButton8.Size = new System.Drawing.Size(199, 199);
            this._mealButton8.TabIndex = 8;
            this._mealButton8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this._mealButton8.UseVisualStyleBackColor = true;
            this._mealButton8.Click += new System.EventHandler(this.ClickMealButton);
            // 
            // _deleteColumn
            // 
            this._deleteColumn.HeaderText = "Delete";
            this._deleteColumn.Name = "_deleteColumn";
            this._deleteColumn.Text = "X";
            this._deleteColumn.UseColumnTextForButtonValue = true;
            // 
            // _unitName
            // 
            this._unitName.HeaderText = "Name";
            this._unitName.Name = "_unitName";
            this._unitName.ReadOnly = true;
            // 
            // _category
            // 
            this._category.HeaderText = "Category";
            this._category.Name = "_category";
            this._category.ReadOnly = true;
            // 
            // _unitPrice
            // 
            this._unitPrice.HeaderText = "Unit Price";
            this._unitPrice.Name = "_unitPrice";
            this._unitPrice.ReadOnly = true;
            // 
            // _quantityValue
            // 
            this._quantityValue.HeaderText = "Qty";
            this._quantityValue.Name = "_quantityValue";
            this._quantityValue.ReadOnly = true;
            // 
            // _quantity
            // 
            this._quantity.DataPropertyName = "_quantity";
            this._quantity.HeaderText = string.Empty;
            this._quantity.Minimum = 1;
            this._quantity.Name = "_quantity";
            this._quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this._quantity.Width = 20;
            // 
            // _unitTotal
            // 
            this._unitTotal.HeaderText = "Subtotal";
            this._unitTotal.Name = "_unitTotal";
            this._unitTotal.ReadOnly = true;
            // 
            // POSCustomerSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 871);
            this.Controls.Add(this._customLayout1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "POSCustomerSideForm";
            this.Text = "POSCustomerSideForm";
            this._customLayout1.ResumeLayout(false);
            this._customLayout2.ResumeLayout(false);
            this._customLayout3.ResumeLayout(false);
            this._customLayout3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._record)).EndInit();
            this._mealGroupBox.ResumeLayout(false);
            this._customLayout4.ResumeLayout(false);
            this._customLayout5.ResumeLayout(false);
            this._customLayout5.PerformLayout();
            this._mealList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _customLayout1;
        private System.Windows.Forms.TableLayoutPanel _customLayout2;
        private System.Windows.Forms.TableLayoutPanel _customLayout3;
        private System.Windows.Forms.Label _total;
        private System.Windows.Forms.DataGridView _record;
        private System.Windows.Forms.TableLayoutPanel _customLayout4;
        private System.Windows.Forms.RichTextBox _detail;
        private System.Windows.Forms.TableLayoutPanel _customLayout5;
        private System.Windows.Forms.Label _page;
        private System.Windows.Forms.Button _previous;
        private System.Windows.Forms.Button _next;
        private System.Windows.Forms.Button _add;
        private System.Windows.Forms.TableLayoutPanel _mealList;
        private System.Windows.Forms.GroupBox _mealGroupBox;
        private System.Windows.Forms.Button _mealButton0;
        private System.Windows.Forms.Button _mealButton1;
        private System.Windows.Forms.Button _mealButton2;
        private System.Windows.Forms.Button _mealButton3;
        private System.Windows.Forms.Button _mealButton4;
        private System.Windows.Forms.Button _mealButton5;
        private System.Windows.Forms.Button _mealButton6;
        private System.Windows.Forms.Button _mealButton7;
        private System.Windows.Forms.Button _mealButton8;
        private System.Windows.Forms.TabControl _categoryTab;
        private DataGridViewButtonColumn _deleteColumn;
        private DataGridViewTextBoxColumn _unitName;
        private DataGridViewTextBoxColumn _category;
        private DataGridViewTextBoxColumn _unitPrice;
        private DataGridViewTextBoxColumn _quantityValue;
        private DataGridViewNumericUpDownColumn _quantity;
        private DataGridViewTextBoxColumn _unitTotal;
    }
}