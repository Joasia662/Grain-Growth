using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        Boolean firstuse = true;
        int[,] CustomMatrix = new int[150, 150];
        int[,] AutoMatrix;
      
        Dictionary<int, Color> colorsAndIds = new Dictionary<int, Color>();
        Dictionary<int, Color> colorsAndIdsCustom = new Dictionary<int, Color>();

        private int pixelCount = 0;
        private int pixelSize=4;
        private int cellsInRow =0;
        private int cellsInColumns=0;

        private Boolean run =false;
        public Form1()
        {
            InitializeComponent();
            this.cbNeighborhood.SelectedIndex = 0;
            this.cbCondition.SelectedIndex = 1;
            this.numJedCount.Hide();
            this.lbJed1.Hide();
            this.lbJed2.Hide();
            this.btnJedDraw.Hide();

            this.labRand1.Hide();
            this.labRand2.Hide();
            this.numRand.Hide();         
            this.btnRand.Hide();
            this.numRand.Minimum = 1;

            this.btnRadius.Hide();
            this.labRad1.Hide();
            this.labRad2.Hide();
            this.labRad3.Hide();
            this.labRad4.Hide();
            this.numRadLen.Hide();
            this.numRadQuantity.Hide();

            colorsAndIds.Add(0, Color.Black);
            colorsAndIdsCustom.Add(0, Color.Black);
            this.cbTypeOfGrid.SelectedIndex = 0;

            this.btnStart.Show();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            SetPixelNumbers();
            this.btnStart.Text = "Stop";
            wait(100);
            run = !run;
            while (run)
            {
                int[,] myMatrix;
            Dictionary<int, Color> myColors = new Dictionary<int, Color>();
            if (cbTypeOfGrid.SelectedItem.ToString() == "Custom")
            {
                myMatrix = CustomMatrix.Clone() as int[,];
                myColors = colorsAndIdsCustom;
                
            }
            else
            {

                 myMatrix = AutoMatrix.Clone() as int[,];
                myColors = colorsAndIds;
            }
            int[,] newMatrix = new int[cellsInRow, cellsInColumns];
            drawTable(myMatrix, myColors);

           
                switch (this.cbNeighborhood.SelectedItem.ToString())
                {
                    case "Von Neumanna":
                        for (int i = 0; i < cellsInRow; i++)
                        {
                            for (int j = 0; j < cellsInColumns; j++)
                            {
                                if (myMatrix[i, j] == 0)
                                {
                                    string condition = cbCondition.SelectedItem.ToString();
                                    newMatrix[i, j] = NeumannNeighborhood.returnNextStep(myMatrix, cellsInRow, cellsInColumns, i, j, condition);
                                    if (cbTypeOfGrid.SelectedItem.ToString() == "Custom") CustomMatrix[i, j] = newMatrix[i, j];
                                    else AutoMatrix[i, j] = newMatrix[i, j];
                                 }
                                else { 
                               
                                    newMatrix[i, j] = myMatrix[i, j];
                                    if (cbTypeOfGrid.SelectedItem.ToString() == "Custom") CustomMatrix[i, j]= newMatrix[i, j];
                                    else AutoMatrix[i, j] = newMatrix[i, j];
                                }
                            }
                        }
                        drawTable(newMatrix, myColors);
                       
   
                      break;

                    case "Moore'a":
                    for (int i = 0; i < cellsInRow; i++)
                    {
                        for (int j = 0; j < cellsInColumns; j++)
                        {
                            if (myMatrix[i, j] == 0)
                            {
                                string condition = cbCondition.SelectedItem.ToString();
                                newMatrix[i, j] = MooreNeighborhood.returnNextStep(myMatrix, cellsInRow, cellsInColumns, i, j, condition);
                                if (cbTypeOfGrid.SelectedItem.ToString() == "Custom") CustomMatrix[i, j] = newMatrix[i, j];
                                else AutoMatrix[i, j] = newMatrix[i, j];
                            }
                            else
                            {
                                newMatrix[i, j] = myMatrix[i, j];
                                if (cbTypeOfGrid.SelectedItem.ToString() == "Custom") CustomMatrix[i, j] = newMatrix[i, j];
                                else AutoMatrix[i, j] = newMatrix[i, j];
                            }
                        }
                    }
                    drawTable(newMatrix, myColors);         
                    break;

                    case "Heksagonalne":
                    for (int i = 0; i < cellsInRow; i++)
                    {

                        for (int j = 0; j < cellsInColumns; j++)
                        {
                            if (myMatrix[i, j] == 0)
                            {
                                string condition = cbCondition.SelectedItem.ToString();
                                string variable = this.cbHeks.SelectedItem.ToString();
                                if (variable == "random")
                                {
                                    Random random = new Random();
                                    int penta = (int)(random.NextDouble() * 2);
                                    if (penta == 1) variable = "z lewej strony";
                                    else variable = "z prawej strony";
                                }

                                newMatrix[i, j] = HexagonalNeighborhood.returnNextStep(myMatrix, cellsInRow, cellsInColumns, i, j, condition, variable);
                                if (cbTypeOfGrid.SelectedItem.ToString() == "Custom") CustomMatrix[i, j] = newMatrix[i, j];
                                else AutoMatrix[i, j] = newMatrix[i, j];
                            }
                            else
                            {
                                newMatrix[i, j] = myMatrix[i, j];
                                if (cbTypeOfGrid.SelectedItem.ToString() == "Custom") CustomMatrix[i, j] = newMatrix[i, j];
                                else AutoMatrix[i, j] = newMatrix[i, j];
                            }
                        }
                    }
                    drawTable(newMatrix, myColors);
                    break;
                    case "Pentagonalne":
                       
                        for (int i = 0; i < cellsInRow; i++)
                        {
                            Random random = new Random();
                            int penta = (int)(random.NextDouble() * 4);

                            for (int j = 0; j < cellsInColumns; j++)
                            {
                                if (myMatrix[i, j] == 0)
                                {
                                    string condition = cbCondition.SelectedItem.ToString();
                                    newMatrix[i, j] = PentagonalNeighborhood.returnNextStep(myMatrix, cellsInRow, cellsInColumns, i, j, condition, penta);
                                    if (cbTypeOfGrid.SelectedItem.ToString() == "Custom") CustomMatrix[i, j] = newMatrix[i, j];
                                    else AutoMatrix[i, j] = newMatrix[i, j];
                                }
                                else
                                {
                                    newMatrix[i, j] = myMatrix[i, j];
                                    if (cbTypeOfGrid.SelectedItem.ToString() == "Custom") CustomMatrix[i, j] = newMatrix[i, j];
                                    else AutoMatrix[i, j] = newMatrix[i, j];
                                }
                            }
                        }
                         drawTable(newMatrix, myColors);

                      break;
                    case "Z promieniem":
                        break;
                }

                wait(500);
            }
            this.btnStart.Text = "Start";
            wait(100);
           return;
        }
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        private void cbTypeOfGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            pixelCount = 0;
           
            this.labPixCount .Text= pixelCount.ToString();
            if (this.cbTypeOfGrid.SelectedIndex == 0)
            {
                this.numJedCount.Show();
                SetPixelNumbers();
                this.numJedCount.Maximum = cellsInRow > cellsInColumns ? cellsInColumns : cellsInRow;
                this.numJedCount.Minimum = 1;
                this.numJedCount.Value = 5;

                this.lbJed1.Show();
                this.lbJed2.Show();
                this.btnJedDraw.Show();

            }
            else
            {
               
                this.numJedCount.Hide();
                this.lbJed1.Hide();
                this.lbJed2.Hide();
                this.btnJedDraw.Hide();
            }

            if (this.cbTypeOfGrid.SelectedIndex == 1)
            {
                this.labRand1.Show();
                this.labRand2.Show();
                this.numRand.Show();
                this.btnRand.Show();
                this.numRand.Value = 5;
                this.numRand.Minimum = 1;
            }
            else
            {
                this.labRand1.Hide();
                this.labRand2.Hide();
                this.numRand.Hide();
                this.btnRand.Hide();
            
            }

            if (this.cbTypeOfGrid.SelectedIndex ==2)
            {
                this.btnRadius.Show();
                this.labRad1.Show();
                this.labRad2.Show();
                this.labRad3.Show();
                this.labRad4.Show();
                this.numRadLen.Show();
                this.numRadQuantity.Show();
            }
            else
            {
                this.btnRadius.Hide();
                this.labRad1.Hide();
                this.labRad2.Hide();
                this.labRad3.Hide();
                this.labRad4.Hide();
                this.numRadLen.Hide();
                this.numRadQuantity.Hide();
            }

        }

        private void cbNeighborhood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbNeighborhood.SelectedItem.ToString() == "Heksagonalne")
            {
                this.labHex.Show();
                this.cbHeks.Show();
                this.cbHeks.SelectedIndex = 0;
            }
            else
            {
                this.labHex.Hide();
                this.cbHeks.Hide();
            }

        }

        //---------------------------------------------------------------------------------
        private void btnJedDraw_Click(object sender, EventArgs e)
        {
            
            SetPixelNumbers();
            AutoMatrix = new int[cellsInRow, cellsInColumns];
            fillHomogeneousArray(AutoMatrix);
            drawTable(AutoMatrix, colorsAndIds);
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            
            SetPixelNumbers();
            pixelCount = Convert.ToInt32(this.numRand.Value);
            this.numRand.Maximum = (cellsInColumns * cellsInRow);
            AutoMatrix = fillRandom(cellsInRow, cellsInColumns, Convert.ToInt32(this.numRand.Value));
            drawTable(AutoMatrix, colorsAndIds);
        }

        private void btnRadius_Click(object sender, EventArgs e)
        {
            SetPixelNumbers();
            pixelCount = Convert.ToInt32(this.numRadQuantity.Value);
            AutoMatrix = new int[cellsInRow, cellsInColumns];
            fillRadious(cellsInRow, cellsInColumns, Convert.ToInt32(this.numRadQuantity.Value), Convert.ToInt32(this.numRadLen.Value));
            drawTable(AutoMatrix, colorsAndIds);
        }

        // ---------------------------------------------------------------------------
        private void fillRadious(int width, int height, int embryosNumber, int ray)
        {
            int rangeOfCells = ray;

            Random random = new Random();
            int id = 0;
            int failedTrials = 0;

            Boolean spaceAvailableForEmbryo = true;
            int count = 0;
            while (count <= embryosNumber && failedTrials<100)
            {

                int x = (int)(random.NextDouble() * width);
                int y = (int)(random.NextDouble() * height);

                for (int j = -rangeOfCells; j <= rangeOfCells; j++)
                {
                    for (int k = -rangeOfCells; k <= rangeOfCells; k++)
                    {
                        int heighIndex = y + j;
                        int widthIndex = x + k;
                        if (heighIndex < 0 || widthIndex < 0 || heighIndex > height - 1 || widthIndex > width - 1)
                            continue;
                        if (AutoMatrix[widthIndex, heighIndex] != 0)
                        {
                            spaceAvailableForEmbryo = false;
                            break;
                        }
                    }
                    if (!spaceAvailableForEmbryo)
                        break;
                }
                if (spaceAvailableForEmbryo)
                {
                    id++;
                    AutoMatrix[x, y] = getNewValue(ref colorsAndIds, id);
                    count++;
                    failedTrials = 0;
                }
                else
                    failedTrials++;                  
            }
        }
     
        private int[,] fillRandom(int widithCount, int heightCount, int embryoCount)
        {

            int[,] created_matrix = new int[widithCount, heightCount];
            int x = 0;
            int y = 0;
            Random random = new Random();
            for (int i = 0; i < embryoCount; i++)
            { 
                x = random.Next(0, widithCount - 1);
                y = random.Next(0, heightCount - 1);

                created_matrix[x, y] = getNewValue(ref colorsAndIds, pixelCount);
      
            }

            return created_matrix;
        }


        private void fillHomogeneousArray( int[,] matrix)
        {

            int dX = Convert.ToInt32(this.numGridHeight.Value) /(Convert.ToInt32(this.numJedCount.Value)+1);
            if (dX == 0) dX = 1;

            
            for (int row = 0; row < Convert.ToInt32(this.numJedCount.Value); row++)
            {
                for (int col = 0; col < Convert.ToInt32(this.numJedCount.Value); col++)
                {
                    pixelCount++;
                    AutoMatrix[(row * dX), col * dX] = getNewValue(ref colorsAndIds, pixelCount);
                }
            }
        }

        //''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private int getNewValue(ref Dictionary<int, Color> dictio, int id)
        {
            
            while (true)
            {
                if (!dictio.ContainsKey(id))
                {
                    while (true)
                    {
                        int r = logic.randomNumber(0, 255);
                        int a = 0; 
                        wait(1);
                        int g = logic.randomNumber(0, 255);
                        wait(1);
                        int b = logic.randomNumber(0, 255);
                        Color mycolor = Color.FromArgb(r, g, b);
                        if (!dictio.ContainsValue(mycolor))
                        {
                            dictio.Add(id, mycolor);
                            return id;
                        }
                    }
                }
                else id++;           
            }
        }

        private void SetPixelNumbers()
        {
            pixelSize = 4;
            cellsInRow = Convert.ToInt32(this.numGridWidith.Value);
            cellsInColumns = Convert.ToInt32(numGridHeight.Value);
        }

        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        void Refresh()
        {
            for (int i = 0; i < 150; i++)
            {
                for (int j = 0; j < 150; j++)
                {
                    CustomMatrix[i, j] = 0;
                }
            }
            AutoMatrix = new int[cellsInRow, cellsInColumns];
            for (int i = 0; i < cellsInRow; i++)
            {
                for (int j = 0; j < cellsInColumns; j++)
                {
                    AutoMatrix[i, j] = 0;
                }
            }
            colorsAndIdsCustom.Clear();
            colorsAndIds.Clear();

            colorsAndIds.Add(0, Color.Black);
            colorsAndIdsCustom.Add(0, Color.Black);

            drawTable(CustomMatrix, colorsAndIdsCustom);
        }

        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        void drawTable(int[,] matrix_to_show, Dictionary<int, Color> dictionary)
        {
            this.labPixCount.Text = Convert.ToString(pixelCount) + " px";
            pic.Image = new Bitmap(pic.Width, pic.Height);

            for (int i = 0; i < Convert.ToInt32(this.numGridWidith.Value); i++)
            {
                for (int j = 0; j < Convert.ToInt32(this.numGridHeight.Value); j++)
                {
                    if (matrix_to_show[i, j] != 0)
                    {

                        for (int x = 4 * j; x < (4 * j + 4); x++)

                            for (int y = 4 * i; y < (4 * i + 4); y++)
                            {

                                try
                                {
                                    ((Bitmap)pic.Image).SetPixel(y, x, dictionary[matrix_to_show[i, j]]);
                                    
                                }
                                catch (KeyNotFoundException)
                                {
                                    Console.WriteLine("Key for id=" + matrix_to_show[i, j]  + " is not found.");
                                }
                                catch (NullReferenceException)
                                {
                                    Console.WriteLine("color for given value was not implemented");
                                }
                             
                            }
                    }
                }
            }

        }
    

        private void pic_MouseClick(object sender,  MouseEventArgs e)
        {
            firstuse = true;
            if (this.cbTypeOfGrid.SelectedItem == "Custom" )
            {
                if (e.Location.X <= (Convert.ToInt32(numGridWidith.Value)*4) && e.Location.Y <= 4* Convert.ToInt32(this.numGridHeight.Value))
                {
                    int event_loc_x = e.Location.X;
                    int event_loc_y = e.Location.Y;

                    int mod_x = event_loc_x % pixelSize;
                    int mod_y = event_loc_y % pixelSize;

                    int matrix_x_index = Math.Abs(event_loc_x - mod_x) /pixelSize;
                    int matrix_y_index = Math.Abs(event_loc_y - mod_y) / pixelSize;

                    pixelCount++;
                    if (CustomMatrix[matrix_x_index, matrix_y_index] != 0) CustomMatrix[matrix_x_index, matrix_y_index] = 0;
                    else CustomMatrix[matrix_x_index, matrix_y_index] = getNewValue(ref colorsAndIdsCustom, pixelCount);

                    drawTable(CustomMatrix,colorsAndIdsCustom);
                }
                else 
                {
             
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }
       
        private void Action_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void cbTypeOfGrid_SelectedValueChanged(object sender, EventArgs e)
        {
           


        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void btnStart_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        
    }

}


