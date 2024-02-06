using System;
using System.Drawing;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            InitialUserControlInterface();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void InitialUserControlInterface()
        {

            // Initial Setup dimension 
            #region Size of objects
            // Panel 
            int UIsizeWidth = this.Width;
            int UIsizeHeight = this.Height;
            int PanelbarWidth = UIsizeWidth;
            int PanelbarHeight = (int)(UIsizeHeight * 0.08);
            panelbar.Size = new System.Drawing.Size(PanelbarWidth, PanelbarHeight);
            this.Controls.Add(panelbar);

            // Panel;
            int PanelPadWidth = (int)(UIsizeWidth * 2 / 3);
            int PanelPadHeigh = (int)(UIsizeHeight - panelbar.Size.Height);

            panelPad.Size = new System.Drawing.Size(PanelPadWidth, PanelPadHeigh);
            // Set up Gap Between Objects;

            int gapwidth = (int)(0.01 * PanelPadWidth);
            int gapheight = (int)(0.01 * PanelPadHeigh);

            //Textbox UserInput
            int txtsizeWidth = ((int)panelPad.Width - 2 * gapwidth);
            int txtsizeHeight = (int)((panelPad.Size.Height - 8 * gapheight) / 7);
            txtInput.Size = new System.Drawing.Size(txtsizeWidth, txtsizeHeight);
            //Pad1 to Pad9 
            int btnPadsWidth = (int)((txtsizeWidth - 4 * gapwidth) / 5);
            int btnPadsHeight = txtsizeHeight;


            Button[] buttons = new Button[] { btnPad1, btnPad2, btnPad3, btnPad4, btnPad5, btnPad6, btnPad7, btnPad8, btnPad9 };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Size = new System.Drawing.Size(btnPadsWidth, btnPadsHeight);
                panelPad.Controls.Add(buttons[i]);
            }

            //Operation Pads
            int btnOperatorWidth = (int)((3 * btnPadsWidth - gapwidth) / 2);
            int btnOperatorHight = btnPadsHeight;

            Button[] btnOperators = new Button[] { btnAddition, btnSubtraction, btndivide, btnMultiply };

            for (int i = 0; i < btnOperators.Length; i++)
            {
                btnOperators[i].Size = new System.Drawing.Size(btnOperatorWidth, btnOperatorHight);
                panelPad.Controls.Add(btnOperators[i]);
            }


            //Zero pad 
            int ZeroPadWidth = (int)((2 * btnPadsWidth + gapwidth));
            int ZeroPadHight = btnPadsHeight;
            btnPad0.Size = new System.Drawing.Size(ZeroPadWidth, ZeroPadHight);
            panelPad.Controls.Add(btnPad0);

            //Dot Pads
            int DotPadWidth = (int)(btnPadsWidth);
            int DotPadHeight = (int)(btnPadsHeight);
            btnPaddot.Size = new System.Drawing.Size(btnPadsWidth, btnPadsHeight);
            panelPad.Controls.Add(btnPaddot);
            //Clear btn 

            int clearbtnWidth = 2 * btnPadsWidth + gapwidth;
            int clearbtnHight = 2 * btnPadsHeight + gapheight;

            btnClear.Size = new System.Drawing.Size(clearbtnWidth, clearbtnHight);
            panelPad.Controls.Add(btnClear);

            //btnEnter Size

            int EnterbtnWidth = 2 * btnPadsWidth + gapwidth;
            int EnterbtnHigh = 4 * btnPadsHeight + 3 * gapheight;

            btnEnter.Size = new System.Drawing.Size(EnterbtnWidth, EnterbtnHigh);
            panelPad.Controls.Add(btnEnter);
            #endregion

            #region Pad's Location
            int x = gapwidth;
            int y = gapheight;
            txtInput.Location = new System.Drawing.Point(x, y);
            panelPad.Controls.Add(txtInput);

            int xOperator = x;
            int yOperator = (2 * y) + btnOperatorHight;

            for (int i = 0; i < btnOperators.Length; i++)
            {
                btnOperators[i].Location = new Point(xOperator, yOperator);
                panelPad.Controls.Add(btnOperators[i]);

                if (i % 2 == 0) 
                {
                   
                    xOperator += btnOperatorWidth + gapwidth;
                }
                else 
                {
                   
                    xOperator = gapwidth;
                    yOperator += btnOperatorHight + gapheight;
                }
            }

            int xClearbtnWidth = 3 * gapwidth + 2 * btnOperatorWidth;
            int yClearbtnHeigh = (2 * y) + btnOperatorHight;

            btnClear.Location = new System.Drawing.Point(xClearbtnWidth, yClearbtnHeigh);

            #endregion


        }



        private void btnSubtraction_Click(object sender, EventArgs e)
        {

        }
    }
}
