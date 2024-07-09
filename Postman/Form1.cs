using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;

namespace Postman
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Bitmap background;
        Graphics g;
        DrawMap drawMap;
        RadioButton[] radioButton = new RadioButton[150];
        CheckBox[] checkBox = new CheckBox[150];
        CreateMap cr = new CreateMap();
        int[,] pointBuild;
        List<int[]> mailbox = new List<int[]>();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 150; i++)
            {
                radioButton[i] = new RadioButton();
                radioButton[i].Location = new Point(5, 5 + i * 25);
                radioButton[i].Text = "Дом " + (i + 1);
                panelRadio.Controls.Add(radioButton[i]);

                checkBox[i] = new CheckBox();
                checkBox[i].Location = new Point(5, 5 + i * 25);
                checkBox[i].Text = "Дом " + (i + 1);
                checkBox[i].AutoSize = true;
                panelCheck.Controls.Add(checkBox[i]);
            }

            pbMap.AutoSize = true;
            bitmap = new Bitmap(635, 635);

            background = new Bitmap(635, 635);
            Graphics g2 = Graphics.FromImage(background);
            g2.Clear(Color.White);
            g2 = null;

            g = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.White);
            pbMap.Image = bitmap;
            this.AutoSize = true;

            drawMap = new DrawMap();
            drawMap.bitmap = bitmap;
            drawMap.g = g;
            drawMap.pbMap = pbMap;
            pointBuild = cr.Create();

            drawMap.drawBuild(pointBuild);
        }

        private void buttonCreateMap_Click(object sender, EventArgs e)
        {
            pointBuild = cr.Create();
            drawMap.drawBuild(pointBuild);
        }

        private void buttonWay_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxBag.Text, out var bag))
            {
                MessageBox.Show("Введено не число. Или слишком большое число");
                return;
            }

            if (bag <= 0)
            {
                MessageBox.Show("Объем почтовой сумки должен быть больше 0");
                return;
            }

            mailbox.Clear();
            int postOfisse = -1;

            for (int i = 0; i < 150; i++)
            {
                if (checkBox[i].Checked == true && radioButton[i].Checked == true)
                {
                    MessageBox.Show("Адрес почтового ящика не может совпадать с адресом почтового отделения.");
                    return;
                }

                if (radioButton[i].Checked == true)
                {
                    postOfisse = i;
                    int[] p = { pointBuild[0, i], pointBuild[1, i] };
                    mailbox.Insert(0, p);

                }

                if (checkBox[i].Checked == true)
                {
                    int[] p = { pointBuild[0, i], pointBuild[1, i] };
                    mailbox.Add(p);
                }
            }

            if (postOfisse == -1 || mailbox.Count == 0)
            {
                MessageBox.Show("Адрес почтового отделения и хотя бы один почтовый ящик должны быть выбраны обязательно");
                return;
            }

            int k = (int)Math.Ceiling((double)mailbox.Count /(double)bag);

            bool redraw = true;

            for (int i = 0; i < k; i++)
            {
                if (mailbox.Count != 1){
                    FindWay findWay = new FindWay();
                    List<int> l = findWay.FindMinRoute(findWay.MatrixSmeg(mailbox));
                    List<int[]> ints = findWay.ReternPath(findWay.Center(mailbox), l);
                    drawMap.drawWay(ints, pointBuild, redraw, bag);
                    int n = mailbox.Count;
                    if (i != k - 1)
                        DeleteI(mailbox, l, Math.Min(bag, n));
                    redraw = false;
                }
                
            }
               

        }

        static void DeleteI(List<int[]> mas, List<int> iDel, int n)
        {
            List<int> newIDel = iDel.GetRange(1,n);
            newIDel.Sort();
            for (int i = n-1; i >= 0; i--) {
                mas.RemoveAt(newIDel[i]);
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
