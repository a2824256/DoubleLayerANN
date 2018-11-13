using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleLayerANN
{
    public partial class Form1 : Form
    {
        private ANN AnnInstance;
        private int step = 0;
        public class ANN 
        {
            //输入层
            private Dictionary<string, double> input_layer = new Dictionary<string, double>();
            //输入层与隐藏层的权重
            private Dictionary<string, double> w1_weight = new Dictionary<string, double>();
            //隐藏层
            private Dictionary<string, double> hidden_layer = new Dictionary<string, double>();
            //隐藏层和输出层的权重
            private Dictionary<string, double> w2_weight = new Dictionary<string, double>();
            //输出层
            private Dictionary<string, double> output_layer = new Dictionary<string, double>();
            //输入层和隐藏层的权重数量
            private int w1_weight_num { get; set; }
            //隐藏层和输出层的权重数量
            private int w2_weight_num { get; set; }

            public ANN()
            {
                this.w1_weight_num = 4;
                this.w2_weight_num = 4;
                this.SetDefaultValue(2, 2, 2);
                this.RandomWeightGenerator();
            }

            public double getValue(string dic,string key)
            {
                double res = 0;
                if (dic == "input_layer")
                {
                    res = this.input_layer[key];
                }
                else if (dic == "w1_weight")
                {
                    res = this.w1_weight[key];
                }
                else if (dic == "hidden_layer")
                {
                    res = this.hidden_layer[key];
                }
                else if (dic == "w2_weight")
                {
                    res = this.w2_weight[key];
                }
                else if (dic == "output_layer")
                {
                    res = this.output_layer[key];
                }
                return res;
            }

            public double setValue(string dic, string key,double value)
            {
                double res = 0;
                if (dic == "input_layer")
                {
                    this.input_layer[key] = value;
                }
                else if (dic == "w1_weight")
                {
                    this.w1_weight[key] = value;
                }
                else if (dic == "hidden_layer")
                {
                    this.hidden_layer[key] = value;
                }
                else if (dic == "w2_weight")
                {
                    this.w2_weight[key] = value;
                }
                else if (dic == "output_layer")
                {
                    this.output_layer[key] = value;
                }
                return res;
            }

            public void RandomWeightGenerator()
            {
                Random ran = new Random();
                double weight = 0;
                int counter = 1;
                int counter2 = 1;
                for (int i = 0; i < this.w1_weight_num; i++)
                {
                    weight = Math.Round(ran.NextDouble() * 2 - 1, 1);
                    if (weight >= 1)
                    {
                        weight = 0.9;
                    }
                    if (weight <= -1)
                    {
                        weight = -0.9;
                    }
                    this.w1_weight.Add("w1" + counter2 + counter, weight);
                    counter++;
                    if (counter >= 3)
                    {
                        counter2++;
                        counter = 1;
                    }
                }
                counter2 = 1;
                for (int i2 = 0; i2 < this.w2_weight_num; i2++)
                {
                    weight = Math.Round(ran.NextDouble() * 2 - 1, 1);
                    if (weight >= 1)
                    {
                        weight = 0.9;
                    }
                    if (weight <= -1)
                    {
                        weight = -0.9;
                    }
                    this.w2_weight.Add("w2" + counter2 + counter, weight);
                    counter++;
                    if (counter >= 3)
                    {
                        counter2++;
                        counter = 1;
                    }
                }
            }

            private void SetDefaultValue(int input_node_num, int hidden_node_num, int output_node_num)
            {
                for (int i = 0; i < input_node_num; i++) this.input_layer.Add("input" + (int)(i + 1), 0);
                for (int i2 = 0; i2 < hidden_node_num; i2++) this.hidden_layer.Add("hidden" + (int)(i2 + 1), 0);
                for (int i3 = 0; i3 < output_node_num; i3++) this.output_layer.Add("output" + (int)(i3 + 1), 0);
            }

            private string PrintDictionaryValue(Dictionary<string, double> dic)
            {
                string content = "";
                foreach (KeyValuePair<string, double> kvp in dic)
                {
                    content += kvp.Key + ":" + dic[kvp.Key] + ",";
                }
                content += Environment.NewLine;
                return content;
            }

            public string PrintDefaultValue()
            {
                string content = this.PrintDictionaryValue(this.input_layer);
                content += this.PrintDictionaryValue(this.w1_weight);
                content += this.PrintDictionaryValue(this.hidden_layer);
                content += this.PrintDictionaryValue(this.w2_weight);
                content += this.PrintDictionaryValue(this.output_layer);
                return content;
            }

            public double Sigmoid(double value)
            {
                double res = 1 / (1 + Math.Pow(Math.E, value));
                return res;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.AnnInstance = new ANN();
            tips.Text = "1.Randomly generated weights. 生成随机权重。";
            input_1.Text = AnnInstance.getValue("input_layer","input1").ToString();
            input_2.Text = AnnInstance.getValue("input_layer","input2").ToString();

            l1w1n1.Text = AnnInstance.getValue("w1_weight", "w111").ToString();
            l1w2n1.Text = AnnInstance.getValue("w1_weight", "w121").ToString();
            l1w1n2.Text = AnnInstance.getValue("w1_weight", "w112").ToString();
            l1w2n2.Text = AnnInstance.getValue("w1_weight", "w122").ToString();

            hidden1.Text = AnnInstance.getValue("hidden_layer", "hidden1").ToString();
            hidden2.Text = AnnInstance.getValue("hidden_layer", "hidden2").ToString();

            l2w1n1.Text = AnnInstance.getValue("w2_weight", "w211").ToString();
            l2w2n1.Text = AnnInstance.getValue("w2_weight", "w221").ToString();
            l2w1n2.Text = AnnInstance.getValue("w2_weight", "w212").ToString();
            l2w2n2.Text = AnnInstance.getValue("w2_weight", "w222").ToString();

            target1.Text = AnnInstance.getValue("output_layer", "output1").ToString();
            target2.Text = AnnInstance.getValue("output_layer", "output2").ToString();
            lr.Text = "0.01";
            lf.Text = "0";

            //draw
            Graphics g = this.CreateGraphics();
            
            Pen p = new Pen(Brushes.Black);
            
            Point input1 = new Point(124, 94);
            Point input2 = new Point(124, 200);

            Point output1 = new Point(657, 93);
            Point output2 = new Point(657, 200);

            Point layer2_weight1_n1_1 = new Point(506, 48);
            Point layer2_weight1_n1_2 = new Point(606, 48);
            Point layer2_weight1_n2_1 = new Point(507, 176);
            Point layer2_weight1_n2_2 = new Point(607, 176);
            Point layer2_weight2_n1_1 = new Point(506, 117);
            Point layer2_weight2_n1_2 = new Point(606, 117);
            Point layer2_weight2_n2_1 = new Point(506, 252);
            Point layer2_weight2_n2_2 = new Point(606, 252);

            Point hidden1_1 = new Point(353, 94);
            Point hidden1_2 = new Point(453, 94);
            Point hidden2_1 = new Point(353, 200);
            Point hidden2_2 = new Point(453, 200);

            Point layer1_weight1_n1_1 = new Point(189, 48);
            Point layer1_weight1_n1_2 = new Point(289, 48);
            Point layer1_weight2_n1_1 = new Point(189, 117);
            Point layer1_weight2_n1_2 = new Point(289, 117);

            Point layer1_weight1_n2_1 = new Point(189, 176);
            Point layer1_weight1_n2_2 = new Point(289, 176);
            Point layer1_weight2_n2_1 = new Point(189, 242);
            Point layer1_weight2_n2_2 = new Point(289, 242);
            
            g.DrawLine(p, input1, layer1_weight1_n1_1);
            g.DrawLine(p, input1, layer1_weight1_n2_1);

            g.DrawLine(p, hidden1_1, layer1_weight1_n1_2);
            g.DrawLine(p, hidden2_1, layer1_weight1_n2_2);

            g.DrawLine(p, input2, layer1_weight2_n1_1);
            g.DrawLine(p, input2, layer1_weight2_n2_1);

            g.DrawLine(p, hidden1_1, layer1_weight2_n1_2);
            g.DrawLine(p, hidden2_2, layer2_weight2_n1_1);
            g.DrawLine(p, hidden2_1, layer1_weight2_n2_2);

            g.DrawLine(p, layer2_weight1_n1_1, hidden1_2);
            g.DrawLine(p, layer2_weight2_n2_1, hidden2_2);
            g.DrawLine(p, layer2_weight1_n2_1, hidden1_2);

            g.DrawLine(p, output1, layer2_weight1_n1_2);
            g.DrawLine(p, output1, layer2_weight2_n1_2);
            g.DrawLine(p, output2, layer2_weight1_n2_2);
            g.DrawLine(p, output2, layer2_weight2_n2_2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void step2_Click(object sender, EventArgs e)
        {
            if (input_1.Text=="" || input_2.Text=="")
            {
                MessageBox.Show("Input can not be null!");
            }
            tips.Text = "2. Input layer -> hidden layer weighted summation";
            double input1_value = Convert.ToDouble(input_1.Text);
            double input2_value = Convert.ToDouble(input_2.Text);
            Console.WriteLine(AnnInstance.getValue("w1_weight", "w111"));
            Console.WriteLine(AnnInstance.getValue("w1_weight", "w121"));
            Console.WriteLine(AnnInstance.getValue("w1_weight", "w112"));
            Console.WriteLine(AnnInstance.getValue("w1_weight", "w122"));
            sh1.Text = Math.Round((input1_value * AnnInstance.getValue("w1_weight", "w111") + input2_value* AnnInstance.getValue("w1_weight", "w121")),3).ToString();
            sh2.Text = Math.Round((input1_value * AnnInstance.getValue("w1_weight", "w112") + input2_value* AnnInstance.getValue("w1_weight", "w122")),3).ToString();
        }

        private void step3_Click(object sender, EventArgs e)
        {
            tips.Text = "3. Activate hidden layer nodes(sigmoid)";
            sh1.Text = Math.Round(AnnInstance.Sigmoid(Convert.ToDouble(sh1.Text)),3).ToString();
            sh2.Text = Math.Round(AnnInstance.Sigmoid(Convert.ToDouble(sh2.Text)),3).ToString();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void step4_Click(object sender, EventArgs e)
        {
            tips.Text = "4. Hidden layer -> output layer weighted summation";
            double hidden1_value = Convert.ToDouble(sh1.Text);
            double hidden2_value = Convert.ToDouble(sh2.Text);
            oput1.Text = Math.Round((hidden1_value * AnnInstance.getValue("w2_weight", "w211") + hidden2_value * AnnInstance.getValue("w2_weight", "w221")),3).ToString();
            oput2.Text = Math.Round((hidden1_value * AnnInstance.getValue("w2_weight", "w212") + hidden2_value * AnnInstance.getValue("w2_weight", "w222")),3).ToString();
        }

        private void step5_Click(object sender, EventArgs e)
        {
            tips.Text = "5. Activate output layer nodes(sigmoid)";
            oput1.Text = Math.Round(AnnInstance.Sigmoid(Convert.ToDouble(oput1.Text)), 3).ToString();
            oput2.Text = Math.Round(AnnInstance.Sigmoid(Convert.ToDouble(oput2.Text)), 3).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void target_TextChanged(object sender, EventArgs e)
        {

        }

        private void l2w2_TextChanged(object sender, EventArgs e)
        {

        }

        private void step6_Click(object sender, EventArgs e)
        {
            tips.Text = "6. Calculating loss function";
            double lossfunc1 = Math.Pow((Convert.ToDouble(target1.Text) - Convert.ToDouble(oput1.Text)), 2)/2;
            double lossfunc2 = Math.Pow((Convert.ToDouble(target2.Text) - Convert.ToDouble(oput1.Text)), 2)/2;
            double lossfunc = lossfunc1 + lossfunc2;
            lf.Text = (lossfunc1 + lossfunc2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tips.Text = "7. Update output layer -> hidden layer weights";
            double y1 = Convert.ToDouble(target1.Text);
            double y2 = Convert.ToDouble(target2.Text);
            double op1 = Convert.ToDouble(oput1.Text);
            double op2 = Convert.ToDouble(oput2.Text);
            double hide1_out = Convert.ToDouble(sh1.Text);
            double hide2_out = Convert.ToDouble(sh2.Text);
            double alost1 = -(y1 - op1) * op1 * (1 - op1) * hide1_out;
            pd211.Text = Math.Round(alost1,6).ToString("F");
            double alost2 = -(y1 - op1) * op1 * (1 - op1) * hide1_out;
            pd221.Text = Math.Round(alost2, 6).ToString("F");
            double alost3 = -(y2 - op2) * op2 * (1 - op2) * hide2_out;
            pd212.Text = Math.Round(alost3, 6).ToString("F");
            double alost4 = -(y2 - op2) * op2 * (1 - op2) * hide2_out;
            pd222.Text = Math.Round(alost4, 6).ToString("F");
            l2w1n1.Text = Math.Round((Convert.ToDouble(l2w1n1.Text) - Convert.ToDouble(lr.Text) * alost1),6).ToString("F");
            l2w2n1.Text = Math.Round((Convert.ToDouble(l2w2n1.Text) - Convert.ToDouble(lr.Text) * alost2),6).ToString("F");
            l2w1n2.Text = Math.Round((Convert.ToDouble(l2w1n2.Text) - Convert.ToDouble(lr.Text) * alost3),6).ToString("F");
            l2w2n2.Text = Math.Round((Convert.ToDouble(l2w2n2.Text) - Convert.ToDouble(lr.Text) * alost4),6).ToString("F");
            this.AnnInstance.setValue("w2_weight", "w211", Convert.ToDouble(l2w1n1.Text));
            this.AnnInstance.setValue("w2_weight", "w221", Convert.ToDouble(l2w2n1.Text));
            this.AnnInstance.setValue("w2_weight", "w212", Convert.ToDouble(l2w1n2.Text));
            this.AnnInstance.setValue("w2_weight", "w222", Convert.ToDouble(l2w2n2.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tips.Text = "8. Update input layer -> hidden layer weights";
            double y1 = Convert.ToDouble(target1.Text);
            double y2 = Convert.ToDouble(target2.Text);
            double op1 = Convert.ToDouble(oput1.Text);
            double op2 = Convert.ToDouble(oput2.Text);
            double hide1_out = Convert.ToDouble(sh1.Text);
            double hide2_out = Convert.ToDouble(sh2.Text);
            double wl2w1n1 = Convert.ToDouble(l2w1n1.Text);
            double wl2w2n1 = Convert.ToDouble(l2w2n1.Text);
            double wl2w1n2 = Convert.ToDouble(l2w1n2.Text);
            double wl2w2n2 = Convert.ToDouble(l2w2n2.Text);
            double wl1w1n1 = Convert.ToDouble(l1w1n1.Text);
            double wl1w2n1 = Convert.ToDouble(l1w1n2.Text);
            double wl1w1n2 = Convert.ToDouble(l1w2n1.Text);
            double wl1w2n2 = Convert.ToDouble(l1w2n2.Text);
            double alost1 = -(y1 - op1) * op1 * (1 - op1)*(hide1_out* wl2w1n1+ hide2_out* wl2w1n2)*(1-hide1_out)*hide1_out* Convert.ToDouble(input_1.Text); ;
            double alost2 = -(y1 - op1) * op1 * (1 - op1)*(hide1_out* wl2w1n1+ hide2_out* wl2w1n2)*(1-hide1_out)*hide1_out* Convert.ToDouble(input_2.Text); ;
            double alost3 = -(y1 - op1) * op1 * (1 - op1)*(hide2_out* wl2w2n1+ hide1_out* wl2w2n2)*(1-hide1_out)*hide1_out* Convert.ToDouble(input_1.Text); ;
            double alost4 = -(y1 - op1) * op1 * (1 - op1)*(hide2_out* wl2w2n1+ hide2_out* wl2w2n2)*(1-hide1_out)*hide1_out* Convert.ToDouble(input_2.Text); ;
            pd111.Text = Math.Round(alost1, 6).ToString("F");
            pd121.Text = Math.Round(alost2, 6).ToString("F");
            pd112.Text = Math.Round(alost3, 6).ToString("F");
            pd122.Text = Math.Round(alost4, 6).ToString("F");
            l1w1n1.Text = Math.Round((Convert.ToDouble(l1w1n1.Text) - Convert.ToDouble(lr.Text) * alost1),6).ToString("F");
            l1w1n2.Text = Math.Round((Convert.ToDouble(l1w1n2.Text) - Convert.ToDouble(lr.Text) * alost1),6).ToString("F");
            l1w2n1.Text = Math.Round((Convert.ToDouble(l1w2n1.Text) - Convert.ToDouble(lr.Text) * alost1),6).ToString("F");
            l1w2n2.Text = Math.Round((Convert.ToDouble(l1w2n2.Text) - Convert.ToDouble(lr.Text) * alost1),6).ToString("F");
            this.AnnInstance.setValue("w1_weight", "w111", Convert.ToDouble(l1w1n1.Text));
            this.AnnInstance.setValue("w1_weight", "w121", Convert.ToDouble(l1w2n1.Text));
            this.AnnInstance.setValue("w1_weight", "w112", Convert.ToDouble(l1w1n2.Text));
            this.AnnInstance.setValue("w1_weight", "w122", Convert.ToDouble(l1w2n2.Text));
            //draw
            Graphics g = this.CreateGraphics();

            Pen p = new Pen(Brushes.Black);

            Point input1 = new Point(124, 94);
            Point input2 = new Point(124, 200);

            Point output1 = new Point(657, 93);
            Point output2 = new Point(657, 200);

            Point layer2_weight1_n1_1 = new Point(506, 48);
            Point layer2_weight1_n1_2 = new Point(606, 48);
            Point layer2_weight1_n2_1 = new Point(507, 176);
            Point layer2_weight1_n2_2 = new Point(607, 176);
            Point layer2_weight2_n1_1 = new Point(506, 117);
            Point layer2_weight2_n1_2 = new Point(606, 117);
            Point layer2_weight2_n2_1 = new Point(506, 252);
            Point layer2_weight2_n2_2 = new Point(606, 252);

            Point hidden1_1 = new Point(353, 94);
            Point hidden1_2 = new Point(453, 94);
            Point hidden2_1 = new Point(353, 200);
            Point hidden2_2 = new Point(453, 200);

            Point layer1_weight1_n1_1 = new Point(189, 48);
            Point layer1_weight1_n1_2 = new Point(289, 48);
            Point layer1_weight2_n1_1 = new Point(189, 117);
            Point layer1_weight2_n1_2 = new Point(289, 117);

            Point layer1_weight1_n2_1 = new Point(189, 176);
            Point layer1_weight1_n2_2 = new Point(289, 176);
            Point layer1_weight2_n2_1 = new Point(189, 242);
            Point layer1_weight2_n2_2 = new Point(289, 242);

            g.DrawLine(p, input1, layer1_weight1_n1_1);
            g.DrawLine(p, input1, layer1_weight1_n2_1);

            g.DrawLine(p, hidden1_1, layer1_weight1_n1_2);
            g.DrawLine(p, hidden2_1, layer1_weight1_n2_2);

            g.DrawLine(p, input2, layer1_weight2_n1_1);
            g.DrawLine(p, input2, layer1_weight2_n2_1);

            g.DrawLine(p, hidden1_1, layer1_weight2_n1_2);
            g.DrawLine(p, hidden2_2, layer2_weight2_n1_1);
            g.DrawLine(p, hidden2_1, layer1_weight2_n2_2);

            g.DrawLine(p, layer2_weight1_n1_1, hidden1_2);
            g.DrawLine(p, layer2_weight2_n2_1, hidden2_2);
            g.DrawLine(p, layer2_weight1_n2_1, hidden1_2);

            g.DrawLine(p, output1, layer2_weight1_n1_2);
            g.DrawLine(p, output1, layer2_weight2_n1_2);
            g.DrawLine(p, output2, layer2_weight1_n2_2);
            g.DrawLine(p, output2, layer2_weight2_n2_2);
        }
    }
}
