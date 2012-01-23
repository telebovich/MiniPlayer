using System;
using System.Collections.Generic;
using System.Linq;
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

using Microsoft.Win32;
using QuartzTypeLib;

namespace MiniPlayer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;" +
                        "*.wav;*.mp2;*.mp3|All Files|*.*";

            Nullable<bool> result = openFile.ShowDialog();

            if (result == true)
            {
                FilgraphManager filterGraph = new FilgraphManager();
                
                // This is to show video in a separate control
                // IMediaControl mc = filterGraph as IMediaControl;

                IBasicAudio m_objBasicAudio = filterGraph as IBasicAudio;
                IVideoWindow m_objVideoWindow;

                try
                {
                    m_objVideoWindow = filterGraph as IVideoWindow;
                }
                catch (Exception ex)
                {
                    m_objVideoWindow = null;
                }
            }
        }
    }
}
