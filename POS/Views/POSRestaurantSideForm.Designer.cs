using System.Windows.Forms;

namespace POS.Views
{
    partial class POSRestaurantSideForm
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
            this._restaurantTabControl = new System.Windows.Forms.TabControl();
            this._mealManager = new System.Windows.Forms.TabPage();
            this._customLayout1 = new System.Windows.Forms.TableLayoutPanel();
            this._customLayout2 = new System.Windows.Forms.TableLayoutPanel();
            this._mealListBox = new System.Windows.Forms.ListBox();
            this._customLayout3 = new System.Windows.Forms.TableLayoutPanel();
            this._addNewMeal = new System.Windows.Forms.Button();
            this._deleteSelectedMeal = new System.Windows.Forms.Button();
            this._editMeal = new System.Windows.Forms.GroupBox();
            this._customLayout4 = new System.Windows.Forms.TableLayoutPanel();
            this._customLayout5 = new System.Windows.Forms.TableLayoutPanel();
            this._mealNameLabel = new System.Windows.Forms.Label();
            this._mealName = new System.Windows.Forms.TextBox();
            this._customLayout6 = new System.Windows.Forms.TableLayoutPanel();
            this._mealPriceLabel = new System.Windows.Forms.Label();
            this._mealPrice = new System.Windows.Forms.TextBox();
            this._mealPriceUnit = new System.Windows.Forms.Label();
            this._mealCategoryLabel = new System.Windows.Forms.Label();
            this._mealCategory = new System.Windows.Forms.ComboBox();
            this._customLayout7 = new System.Windows.Forms.TableLayoutPanel();
            this._mealImageLabel = new System.Windows.Forms.Label();
            this._mealImage = new System.Windows.Forms.TextBox();
            this._browseButton = new System.Windows.Forms.Button();
            this._customLayout8 = new System.Windows.Forms.TableLayoutPanel();
            this._mealDescriptionLabel = new System.Windows.Forms.Label();
            this._customLayout9 = new System.Windows.Forms.TableLayoutPanel();
            this._saveMealButton = new System.Windows.Forms.Button();
            this._mealDescription = new System.Windows.Forms.TextBox();
            this._categoryManager = new System.Windows.Forms.TabPage();
            this._customLayout10 = new System.Windows.Forms.TableLayoutPanel();
            this._customLayout11 = new System.Windows.Forms.TableLayoutPanel();
            this._customLayout12 = new System.Windows.Forms.TableLayoutPanel();
            this._addCategory = new System.Windows.Forms.Button();
            this._deleteSelectedCategory = new System.Windows.Forms.Button();
            this._categoryListBox = new System.Windows.Forms.ListBox();
            this._editCategory = new System.Windows.Forms.GroupBox();
            this._customLayout13 = new System.Windows.Forms.TableLayoutPanel();
            this._customLayout14 = new System.Windows.Forms.TableLayoutPanel();
            this._categoryNameLabel = new System.Windows.Forms.Label();
            this._categoryName = new System.Windows.Forms.TextBox();
            this._customLayout15 = new System.Windows.Forms.TableLayoutPanel();
            this._mealsUsingThisCategoryLabel = new System.Windows.Forms.Label();
            this._customLayout16 = new System.Windows.Forms.TableLayoutPanel();
            this._saveCategoryButton = new System.Windows.Forms.Button();
            this._mealsUsingThisCategory = new System.Windows.Forms.ListBox();
            this._restaurantTabControl.SuspendLayout();
            this._mealManager.SuspendLayout();
            this._customLayout1.SuspendLayout();
            this._customLayout2.SuspendLayout();
            this._customLayout3.SuspendLayout();
            this._editMeal.SuspendLayout();
            this._customLayout4.SuspendLayout();
            this._customLayout5.SuspendLayout();
            this._customLayout6.SuspendLayout();
            this._customLayout7.SuspendLayout();
            this._customLayout8.SuspendLayout();
            this._customLayout9.SuspendLayout();
            this._categoryManager.SuspendLayout();
            this._customLayout10.SuspendLayout();
            this._customLayout11.SuspendLayout();
            this._customLayout12.SuspendLayout();
            this._editCategory.SuspendLayout();
            this._customLayout13.SuspendLayout();
            this._customLayout14.SuspendLayout();
            this._customLayout15.SuspendLayout();
            this._customLayout16.SuspendLayout();
            this.SuspendLayout();
            // 
            // _restaurantTabControl
            // 
            this._restaurantTabControl.Controls.Add(this._mealManager);
            this._restaurantTabControl.Controls.Add(this._categoryManager);
            this._restaurantTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._restaurantTabControl.Location = new System.Drawing.Point(0, 0);
            this._restaurantTabControl.Name = "_restaurantTabControl";
            this._restaurantTabControl.SelectedIndex = 0;
            this._restaurantTabControl.Size = new System.Drawing.Size(1306, 871);
            this._restaurantTabControl.TabIndex = 0;
            this._restaurantTabControl.SelectedIndexChanged += new System.EventHandler(this.SelectTab);
            // 
            // _mealManager
            // 
            this._mealManager.Controls.Add(this._customLayout1);
            this._mealManager.Location = new System.Drawing.Point(8, 39);
            this._mealManager.Name = "_mealManager";
            this._mealManager.Padding = new System.Windows.Forms.Padding(3);
            this._mealManager.Size = new System.Drawing.Size(1290, 824);
            this._mealManager.TabIndex = 0;
            this._mealManager.Text = "Meal Manager";
            this._mealManager.UseVisualStyleBackColor = true;
            // 
            // _customLayout1
            // 
            this._customLayout1.ColumnCount = 2;
            this._customLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._customLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this._customLayout1.Controls.Add(this._customLayout2, 0, 0);
            this._customLayout1.Controls.Add(this._editMeal, 1, 0);
            this._customLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout1.Location = new System.Drawing.Point(3, 3);
            this._customLayout1.Name = "_customLayout1";
            this._customLayout1.RowCount = 1;
            this._customLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout1.Size = new System.Drawing.Size(1284, 818);
            this._customLayout1.TabIndex = 0;
            // 
            // _customLayout2
            // 
            this._customLayout2.ColumnCount = 1;
            this._customLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout2.Controls.Add(this._mealListBox, 0, 0);
            this._customLayout2.Controls.Add(this._customLayout3, 0, 1);
            this._customLayout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout2.Location = new System.Drawing.Point(3, 3);
            this._customLayout2.Name = "_customLayout2";
            this._customLayout2.RowCount = 2;
            this._customLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this._customLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._customLayout2.Size = new System.Drawing.Size(507, 812);
            this._customLayout2.TabIndex = 0;
            // 
            // _mealListBox
            // 
            this._mealListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealListBox.FormattingEnabled = true;
            this._mealListBox.ItemHeight = 24;
            this._mealListBox.Location = new System.Drawing.Point(3, 3);
            this._mealListBox.Name = "_mealListBox";
            this._mealListBox.Size = new System.Drawing.Size(501, 765);
            this._mealListBox.TabIndex = 0;
            this._mealListBox.SelectedIndexChanged += new System.EventHandler(this.SelectMealListBoxItem);
            // 
            // _customLayout3
            // 
            this._customLayout3.ColumnCount = 2;
            this._customLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._customLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._customLayout3.Controls.Add(this._addNewMeal, 0, 0);
            this._customLayout3.Controls.Add(this._deleteSelectedMeal, 1, 0);
            this._customLayout3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout3.Location = new System.Drawing.Point(3, 774);
            this._customLayout3.Name = "_customLayout3";
            this._customLayout3.RowCount = 1;
            this._customLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._customLayout3.Size = new System.Drawing.Size(501, 35);
            this._customLayout3.TabIndex = 1;
            // 
            // _addNewMeal
            // 
            this._addNewMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addNewMeal.Location = new System.Drawing.Point(3, 3);
            this._addNewMeal.Name = "_addNewMeal";
            this._addNewMeal.Size = new System.Drawing.Size(244, 29);
            this._addNewMeal.TabIndex = 0;
            this._addNewMeal.Text = "Add New Meal";
            this._addNewMeal.UseVisualStyleBackColor = true;
            this._addNewMeal.Click += new System.EventHandler(this.ClickAddNewMeal);
            // 
            // _deleteSelectedMeal
            // 
            this._deleteSelectedMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._deleteSelectedMeal.Enabled = false;
            this._deleteSelectedMeal.Location = new System.Drawing.Point(253, 3);
            this._deleteSelectedMeal.Name = "_deleteSelectedMeal";
            this._deleteSelectedMeal.Size = new System.Drawing.Size(245, 29);
            this._deleteSelectedMeal.TabIndex = 1;
            this._deleteSelectedMeal.Text = "Delete Selected Meal";
            this._deleteSelectedMeal.UseVisualStyleBackColor = true;
            this._deleteSelectedMeal.Click += new System.EventHandler(this.ClickDeleteSelectedMeal);
            // 
            // _editMeal
            // 
            this._editMeal.Controls.Add(this._customLayout4);
            this._editMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editMeal.Location = new System.Drawing.Point(516, 3);
            this._editMeal.Name = "_editMeal";
            this._editMeal.Size = new System.Drawing.Size(765, 812);
            this._editMeal.TabIndex = 1;
            this._editMeal.TabStop = false;
            this._editMeal.Text = "Edit Meal";
            this._editMeal.Enabled = false;
            // 
            // _customLayout4
            // 
            this._customLayout4.ColumnCount = 1;
            this._customLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._customLayout4.Controls.Add(this._customLayout5, 0, 0);
            this._customLayout4.Controls.Add(this._customLayout6, 0, 1);
            this._customLayout4.Controls.Add(this._customLayout7, 0, 2);
            this._customLayout4.Controls.Add(this._customLayout8, 0, 3);
            this._customLayout4.Controls.Add(this._customLayout9, 0, 5);
            this._customLayout4.Controls.Add(this._mealDescription, 0, 4);
            this._customLayout4.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout4.Location = new System.Drawing.Point(3, 32);
            this._customLayout4.Name = "_customLayout4";
            this._customLayout4.RowCount = 6;
            this._customLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._customLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._customLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._customLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this._customLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this._customLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this._customLayout4.Size = new System.Drawing.Size(759, 777);
            this._customLayout4.TabIndex = 0;
            // 
            // _customLayout5
            // 
            this._customLayout5.ColumnCount = 2;
            this._customLayout5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._customLayout5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this._customLayout5.Controls.Add(this._mealNameLabel, 0, 0);
            this._customLayout5.Controls.Add(this._mealName, 1, 0);
            this._customLayout5.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout5.Location = new System.Drawing.Point(3, 3);
            this._customLayout5.Name = "_customLayout5";
            this._customLayout5.RowCount = 1;
            this._customLayout5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout5.Size = new System.Drawing.Size(753, 123);
            this._customLayout5.TabIndex = 0;
            // 
            // _mealNameLabel
            // 
            this._mealNameLabel.AutoSize = true;
            this._mealNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealNameLabel.Location = new System.Drawing.Point(3, 0);
            this._mealNameLabel.Name = "_mealNameLabel";
            this._mealNameLabel.Size = new System.Drawing.Size(106, 123);
            this._mealNameLabel.TabIndex = 0;
            this._mealNameLabel.Text = "Meal Name (*)";
            this._mealNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _mealName
            // 
            this._mealName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._mealName.Location = new System.Drawing.Point(115, 43);
            this._mealName.Name = "_mealName";
            this._mealName.Size = new System.Drawing.Size(635, 36);
            this._mealName.TabIndex = 1;
            this._mealName.GotFocus += new System.EventHandler(this.EnableSaveMealButton);
            this._mealName.TextChanged += new System.EventHandler(this.DisableSaveMealButton);
            this._mealName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnableSaveMealButton);
            // 
            // _customLayout6
            // 
            this._customLayout6.ColumnCount = 5;
            this._customLayout6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._customLayout6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._customLayout6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._customLayout6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._customLayout6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._customLayout6.Controls.Add(this._mealPriceLabel, 0, 0);
            this._customLayout6.Controls.Add(this._mealPrice, 1, 0);
            this._customLayout6.Controls.Add(this._mealPriceUnit, 2, 0);
            this._customLayout6.Controls.Add(this._mealCategoryLabel, 3, 0);
            this._customLayout6.Controls.Add(this._mealCategory, 4, 0);
            this._customLayout6.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout6.Location = new System.Drawing.Point(3, 132);
            this._customLayout6.Name = "_customLayout6";
            this._customLayout6.RowCount = 1;
            this._customLayout6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout6.Size = new System.Drawing.Size(753, 123);
            this._customLayout6.TabIndex = 1;
            // 
            // _mealPriceLabel
            // 
            this._mealPriceLabel.AutoSize = true;
            this._mealPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealPriceLabel.Location = new System.Drawing.Point(3, 0);
            this._mealPriceLabel.Name = "_mealPriceLabel";
            this._mealPriceLabel.Size = new System.Drawing.Size(106, 123);
            this._mealPriceLabel.TabIndex = 0;
            this._mealPriceLabel.Text = "Meal Price (*)";
            this._mealPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _mealPrice
            // 
            this._mealPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._mealPrice.Location = new System.Drawing.Point(115, 43);
            this._mealPrice.Name = "_mealPrice";
            this._mealPrice.Size = new System.Drawing.Size(182, 36);
            this._mealPrice.TabIndex = 1;
            this._mealPrice.GotFocus += new System.EventHandler(this.EnableSaveMealButton);
            this._mealPrice.TextChanged += new System.EventHandler(this.DisableSaveMealButton);
            this._mealPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnableSaveMealButton);
            this._mealPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputNumberOnly);
            // 
            // _mealPriceUnit
            // 
            this._mealPriceUnit.AutoSize = true;
            this._mealPriceUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealPriceUnit.Location = new System.Drawing.Point(303, 0);
            this._mealPriceUnit.Name = "_mealPriceUnit";
            this._mealPriceUnit.Size = new System.Drawing.Size(69, 123);
            this._mealPriceUnit.TabIndex = 2;
            this._mealPriceUnit.Text = "NTD";
            this._mealPriceUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _mealCategoryLabel
            // 
            this._mealCategoryLabel.AutoSize = true;
            this._mealCategoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealCategoryLabel.Location = new System.Drawing.Point(378, 0);
            this._mealCategoryLabel.Name = "_mealCategoryLabel";
            this._mealCategoryLabel.Size = new System.Drawing.Size(144, 123);
            this._mealCategoryLabel.TabIndex = 3;
            this._mealCategoryLabel.Text = "Meal Category (*)";
            this._mealCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _mealCategory
            // 
            this._mealCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._mealCategory.FormattingEnabled = true;
            this._mealCategory.Location = new System.Drawing.Point(528, 45);
            this._mealCategory.Name = "_mealCategory";
            this._mealCategory.Size = new System.Drawing.Size(222, 32);
            this._mealCategory.TabIndex = 4;
            this._mealCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this._mealCategory.SelectedIndexChanged += new System.EventHandler(this.EnableSaveMealButton);
            // 
            // _customLayout7
            // 
            this._customLayout7.ColumnCount = 3;
            this._customLayout7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._customLayout7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this._customLayout7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._customLayout7.Controls.Add(this._mealImageLabel, 0, 0);
            this._customLayout7.Controls.Add(this._mealImage, 1, 0);
            this._customLayout7.Controls.Add(this._browseButton, 2, 0);
            this._customLayout7.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout7.Location = new System.Drawing.Point(3, 261);
            this._customLayout7.Name = "_customLayout7";
            this._customLayout7.RowCount = 1;
            this._customLayout7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout7.Size = new System.Drawing.Size(753, 123);
            this._customLayout7.TabIndex = 2;
            // 
            // _mealImageLabel
            // 
            this._mealImageLabel.AutoSize = true;
            this._mealImageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealImageLabel.Location = new System.Drawing.Point(3, 0);
            this._mealImageLabel.Name = "_mealImageLabel";
            this._mealImageLabel.Size = new System.Drawing.Size(182, 123);
            this._mealImageLabel.TabIndex = 0;
            this._mealImageLabel.Text = "Meal Image Relative Path (*)";
            this._mealImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _mealImage
            // 
            this._mealImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._mealImage.Location = new System.Drawing.Point(191, 43);
            this._mealImage.Name = "_mealImage";
            this._mealImage.Size = new System.Drawing.Size(445, 36);
            this._mealImage.TabIndex = 1;
            this._mealImage.GotFocus += new System.EventHandler(this.EnableSaveMealButton);
            this._mealImage.TextChanged += new System.EventHandler(this.DisableSaveMealButton);
            this._mealImage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnableSaveMealButton);
            // 
            // _browseButton
            // 
            this._browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._browseButton.Location = new System.Drawing.Point(642, 39);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(108, 45);
            this._browseButton.TabIndex = 2;
            this._browseButton.Text = "Browse...";
            this._browseButton.UseVisualStyleBackColor = true;
            this._browseButton.Click += new System.EventHandler(this.ClickBrowseButton);
            // 
            // _customLayout8
            // 
            this._customLayout8.ColumnCount = 2;
            this._customLayout8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._customLayout8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._customLayout8.Controls.Add(this._mealDescriptionLabel, 0, 0);
            this._customLayout8.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout8.Location = new System.Drawing.Point(3, 390);
            this._customLayout8.Name = "_customLayout8";
            this._customLayout8.RowCount = 1;
            this._customLayout8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this._customLayout8.Size = new System.Drawing.Size(753, 37);
            this._customLayout8.TabIndex = 3;
            // 
            // _mealDescriptionLabel
            // 
            this._mealDescriptionLabel.AutoSize = true;
            this._mealDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealDescriptionLabel.Location = new System.Drawing.Point(3, 0);
            this._mealDescriptionLabel.Name = "_mealDescriptionLabel";
            this._mealDescriptionLabel.Size = new System.Drawing.Size(219, 37);
            this._mealDescriptionLabel.TabIndex = 0;
            this._mealDescriptionLabel.Text = "Meal Description";
            this._mealDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _customLayout9
            // 
            this._customLayout9.ColumnCount = 2;
            this._customLayout9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this._customLayout9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._customLayout9.Controls.Add(this._saveMealButton, 1, 0);
            this._customLayout9.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout9.Location = new System.Drawing.Point(3, 735);
            this._customLayout9.Name = "_customLayout9";
            this._customLayout9.RowCount = 1;
            this._customLayout9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this._customLayout9.Size = new System.Drawing.Size(753, 39);
            this._customLayout9.TabIndex = 4;
            // 
            // _saveMealButton
            // 
            this._saveMealButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._saveMealButton.Location = new System.Drawing.Point(605, 3);
            this._saveMealButton.Name = "_saveMealButton";
            this._saveMealButton.Size = new System.Drawing.Size(145, 33);
            this._saveMealButton.TabIndex = 0;
            this._saveMealButton.Text = "Save";
            this._saveMealButton.UseVisualStyleBackColor = true;
            this._saveMealButton.Click += new System.EventHandler(this.SaveMealButton);
            // 
            // _mealDescription
            // 
            this._mealDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealDescription.Location = new System.Drawing.Point(3, 433);
            this._mealDescription.Multiline = true;
            this._mealDescription.Name = "_mealDescription";
            this._mealDescription.Size = new System.Drawing.Size(753, 296);
            this._mealDescription.TabIndex = 5;
            this._mealDescription.GotFocus += new System.EventHandler(this.EnableSaveMealButton);
            this._mealDescription.TextChanged += new System.EventHandler(this.DisableSaveMealButton);
            this._mealDescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnableSaveMealButton);
            // 
            // _categoryManager
            // 
            this._categoryManager.Controls.Add(this._customLayout10);
            this._categoryManager.Location = new System.Drawing.Point(8, 39);
            this._categoryManager.Name = "_categoryManager";
            this._categoryManager.Padding = new System.Windows.Forms.Padding(3);
            this._categoryManager.Size = new System.Drawing.Size(1290, 824);
            this._categoryManager.TabIndex = 1;
            this._categoryManager.Text = "Category Manager";
            this._categoryManager.UseVisualStyleBackColor = true;
            // 
            // _customLayout10
            // 
            this._customLayout10.ColumnCount = 2;
            this._customLayout10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._customLayout10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this._customLayout10.Controls.Add(this._customLayout11, 0, 0);
            this._customLayout10.Controls.Add(this._editCategory, 1, 0);
            this._customLayout10.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout10.Location = new System.Drawing.Point(3, 3);
            this._customLayout10.Name = "_customLayout10";
            this._customLayout10.RowCount = 1;
            this._customLayout10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout10.Size = new System.Drawing.Size(1284, 818);
            this._customLayout10.TabIndex = 0;
            // 
            // _customLayout11
            // 
            this._customLayout11.ColumnCount = 1;
            this._customLayout11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout11.Controls.Add(this._customLayout12, 0, 1);
            this._customLayout11.Controls.Add(this._categoryListBox, 0, 0);
            this._customLayout11.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout11.Location = new System.Drawing.Point(3, 3);
            this._customLayout11.Name = "_customLayout11";
            this._customLayout11.RowCount = 2;
            this._customLayout11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this._customLayout11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._customLayout11.Size = new System.Drawing.Size(507, 812);
            this._customLayout11.TabIndex = 0;
            // 
            // _customLayout12
            // 
            this._customLayout12.ColumnCount = 2;
            this._customLayout12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._customLayout12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._customLayout12.Controls.Add(this._addCategory, 0, 0);
            this._customLayout12.Controls.Add(this._deleteSelectedCategory, 1, 0);
            this._customLayout12.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout12.Location = new System.Drawing.Point(3, 774);
            this._customLayout12.Name = "_customLayout12";
            this._customLayout12.RowCount = 1;
            this._customLayout12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._customLayout12.Size = new System.Drawing.Size(501, 35);
            this._customLayout12.TabIndex = 0;
            // 
            // _addCategory
            // 
            this._addCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addCategory.Location = new System.Drawing.Point(3, 3);
            this._addCategory.Name = "_addCategory";
            this._addCategory.Size = new System.Drawing.Size(244, 29);
            this._addCategory.TabIndex = 0;
            this._addCategory.Text = "Add Category";
            this._addCategory.UseVisualStyleBackColor = true;
            this._addCategory.Click += new System.EventHandler(this.ClickAddNewCategory);
            // 
            // _deleteSelectedCategory
            // 
            this._deleteSelectedCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._deleteSelectedCategory.Enabled = false;
            this._deleteSelectedCategory.Location = new System.Drawing.Point(253, 3);
            this._deleteSelectedCategory.Name = "_deleteSelectedCategory";
            this._deleteSelectedCategory.Size = new System.Drawing.Size(245, 29);
            this._deleteSelectedCategory.TabIndex = 1;
            this._deleteSelectedCategory.Text = "Delete Selected Category";
            this._deleteSelectedCategory.UseVisualStyleBackColor = true;
            this._deleteSelectedCategory.Click += new System.EventHandler(this.ClickDeleteSelectedCategory);
            // 
            // _categoryListBox
            // 
            this._categoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._categoryListBox.FormattingEnabled = true;
            this._categoryListBox.ItemHeight = 24;
            this._categoryListBox.Location = new System.Drawing.Point(3, 3);
            this._categoryListBox.Name = "_categoryListBox";
            this._categoryListBox.Size = new System.Drawing.Size(501, 765);
            this._categoryListBox.TabIndex = 1;
            this._categoryListBox.SelectedIndexChanged += new System.EventHandler(this.SelectCategoryListBoxItem);
            // 
            // _editCategory
            // 
            this._editCategory.Controls.Add(this._customLayout13);
            this._editCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editCategory.Location = new System.Drawing.Point(516, 3);
            this._editCategory.Name = "_editCategory";
            this._editCategory.Size = new System.Drawing.Size(765, 812);
            this._editCategory.TabIndex = 1;
            this._editCategory.TabStop = false;
            this._editCategory.Text = "Edit Category";
            this._editCategory.Enabled = false;
            // 
            // _customLayout13
            // 
            this._customLayout13.ColumnCount = 1;
            this._customLayout13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout13.Controls.Add(this._customLayout14, 0, 0);
            this._customLayout13.Controls.Add(this._customLayout15, 0, 1);
            this._customLayout13.Controls.Add(this._customLayout16, 0, 3);
            this._customLayout13.Controls.Add(this._mealsUsingThisCategory, 0, 2);
            this._customLayout13.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout13.Location = new System.Drawing.Point(3, 32);
            this._customLayout13.Name = "_customLayout13";
            this._customLayout13.RowCount = 4;
            this._customLayout13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._customLayout13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._customLayout13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this._customLayout13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this._customLayout13.Size = new System.Drawing.Size(759, 777);
            this._customLayout13.TabIndex = 0;
            // 
            // _customLayout14
            // 
            this._customLayout14.ColumnCount = 2;
            this._customLayout14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._customLayout14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this._customLayout14.Controls.Add(this._categoryNameLabel, 0, 0);
            this._customLayout14.Controls.Add(this._categoryName, 1, 0);
            this._customLayout14.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout14.Location = new System.Drawing.Point(3, 3);
            this._customLayout14.Name = "_customLayout14";
            this._customLayout14.RowCount = 1;
            this._customLayout14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout14.Size = new System.Drawing.Size(753, 71);
            this._customLayout14.TabIndex = 0;
            // 
            // _categoryNameLabel
            // 
            this._categoryNameLabel.AutoSize = true;
            this._categoryNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._categoryNameLabel.Location = new System.Drawing.Point(3, 0);
            this._categoryNameLabel.Name = "_categoryNameLabel";
            this._categoryNameLabel.Size = new System.Drawing.Size(106, 71);
            this._categoryNameLabel.TabIndex = 0;
            this._categoryNameLabel.Text = "Category Name (*)";
            this._categoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _categoryName
            // 
            this._categoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._categoryName.Location = new System.Drawing.Point(115, 17);
            this._categoryName.Name = "_categoryName";
            this._categoryName.Size = new System.Drawing.Size(635, 36);
            this._categoryName.TabIndex = 1;
            this._categoryName.GotFocus += new System.EventHandler(this.EnableSaveCategoryButton);
            this._categoryName.TextChanged += new System.EventHandler(this.DisableSaveCategoryButton);
            this._categoryName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnableSaveCategoryButton);
            // 
            // _customLayout15
            // 
            this._customLayout15.ColumnCount = 2;
            this._customLayout15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._customLayout15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this._customLayout15.Controls.Add(this._mealsUsingThisCategoryLabel, 0, 0);
            this._customLayout15.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout15.Location = new System.Drawing.Point(3, 80);
            this._customLayout15.Name = "_customLayout15";
            this._customLayout15.RowCount = 1;
            this._customLayout15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this._customLayout15.Size = new System.Drawing.Size(753, 32);
            this._customLayout15.TabIndex = 1;
            // 
            // _mealsUsingThisCategoryLabel
            // 
            this._mealsUsingThisCategoryLabel.AutoSize = true;
            this._mealsUsingThisCategoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealsUsingThisCategoryLabel.Location = new System.Drawing.Point(3, 0);
            this._mealsUsingThisCategoryLabel.Name = "_mealsUsingThisCategoryLabel";
            this._mealsUsingThisCategoryLabel.Size = new System.Drawing.Size(295, 32);
            this._mealsUsingThisCategoryLabel.TabIndex = 0;
            this._mealsUsingThisCategoryLabel.Text = "Meal(s) Using This Category:";
            // 
            // _customLayout16
            // 
            this._customLayout16.ColumnCount = 2;
            this._customLayout16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this._customLayout16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._customLayout16.Controls.Add(this._saveCategoryButton, 1, 0);
            this._customLayout16.Dock = System.Windows.Forms.DockStyle.Fill;
            this._customLayout16.Location = new System.Drawing.Point(3, 739);
            this._customLayout16.Name = "_customLayout16";
            this._customLayout16.RowCount = 1;
            this._customLayout16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._customLayout16.Size = new System.Drawing.Size(753, 35);
            this._customLayout16.TabIndex = 2;
            // 
            // _saveCategoryButton
            // 
            this._saveCategoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._saveCategoryButton.Location = new System.Drawing.Point(605, 3);
            this._saveCategoryButton.Name = "_saveCategoryButton";
            this._saveCategoryButton.Size = new System.Drawing.Size(145, 29);
            this._saveCategoryButton.TabIndex = 0;
            this._saveCategoryButton.Text = "Save";
            this._saveCategoryButton.UseVisualStyleBackColor = true;
            this._saveCategoryButton.Click += new System.EventHandler(this.SaveCategoryButton);
            // 
            // _mealsUsingThisCategory
            // 
            this._mealsUsingThisCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealsUsingThisCategory.FormattingEnabled = true;
            this._mealsUsingThisCategory.ItemHeight = 24;
            this._mealsUsingThisCategory.Location = new System.Drawing.Point(3, 118);
            this._mealsUsingThisCategory.Name = "_mealsUsingThisCategory";
            this._mealsUsingThisCategory.Size = new System.Drawing.Size(753, 615);
            this._mealsUsingThisCategory.TabIndex = 3;
            // 
            // POSRestaurantSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 871);
            this.Controls.Add(this._restaurantTabControl);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "POSRestaurantSideForm";
            this.Text = "POSRestaurantSideForm";
            this._restaurantTabControl.ResumeLayout(false);
            this._mealManager.ResumeLayout(false);
            this._customLayout1.ResumeLayout(false);
            this._customLayout2.ResumeLayout(false);
            this._customLayout3.ResumeLayout(false);
            this._editMeal.ResumeLayout(false);
            this._customLayout4.ResumeLayout(false);
            this._customLayout4.PerformLayout();
            this._customLayout5.ResumeLayout(false);
            this._customLayout5.PerformLayout();
            this._customLayout6.ResumeLayout(false);
            this._customLayout6.PerformLayout();
            this._customLayout7.ResumeLayout(false);
            this._customLayout7.PerformLayout();
            this._customLayout8.ResumeLayout(false);
            this._customLayout8.PerformLayout();
            this._customLayout9.ResumeLayout(false);
            this._categoryManager.ResumeLayout(false);
            this._customLayout10.ResumeLayout(false);
            this._customLayout11.ResumeLayout(false);
            this._customLayout12.ResumeLayout(false);
            this._editCategory.ResumeLayout(false);
            this._customLayout13.ResumeLayout(false);
            this._customLayout14.ResumeLayout(false);
            this._customLayout14.PerformLayout();
            this._customLayout15.ResumeLayout(false);
            this._customLayout15.PerformLayout();
            this._customLayout16.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _restaurantTabControl;
        private System.Windows.Forms.TabPage _mealManager;
        private System.Windows.Forms.TableLayoutPanel _customLayout1;
        private System.Windows.Forms.TableLayoutPanel _customLayout2;
        private System.Windows.Forms.ListBox _mealListBox;
        private System.Windows.Forms.TableLayoutPanel _customLayout3;
        private System.Windows.Forms.Button _addNewMeal;
        private System.Windows.Forms.Button _deleteSelectedMeal;
        private System.Windows.Forms.GroupBox _editMeal;
        private System.Windows.Forms.TableLayoutPanel _customLayout4;
        private System.Windows.Forms.TableLayoutPanel _customLayout5;
        private System.Windows.Forms.Label _mealNameLabel;
        private System.Windows.Forms.TextBox _mealName;
        private System.Windows.Forms.TableLayoutPanel _customLayout6;
        private System.Windows.Forms.Label _mealPriceLabel;
        private System.Windows.Forms.TableLayoutPanel _customLayout7;
        private System.Windows.Forms.TableLayoutPanel _customLayout8;
        private System.Windows.Forms.TableLayoutPanel _customLayout9;
        private System.Windows.Forms.TabPage _categoryManager;
        private System.Windows.Forms.TextBox _mealPrice;
        private System.Windows.Forms.Label _mealPriceUnit;
        private System.Windows.Forms.Label _mealCategoryLabel;
        private System.Windows.Forms.ComboBox _mealCategory;
        private System.Windows.Forms.Label _mealImageLabel;
        private System.Windows.Forms.TextBox _mealImage;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.Label _mealDescriptionLabel;
        private System.Windows.Forms.TextBox _mealDescription;
        private System.Windows.Forms.Button _saveMealButton;
        private System.Windows.Forms.TableLayoutPanel _customLayout10;
        private System.Windows.Forms.TableLayoutPanel _customLayout11;
        private System.Windows.Forms.TableLayoutPanel _customLayout12;
        private System.Windows.Forms.GroupBox _editCategory;
        private System.Windows.Forms.TableLayoutPanel _customLayout13;
        private System.Windows.Forms.TableLayoutPanel _customLayout14;
        private System.Windows.Forms.TableLayoutPanel _customLayout15;
        private System.Windows.Forms.TableLayoutPanel _customLayout16;
        private System.Windows.Forms.Button _addCategory;
        private System.Windows.Forms.ListBox _categoryListBox;
        private System.Windows.Forms.Button _deleteSelectedCategory;
        private System.Windows.Forms.Label _categoryNameLabel;
        private System.Windows.Forms.TextBox _categoryName;
        private System.Windows.Forms.Label _mealsUsingThisCategoryLabel;
        private System.Windows.Forms.Button _saveCategoryButton;
        private System.Windows.Forms.ListBox _mealsUsingThisCategory;
    }
}