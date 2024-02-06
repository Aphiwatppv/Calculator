using System;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            //VerifiesMethod verifiesMethod = new VerifiesMethod("Test");
            InitialUserControlInterface();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void InitialUserControlInterface()
        {

            //btn Calling Btn

            //Panel Setup
            panelbar.Size = new System.Drawing.Size(this.Width, this.Height * 5 / 100);


            PanelPad.Size = new System.Drawing.Size(this.Width * 2 / 3, this.Height - panelbar.Height);

            //btnpadsize 1-9 
            int btnwidth = PanelPad.Size.Width / 5;
            int btnheight = PanelPad.Size.Height / 6;

            btnPad1.Size = new System.Drawing.Size(btnwidth, btnheight);
            btnPad2.Size = new System.Drawing.Size(btnwidth, btnheight);
            btnPad3.Size = new System.Drawing.Size(btnwidth, btnheight);
            btnPad4.Size = new System.Drawing.Size(btnwidth, btnheight);
            btnPad5.Size = new System.Drawing.Size(btnwidth, btnheight);
            btnPad6.Size = new System.Drawing.Size(btnwidth, btnheight);
            btnPad7.Size = new System.Drawing.Size(btnwidth, btnheight);
            btnPad8.Size = new System.Drawing.Size(btnwidth, btnheight);
            btnPad9.Size = new System.Drawing.Size(btnwidth, btnheight);

            //btnOperationSize


            Button[] buttons = { btnPad1, btnPad2, btnPad3, btnPad4, btnPad5, btnPad6, btnPad7, btnPad8, btnPad9 };
            foreach (Button btn in buttons)
            {
                btn.Size = new System.Drawing.Size(btnwidth, btnheight);
                PanelPad.Controls.Add(btn); // Add button to PanelPad
            }

            int x = (int)(PanelPad.Width * 0.01);
            int y = PanelPad.Size.Height - 2*btnheight - (int)(PanelPad.Height * 0.01);

            // Arrange buttons
            for (int i = 0; i < buttons.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    x = (int)(PanelPad.Width * 0.01); // Reset x to start of new row
                    y -= btnheight + (int)(PanelPad.Height * 0.01); // Move y up for new row
                }

                buttons[i].Size = new System.Drawing.Size(btnwidth, btnheight);
                buttons[i].Location = new System.Drawing.Point(x, y);
                PanelPad.Controls.Add(buttons[i]); // Add button to PanelPad

                x += btnwidth + (int)(PanelPad.Width * 0.01); // Move x to next button position
            }




        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {

        }
    }
}
