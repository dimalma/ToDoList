using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生一個方格
            ToDoItem item = new ToDoItem();
            
            // 放到 TodoStack
            TodoStack.Children.Add(item);
        }

        private void SaveBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            List<string> all = new List<string>();

            // 取得每一個 item 的文字
            foreach( ToDoItem item in TodoStack.Children)
            {
                all.Add(item.GetTaskName());
            }

            // 寫入檔案
            System.IO.File.WriteAllLines(@"C:\ToDoData.txt", all);
        }
    }
}
