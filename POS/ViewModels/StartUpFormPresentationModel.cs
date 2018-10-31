using POS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.ViewModels
{
    public class StartUpFormPresentationModel
    {
        #region Attribute

        public SaleModel Sale
        {
            get;
            set;
        }

        public bool IsFrontEnabled
        {
            get;
            set;
        }

        public bool IsBackEnabled
        {
            get;
            set;
        }

        #endregion

        public StartUpFormPresentationModel()
        {
            Sale = new SaleModel();
            IsFrontEnabled = true;
            IsBackEnabled = true;
        }

        /// <summary>
        /// 點擊Frontend按鈕觸發事件
        /// </summary>
        public void ClickFront()
        {
            IsFrontEnabled = false;
        }

        /// <summary>
        /// 點擊Backend按鈕觸發事件
        /// </summary>
        public void ClickBack()
        {
            IsBackEnabled = false;
        }

        /// <summary>
        /// 視窗關閉觸發事件
        /// </summary>
        public void CloseFront()
        {
            IsFrontEnabled = true;
        }

        /// <summary>
        /// 視窗關閉觸發事件
        /// </summary>
        public void CloseBack()
        {
            IsBackEnabled = true;
        }
    }
}
