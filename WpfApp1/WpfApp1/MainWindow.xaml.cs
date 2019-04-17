using System;
using System.Windows;
using System.Windows.Input;
using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Media;

namespace WpfApp1
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private Button btnAdd = new Button();

    public MainWindow()
    {
      InitializeComponent();

    }


    private void Border_MouseEnter(object sender, MouseEventArgs e)
    {
      MessageBox.Show("test2");
      const String output = "testOutput,testOutput2";
      Console.Write(output);
   
      this.Close();
    }

    private void Window_Closed(object sender, EventArgs e)
    {
    }

  }
}
