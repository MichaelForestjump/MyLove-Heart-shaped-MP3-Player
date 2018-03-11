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

namespace MyLove
{
    public partial class MainWindow : Window
    {

    MediaPlayer HeartPlayer = new MediaPlayer(); // Create my MediaPlayer Instance as HeartPlayer
    int Playback = 0; // Play State Pause Variable
    System.Random PlaylistShuffle = new Random(); // Creaty my Random Instance

        void Play()
        {            
            int Shuffle = PlaylistShuffle.Next(1, 9); // Next draw numbert from 1 to 9
            HeartPlayer.Open(new Uri(@"./playlist/" + Shuffle + ".mp3", UriKind.Relative)); // Relative file location + concate variable into file location

            //Play - stop switch after click
            if (Playback == 0)
            {
                HeartPlayer.Play();
                Playback = 1;
            }
            else
            {
                HeartPlayer.Stop();
                Playback = 0;
            }
            
        }       

        void Exit()
        {
            int code = 0;
            Environment.Exit(code); // Close application
        }

            void Rolover() // Heart images switch
        {
            Heart2.Opacity = 0.8;
            Play();
        }

    void Rolout()
        {
            Heart2.Opacity = 0.1;
        }         

        public MainWindow() // Mouse Drag support
        {
            InitializeComponent();                    
        }

        private void Window_deactivate(object sender, EventArgs e)
        {
            Topmost = true; // Always on top
        }


        private void Down_heart(object sender, MouseButtonEventArgs e)
        {
            Rolover();
            if (e.ClickCount == 2)
            {
                Close();
            }
        }

        private void Up_heart(object sender, MouseButtonEventArgs e)
        {
            Rolout();
        }        
       
        private void Up_heart(object sender, MouseEventArgs e)
        {
            Rolout();
        }

        private void Up_heart(object sender, DragEventArgs e)
        {
            Rolout();
        }     

        private void Exit(object sender, MouseButtonEventArgs e)
        {
            Exit();
        }      

        private void MoveThis(object sender, MouseButtonEventArgs e)
        {

            base.OnMouseLeftButtonDown(e);            
            this.DragMove();            
        }

        // Close button transparrency switch
        private void CloseRolover(object sender, MouseEventArgs e)
        {
            if (Close.Opacity == 0.5)
                Close.Opacity = 1;
            else
                Close.Opacity = 0.5;
        }
    }
}
