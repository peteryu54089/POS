using POS.Models;
using POS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Views
{
    public partial class StartUpForm : Form
    {
        #region Attribute

        public StartUpFormPresentationModel StartUp
        {
            get;
            set;
        }

        #endregion

        public StartUpForm()
        {
            InitializeComponent();
            StartUp = new StartUpFormPresentationModel();
        }

        /// <summary>
        /// 刷新 control
        /// </summary>
        private void RefreshControls()
        {
            _front.Enabled = StartUp.IsFrontEnabled;
            _back.Enabled = StartUp.IsBackEnabled;
        }

        /// <summary>
        /// 點擊Frontend按鈕觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickFront(object sender, EventArgs e)
        {
            Form form = new POSCustomerSideForm(StartUp.Sale);
            form.FormClosed += new FormClosedEventHandler(CloseFront);
            form.Show();

            StartUp.ClickFront();
            RefreshControls();
        }

        /// <summary>
        /// 點擊Backend按鈕觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBack(object sender, EventArgs e)
        {
            Form form = new POSRestaurantSideForm(StartUp.Sale);
            form.FormClosed += new FormClosedEventHandler(CloseBack);
            form.Show();

            StartUp.ClickBack();
            RefreshControls();
        }

        /// <summary>
        /// 視窗關閉觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseFront(object sender, FormClosedEventArgs e)
        {
            StartUp.CloseFront();
            RefreshControls();
        }

        /// <summary>
        /// 視窗關閉觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBack(object sender, FormClosedEventArgs e)
        {
            StartUp.CloseBack();
            RefreshControls();
        }

        /// <summary>
        /// 點擊Exit按鈕觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
