using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITest.Input;

namespace POSUITests
{
    public class Robot
    {
        private static Dictionary<string, UITestControl> _cache;
        private static ApplicationUnderTest _aut;
        private static UITestControl _root;
        private const string CONTROL_NOT_FOUND_EXCEPTION = "The specific control is not found!!";
        private const string MSAA_TECHNOLOGY = "MSAA";

        public static void SetDelayBetweenActions(int millisecond)
        {
            Playback.PlaybackSettings.DelayBetweenActions = millisecond;
        }

        public static UITestControl Initialize(string path, string title)
        {
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Playback.PlaybackSettings.ThinkTimeMultiplier = 0.0d;
            Playback.PlaybackSettings.SkipSetPropertyVerification = true;
            Playback.PlaybackSettings.ShouldSearchFailFast = true;
            _aut = ApplicationUnderTest.Launch(path);

            _cache = new Dictionary<string, UITestControl>();
            WinWindow window = new WinWindow();
            window.SearchProperties.Add(WinWindow.PropertyNames.Name, title);
            CacheComponentFound(window, title);
            _root = window;
            return _root;
        }

        public static void CleanUp()
        {
            _cache.Clear();
            _root = null;
            _aut.Close();
        }

        public static UITestControl SetForm(string formName)
        {
            WinWindow window = (WinWindow)Robot.FindWinControl(typeof(WinWindow), formName, null);
            window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
            window.WindowTitles.Add(formName);
            _root = window;
            return _root;
        }

        private static WinControl FindWinControl(Type type, string name, UITestControl parent)
        {
            if (_cache.ContainsKey(name))
            {
                return (WinControl)_cache[name];
            }
            else
            {
                WinControl control = (WinControl)Activator.CreateInstance(type, new Object[] { parent });
                control.SearchProperties.Add(WinControl.PropertyNames.Name, name);
                CacheComponentFound(control, name);
                return control;
            }
        }

        private static void CacheComponentFound(UITestControl control, string name)
        {
            control.Find();
            if (!control.Exists)
            {
                throw new Exception(CONTROL_NOT_FOUND_EXCEPTION);
            }
            _cache.Add(name, control);
        }

        public static void ClickMenuItem(string[] path)
        {
            foreach (string item in path)
            {
                Mouse.Click((WinMenuItem)Robot.FindWinControl(typeof(WinMenuItem), item, _root));
            }
        }

        public static void ClickDateTimePicker(string[] data)
        {
            WinDateTimePicker dateTimePicker = (WinDateTimePicker)Robot.FindWinControl(typeof(WinDateTimePicker), data[0], _root);
            dateTimePicker.SetProperty("DateTime", data[1] + "/" + data[2] + "/" + data[3]);
        }

        public static void ClickButton(string name)
        {
            WinButton button = (WinButton)Robot.FindWinControl(typeof(WinButton), name, _root);
            Mouse.Click(button);
        }

        public static void ClickTabControl(string name)
        {
            Mouse.Click((WinTabPage)Robot.FindWinControl(typeof(WinTabPage), name, _root));
        }

        public static void SetEdit(string name, string keys)
        {
            WinEdit edit = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            if (edit.Text != keys)
                edit.Text = keys;
        }

        public static void SetNewMeal()
        {
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{1}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{1}");
        }

        public static void SetImagePath()
        {
            Keyboard.SendKeys("{A}");
            Keyboard.SendKeys("{s}");
            Keyboard.SendKeys("{s}");
            Keyboard.SendKeys("{e}");
            Keyboard.SendKeys("{t}");
            Keyboard.SendKeys("{s}");
            Keyboard.SendKeys("{Enter}");
            Keyboard.SendKeys("{r}");
            Keyboard.SendKeys("{i}");
            Keyboard.SendKeys("{c}");
            Keyboard.SendKeys("{e}");
            Keyboard.SendKeys("{Enter}");
            Keyboard.SendKeys("{1}");
            Keyboard.SendKeys("{Enter}");
        }

        public static void ClickTabs()
        {
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Enter}");
        }

