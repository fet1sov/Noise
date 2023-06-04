﻿using Noise.Client;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Noise
{
    /// <summary>
    /// Логика взаимодействия для MusicPlatform.xaml
    /// </summary>
    public partial class MusicPlatform : Window
    {
        public bool isMaximasized = false;
        public CornerRadius closeButtonRadius;
        public MusicPlatform()
        {
            InitializeComponent();
            profileName.Content = Config.userInfo.login;
        }

        private void dragAWindow(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (!isMaximasized)
                    DragMove();
            }
            catch (Exception)
            {

            }

            if (e.ClickCount == 2)
            {
                if (!isMaximasized)
                {
                    var time = 2;
                    var sizeAnimationWidth = new DoubleAnimation
                    {
                        From = this.Width,
                        To = SystemParameters.WorkArea.Width,
                        Duration = new Duration(TimeSpan.FromSeconds(time)),
                        EasingFunction = new CubicEase { EasingMode = EasingMode.EaseInOut }
                    };

                    var sizeAnimationHeight = new DoubleAnimation
                    {
                        From = this.Height,
                        To = SystemParameters.WorkArea.Height,
                        Duration = new Duration(TimeSpan.FromSeconds(time)),
                        EasingFunction = new CubicEase { EasingMode = EasingMode.EaseInOut }
                    };

                    this.BeginAnimation(Window.WidthProperty, sizeAnimationWidth);
                    this.BeginAnimation(Window.HeightProperty, sizeAnimationHeight);

                    windowBorder.CornerRadius = new CornerRadius(0);
                    songPlayer.CornerRadius = new CornerRadius(0);

                    this.Left = 0;
                    this.Top = 0;

                    isMaximasized = true;
                } else {
                    this.Width = 800;
                    this.Height = 450;

                    this.Left = (SystemParameters.WorkArea.Width / 2) - (this.Width / 2);
                    this.Top = (SystemParameters.WorkArea.Height / 2) - (this.Height / 2);

                    windowBorder.CornerRadius = new CornerRadius(25);
                    songPlayer.CornerRadius = new CornerRadius(0, 0, 25, 25);

                    isMaximasized = false;
                }
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (isMaximasized)
            {
               if (Mouse.Capture((IInputElement)sender))
               {
                    windowBorder.CornerRadius = new CornerRadius(25);
                    songPlayer.CornerRadius = new CornerRadius(0, 0, 25, 25);

                    isMaximasized = false;
               }
            }
        }
    }
}
