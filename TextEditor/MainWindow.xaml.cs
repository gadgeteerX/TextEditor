﻿using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mnuClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OpenCmdCanExecute(object sender, CanExecuteRoutedEventArgs e) 
        { 
            e.CanExecute = true;
        }

        private void OpenCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog()
            {
                Filter = "Text File|*.txt",
                FileName = "aaa.txt",
            };


            if (o.ShowDialog() == true)
            {
                string strtemp = File.ReadAllText(o.FileName);
                txtEditor.Text = strtemp;
            }
        }

        private void SaveCmdCanExecute(object obj, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveCmdExecuted(object obj, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog()
            {
                Filter = "Text File|*.txt",
                FileName = "aaa.txt",
            };

            if (s.ShowDialog() == true)
            {
                File.WriteAllText(s.FileName, txtEditor.Text);
            }
        }
    }
}