        public static void AddNewCategory()
        {
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{1}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Enter}");
        }

        public static void UpdateCategoryName()
        {
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{2}");
            Keyboard.SendKeys("{Tab}");
            Keyboard.SendKeys("{Enter}");
        }

        public static void AssertOtherFormEdit(string formName, string editName, string assertValue)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
            window.WindowTitles.Add(formName);
            WinEdit edit = new WinEdit(window);
            edit.SearchProperties[WinWindow.PropertyNames.Name] = editName;
            Assert.AreEqual(edit.Text, assertValue);
        }

        public static void SetOtherFormEdit(string formName, string editName, string keys)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
            window.WindowTitles.Add(formName);
            WinEdit edit = new WinEdit(window);
            edit.SearchProperties[WinWindow.PropertyNames.Name] = editName;
            if (edit.Text != keys)
                edit.Text = keys;
        }

        public static void ClickOtherFormButton(string formName, string buttonName)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
            window.WindowTitles.Add(formName);
            WinButton button = new WinButton(window);
            button.SearchProperties[WinWindow.PropertyNames.Name] = buttonName;
            Mouse.Click(button);
        }

        public static void CloseWindow(string name)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = name;
            window.WindowTitles.Add(name);
            Keyboard.SendKeys(window, "{F4}", System.Windows.Input.ModifierKeys.Alt, false);
        }

        public static void AssertOtherFormButtonEnable(string formName, string buttonName, bool assertValue)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
            window.WindowTitles.Add(formName);
            WinButton button = new WinButton(window);
            button.SearchProperties[WinWindow.PropertyNames.Name] = buttonName;
            Assert.AreEqual(button.Enabled, assertValue);
        }

        public static void DeleteDataGridViewByIndex(string[] data)
        {
            WinTable table = (WinTable)Robot.FindWinControlByType(typeof(WinTable), data[0], _root);
            WinRow row = new WinRow(table);
            if (data[3] == string.Empty)
            {
                Mouse.Click(table, System.Windows.Forms.MouseButtons.Right);
            }
            else
            {
                row.SearchProperties.Add(WinRow.PropertyNames.RowIndex, data[3]);
                row.Find();
                UITestControlCollection collection = row.GetChildren();
                Mouse.Click(collection[0]);
            }
            WinWindow window = new WinWindow();
            WinMenu menu = new WinMenu(window);
            menu.SearchProperties[WinMenu.PropertyNames.Name] = data[1];
            WinMenuItem item = new WinMenuItem(menu);
            item.SearchProperties[WinMenuItem.PropertyNames.Name] = data[2];
        }

        public static void ClickListViewByValue(string name, string data)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = name;
            WinList list = new WinList(window);
            list.WindowTitles.Add("Task Type");
            if (data == string.Empty)
            {
                Mouse.Click(list);
            }
            else
            {
                list.SelectedItemsAsString = data;
            }
        }

        public static void ClickListViewToEmpty(string name, string data)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = name;
            window.WindowTitles.Add("Task Type");
            WinList list = new WinList(window);
            list.SelectedItemsAsString = null;
        }

        public static void SetNumericUpDown()
        {
            Keyboard.SendKeys("{Up}");
            Keyboard.SendKeys("{Left}");
        }

        public static void SetComboBox(string name, string targetName)
        {
            WinComboBox comboBox = (WinComboBox)Robot.FindWinControlByType(typeof(WinComboBox), name, _root);
            if (comboBox.SelectedItem != targetName)
                comboBox.SelectedItem = targetName;
        }

        public static void SetCheckBox(string name, bool isChecked)
        {
            WinCheckBox checkBox = (WinCheckBox)Robot.FindWinControl(typeof(WinCheckBox), name, _root);
            if (checkBox.Checked != isChecked)
                checkBox.Checked = isChecked;
        }

        public static void AssertEdit(string name, string assertValue)
        {
            WinEdit edit = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            Assert.AreEqual(edit.Text, assertValue);
        }

        public static void AssertText(string name, string assertValue)
        {
            WinText edit = (WinText)Robot.FindWinControl(typeof(WinText), name, _root);
            Assert.AreEqual(edit.DisplayText, assertValue);
        }

        public static void AssertCheckBox(string name, bool isChecked)
        {
            WinCheckBox checkBox = (WinCheckBox)Robot.FindWinControl(typeof(WinCheckBox), name, _root);
            Assert.AreEqual(checkBox.Checked, isChecked);
        }

        public static void AssertNumericUpDown(string name, string index, string[] data)
        {
            AssertDataGridViewByIndex(name, index, data);
        }

        public static void AssertDateTimePicker(string[] data)
        {
            WinDateTimePicker dateTimePicker = (WinDateTimePicker)Robot.FindWinControl(typeof(WinDateTimePicker), data[0], _root);
            Assert.AreEqual(dateTimePicker.DateTime.Year, int.Parse(data[1]));
            Assert.AreEqual(dateTimePicker.DateTime.Month, int.Parse(data[2]));
            Assert.AreEqual(dateTimePicker.DateTime.Day, int.Parse(data[3]));
        }

        public static void AssertComboBox(string name, string assertValue)
        {
            WinComboBox comboBox = (WinComboBox)Robot.FindWinControlByType(typeof(WinComboBox), name, _root);
            Assert.AreEqual(comboBox.SelectedItem, assertValue);
        }

        public static void AssertListViewByValue(string name, string[] data)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = name;
            WinList list = new WinList(window);
            list.WindowTitles.Add("Task Type");
            UITestControlCollection collection = list.Items;
            for (int i = 0; i < collection.Count; i++)
            {
                Assert.AreEqual(data[i], collection[i].Name);
            }
        }

        public static void AssertDataGridViewByIndex(string name, string index, string[] data)
        {
            WinTable table = (WinTable)Robot.FindWinControlByType(typeof(WinTable), name, _root);
            WinRow _Winrow = new WinRow(table);
            _Winrow.SearchProperties.Add(WinRow.PropertyNames.RowIndex, index);
            _Winrow.Find();
            UITestControlCollection collection = _Winrow.GetChildren();
            for (int i = 0; i < collection.Count; i++)
            {
                WinCell cell = collection[i] as WinCell;
                if (cell != null)
                    Assert.AreEqual(data[i], cell.Value);
            }
        }

        public static void AssertDataItemsInDataGridView(string name, int items)
        {
            WinTable table = (WinTable)Robot.FindWinControlByType(typeof(WinTable), name, _root);
            Assert.AreEqual(table.Rows.Count, items);
        }

        public static void AssertButtonEnable(string name, bool state)
        {
            WinButton button = (WinButton)Robot.FindWinControl(typeof(WinButton), name, _root);
            Assert.AreEqual(button.Enabled, state);
        }

        public static void AssertWindow(string name)
        {
            const string KEY_TEXT = "\n";
            WinWindow window = (WinWindow)Robot.FindWinControl(typeof(WinWindow), name, null);
            Keyboard.SendKeys(window, KEY_TEXT);
        }

        public static void SendKeyEnterToMessageBox(string caption)
        {
            WinControl control = (WinControl)Robot.FindWinControl(typeof(WinControl), caption, null);
            Keyboard.SendKeys("{Enter}");
        }

        public static void ClickRadioButton(string name)
        {
            WinRadioButton radio = (WinRadioButton)Robot.FindWinControl(typeof(WinRadioButton), name, _root);
            Mouse.Click(radio);
        }

        public static void ClickHyperlink(string name)
        {
            WinHyperlink hyperink = (WinHyperlink)Robot.FindWinControl(typeof(WinHyperlink), name, _root);
            Mouse.Click(hyperink);
        }

        private static WinControl FindWinControlByType(Type type, string name, UITestControl parent)
        {
            if (_cache.ContainsKey(name))
            {
                return (WinControl)_cache[name];
            }
            else
            {
                WinControl control = (WinControl)Activator.CreateInstance(type, new Object[] { parent });
                control.SearchProperties.Add(WinControl.PropertyNames.ControlType, name);
                CacheComponentFound(control, name);
                return control;
            }
        }
    }
}
