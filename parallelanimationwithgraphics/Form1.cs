using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace parallelanimationwithgraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g1,gr,gg,gb,g0;
        Pen pen1 = new Pen(Color.Gray, 1);
        Pen penr = new Pen(Color.Red, 1);
        Pen peng = new Pen(Color.Green, 1);
        Pen penb = new Pen(Color.Blue, 1);
        Pen pen0 = new Pen(Color.White, 1);

        public int ismd = 0;
           

        Thread t1, t2, t3, t4, t5;

        public delegate void  f();

       
        public void desen1()
        {
            Random x = new Random();
            for (int i = 1; i < 200; i++)
            {
                try
                {


                    g1.DrawEllipse(pen1, x.Next(1000), x.Next(1000),x.Next(2), x.Next(2));
                }
                catch { }
                Thread.Sleep(10);

            }
        }
        public void desenr()
        {
            Random x = new Random();
            for (int i = 1; i < 200; i++)
            {
                try
                {

                    gr.DrawEllipse(penr, x.Next(1000), x.Next(1000),x.Next(2), x.Next(2));
                 }
                catch { }
                Thread.Sleep(2);

            }
        }
        public void deseng()
        {
            Random x = new Random();
            for (int i = 1; i < 200; i++)
            {
                try
                {

                    gg.DrawEllipse(peng, x.Next(1000), x.Next(1000),x.Next(2), x.Next(2));
                 }
                catch { }
                Thread.Sleep(2);

            }
        }
        public void desenb()
        {
            Random x = new Random();
            for (int i = 1; i < 200; i++)
            {
                try
                {

                    gb.DrawEllipse(penb, x.Next(1000), x.Next(1000),x.Next(2), x.Next(2));
                 }
                catch { }
                Thread.Sleep(2);

            }
        }
        public void desen0()
        {
            Random x = new Random();
            for (int i = 1; i < 200; i++)
            {
             try
                {

                    g0.DrawEllipse(pen0, x.Next(1000), x.Next(1000),x.Next(2), x.Next(2));
                
                }
             catch { } 
                Thread.Sleep(2);

            }
        }
        public void threadb(string t )
        {
            

            if (t == "t1")
            {
                t1 = new Thread(desen1);
                t1.Start();
            }
            if (t =="t2")
            {
                t2 = new Thread(desenr);
                t2.Start();
            }
            if (t == "t3")
            {
                t3 = new Thread(deseng);
                t3.Start();
            }
            if (t == "t4")
            {
                t4 = new Thread(desenb);
                t4.Start();
            }
            if (t == "t5")
            {
                t5 = new Thread(desen0);
                t5.Start();
            }
                
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g1 = CreateGraphics();
            gr = CreateGraphics();
            gg = CreateGraphics();
            gb = CreateGraphics();
            g0 = CreateGraphics();
            
        }

        public void enablebutton(Button btn)
        {
            btn.Enabled = true;
        }
        public void disablebutton(Button btn)
        {
            btn.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        { try{
            t1.Join();
             }catch{}
            disablebutton(button1);
            threadb("t1");
           
            Thread.Sleep(2);
            enablebutton(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            t2.Join();
             }catch{}
            disablebutton(button2);
            threadb("t2");
           
            Thread.Sleep(2);
            enablebutton(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
             try
            {t3.Join();
       }catch{}
            disablebutton(button3);
            threadb("t3");
           
            Thread.Sleep(2);
            enablebutton(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
             try
            {t4.Join();
       }catch{}
            disablebutton(button4);
            threadb("t4");
            
            Thread.Sleep(2);
            enablebutton(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            { t5.Join();
       }catch{}
            disablebutton(button5);
            threadb("t5");
            
            Thread.Sleep(2);
            enablebutton(button5);
        }

        public void simulate()
        {

           while(ismd!=1){
            
            try{
            t1.Join();
             }catch{}
            disablebutton(button1);
            threadb("t1");
           
            Thread.Sleep(2);
            enablebutton(button1);
        
            try
            {
            t2.Join();
             }catch{}
            disablebutton(button2);
            threadb("t2");
           
            Thread.Sleep(2);
            enablebutton(button2);
       
             try
            {t3.Join();
       }catch{}
            disablebutton(button3);
            threadb("t3");
           
            Thread.Sleep(2);
            enablebutton(button3);
        
             try
            {t4.Join();
       }catch{}
            disablebutton(button4);
            threadb("t4");
            
            Thread.Sleep(2);
            enablebutton(button4);
       
            try
            { t5.Join();
       }catch{}
            disablebutton(button5);
            threadb("t5");
            
            Thread.Sleep(2);
            enablebutton(button5);
            }
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            simulate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }
    }
}
