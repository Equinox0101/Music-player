using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WMPLib;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer ncb1 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer ncb2 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer ncb3 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer ncb4 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer ncb5 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer ncb6 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer ncb7 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer CurrentMusic = new WMPLib.WindowsMediaPlayer();
        
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ncb1.URL= @"C:\Users\adavi\source\repos\WindowsFormsApp1\WindowsFormsApp1\Sounds\ncb1.mp3";
            ncb1.controls.play();
            CurrentMusic.controls.stop();
            CurrentMusic = ncb1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ncb2.URL = @"C:\Users\adavi\source\repos\WindowsFormsApp1\WindowsFormsApp1\Sounds\ncb2.mp3";
            ncb2.controls.play();
            CurrentMusic.controls.stop();
            CurrentMusic = ncb2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ncb3.URL = @"C:\Users\adavi\source\repos\WindowsFormsApp1\WindowsFormsApp1\Sounds\ncb3.mp3";
            ncb3.controls.play();
            CurrentMusic.controls.stop();
            CurrentMusic = ncb3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ncb4.URL = @"C:\Users\adavi\source\repos\WindowsFormsApp1\WindowsFormsApp1\Sounds\ncb4.mp3";
            ncb4.controls.play();
            CurrentMusic.controls.stop();
            CurrentMusic = ncb4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ncb5.URL = @"C:\Users\adavi\source\repos\WindowsFormsApp1\WindowsFormsApp1\Sounds\ncb5.mp3";
            ncb5.controls.play();
            CurrentMusic.controls.stop();
            CurrentMusic = ncb5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ncb6.URL = @"C:\Users\adavi\source\repos\WindowsFormsApp1\WindowsFormsApp1\Sounds\ncb6.mp3";
            ncb6.controls.play();
            CurrentMusic.controls.stop();
            CurrentMusic = ncb6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ncb7.URL = @"C:\Users\adavi\source\repos\WindowsFormsApp1\WindowsFormsApp1\Sounds\ncb7.mp3";
            ncb7.controls.play();
            CurrentMusic.controls.stop();
            CurrentMusic = ncb7;
        }

        bool IsPaused = false;
        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (!IsPaused) { CurrentMusic.controls.pause(); IsPaused = true; }
            else { CurrentMusic.controls.play(); IsPaused = false; }

        }
        
        

    }
}
