using System.Drawing;
namespace DoubleLayerANN
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.init = new System.Windows.Forms.Button();
            this.input_1 = new System.Windows.Forms.TextBox();
            this.input_2 = new System.Windows.Forms.TextBox();
            this.hidden1 = new System.Windows.Forms.TextBox();
            this.hidden2 = new System.Windows.Forms.TextBox();
            this.target1 = new System.Windows.Forms.TextBox();
            this.l1w1n1 = new System.Windows.Forms.TextBox();
            this.l2w1n1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l1w2n1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.l1w1n2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.l1w2n2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labeln2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tips = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.step2 = new System.Windows.Forms.Button();
            this.step3 = new System.Windows.Forms.Button();
            this.step4 = new System.Windows.Forms.Button();
            this.step5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.step7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.step6 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lr = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.target2 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.l2w2n1 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.l2w1n2 = new System.Windows.Forms.TextBox();
            this.l2w2n2 = new System.Windows.Forms.TextBox();
            this.lossfunc = new System.Windows.Forms.Label();
            this.lf = new System.Windows.Forms.TextBox();
            this.op1 = new System.Windows.Forms.Label();
            this.oput1 = new System.Windows.Forms.Label();
            this.oput2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pd111 = new System.Windows.Forms.Label();
            this.pd121 = new System.Windows.Forms.Label();
            this.pd112 = new System.Windows.Forms.Label();
            this.pd122 = new System.Windows.Forms.Label();
            this.pd211 = new System.Windows.Forms.Label();
            this.pd221 = new System.Windows.Forms.Label();
            this.pd212 = new System.Windows.Forms.Label();
            this.pd222 = new System.Windows.Forms.Label();
            this.sh1 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.sh2 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // init
            // 
            this.init.Location = new System.Drawing.Point(143, 326);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(277, 23);
            this.init.TabIndex = 1;
            this.init.Text = "1. Init, randomly generated weights";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.submit_Click);
            // 
            // input_1
            // 
            this.input_1.Location = new System.Drawing.Point(24, 84);
            this.input_1.Name = "input_1";
            this.input_1.Size = new System.Drawing.Size(100, 21);
            this.input_1.TabIndex = 2;
            // 
            // input_2
            // 
            this.input_2.Location = new System.Drawing.Point(24, 190);
            this.input_2.Name = "input_2";
            this.input_2.Size = new System.Drawing.Size(100, 21);
            this.input_2.TabIndex = 3;
            // 
            // hidden1
            // 
            this.hidden1.Enabled = false;
            this.hidden1.Location = new System.Drawing.Point(353, 84);
            this.hidden1.Name = "hidden1";
            this.hidden1.Size = new System.Drawing.Size(100, 21);
            this.hidden1.TabIndex = 4;
            // 
            // hidden2
            // 
            this.hidden2.Enabled = false;
            this.hidden2.Location = new System.Drawing.Point(353, 190);
            this.hidden2.Name = "hidden2";
            this.hidden2.Size = new System.Drawing.Size(100, 21);
            this.hidden2.TabIndex = 5;
            // 
            // target1
            // 
            this.target1.Location = new System.Drawing.Point(657, 83);
            this.target1.Name = "target1";
            this.target1.Size = new System.Drawing.Size(100, 21);
            this.target1.TabIndex = 6;
            this.target1.TextChanged += new System.EventHandler(this.target_TextChanged);
            // 
            // l1w1n1
            // 
            this.l1w1n1.Enabled = false;
            this.l1w1n1.Location = new System.Drawing.Point(189, 38);
            this.l1w1n1.Name = "l1w1n1";
            this.l1w1n1.Size = new System.Drawing.Size(100, 21);
            this.l1w1n1.TabIndex = 7;
            // 
            // l2w1n1
            // 
            this.l2w1n1.Enabled = false;
            this.l2w1n1.Location = new System.Drawing.Point(506, 38);
            this.l2w1n1.Name = "l2w1n1";
            this.l2w1n1.Size = new System.Drawing.Size(100, 21);
            this.l2w1n1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "input_1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "input_2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "hidden_1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "hidden_2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "output_1";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "layer1_weight1_1";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "layer1_weight2_1";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // l1w2n1
            // 
            this.l1w2n1.Enabled = false;
            this.l1w2n1.Location = new System.Drawing.Point(189, 107);
            this.l1w2n1.Name = "l1w2n1";
            this.l1w2n1.Size = new System.Drawing.Size(100, 21);
            this.l1w2n1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "layer1_weight1_2";
            // 
            // l1w1n2
            // 
            this.l1w1n2.Enabled = false;
            this.l1w1n2.Location = new System.Drawing.Point(189, 166);
            this.l1w1n2.Name = "l1w1n2";
            this.l1w1n2.Size = new System.Drawing.Size(100, 21);
            this.l1w1n2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "layer1_weight2_2";
            // 
            // l1w2n2
            // 
            this.l1w2n2.Enabled = false;
            this.l1w2n2.Location = new System.Drawing.Point(189, 242);
            this.l1w2n2.Name = "l1w2n2";
            this.l1w2n2.Size = new System.Drawing.Size(100, 21);
            this.l1w2n2.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "layer2_weight1_1";
            // 
            // labeln2
            // 
            this.labeln2.AutoSize = true;
            this.labeln2.Location = new System.Drawing.Point(505, 227);
            this.labeln2.Name = "labeln2";
            this.labeln2.Size = new System.Drawing.Size(101, 12);
            this.labeln2.TabIndex = 25;
            this.labeln2.Text = "layer2_weight2_2";
            this.labeln2.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(22, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "Step:";
            // 
            // tips
            // 
            this.tips.AutoSize = true;
            this.tips.ForeColor = System.Drawing.Color.Red;
            this.tips.Location = new System.Drawing.Point(22, 292);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(65, 12);
            this.tips.TabIndex = 27;
            this.tips.Text = "waiting...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "Training step：";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // step2
            // 
            this.step2.Location = new System.Drawing.Point(143, 355);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(364, 23);
            this.step2.TabIndex = 29;
            this.step2.Text = "2. Input layer -> hidden layer weighted summation";
            this.step2.UseVisualStyleBackColor = true;
            this.step2.Click += new System.EventHandler(this.step2_Click);
            // 
            // step3
            // 
            this.step3.Location = new System.Drawing.Point(513, 355);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(272, 23);
            this.step3.TabIndex = 30;
            this.step3.Text = "3. Activate hidden layer nodes(sigmoid)";
            this.step3.UseVisualStyleBackColor = true;
            this.step3.Click += new System.EventHandler(this.step3_Click);
            // 
            // step4
            // 
            this.step4.Location = new System.Drawing.Point(12, 384);
            this.step4.Name = "step4";
            this.step4.Size = new System.Drawing.Size(374, 23);
            this.step4.TabIndex = 31;
            this.step4.Text = "4. Hidden layer -> output layer weighted summation";
            this.step4.UseVisualStyleBackColor = true;
            this.step4.Click += new System.EventHandler(this.step4_Click);
            // 
            // step5
            // 
            this.step5.Location = new System.Drawing.Point(392, 384);
            this.step5.Name = "step5";
            this.step5.Size = new System.Drawing.Size(393, 23);
            this.step5.TabIndex = 32;
            this.step5.Text = "5. Activate output layer nodes(sigmoid)";
            this.step5.UseVisualStyleBackColor = true;
            this.step5.Click += new System.EventHandler(this.step5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 12);
            this.label13.TabIndex = 33;
            this.label13.Text = "Forward propagation:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 456);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 12);
            this.label15.TabIndex = 34;
            this.label15.Text = "Backpropagation:";
            // 
            // step7
            // 
            this.step7.Location = new System.Drawing.Point(119, 451);
            this.step7.Name = "step7";
            this.step7.Size = new System.Drawing.Size(316, 23);
            this.step7.TabIndex = 35;
            this.step7.Text = "7. Update output layer -> hidden layer weights";
            this.step7.UseVisualStyleBackColor = true;
            this.step7.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(444, 451);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(316, 23);
            this.button6.TabIndex = 36;
            this.button6.Text = "8. Update input layer -> hidden layer weights";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // step6
            // 
            this.step6.Location = new System.Drawing.Point(12, 413);
            this.step6.Name = "step6";
            this.step6.Size = new System.Drawing.Size(374, 23);
            this.step6.TabIndex = 37;
            this.step6.Text = "6. Calculating loss function";
            this.step6.UseVisualStyleBackColor = true;
            this.step6.Click += new System.EventHandler(this.step6_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(12, 518);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 12);
            this.label16.TabIndex = 40;
            this.label16.Text = "Technical Term - 专业术语:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 542);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 12);
            this.label17.TabIndex = 41;
            this.label17.Text = "Error term - 残差";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(141, 542);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 12);
            this.label18.TabIndex = 42;
            this.label18.Text = "Forward propagation - 前向传播";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(351, 542);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(185, 12);
            this.label19.TabIndex = 43;
            this.label19.Text = "Backpropagation(BP) - 反向传播";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(224, 486);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(383, 12);
            this.label20.TabIndex = 44;
            this.label20.Text = "Finally, You have completed once \"learning\" (gradient descent).";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(569, 542);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(191, 12);
            this.label21.TabIndex = 45;
            this.label21.Text = "Gradient descent(GD) - 梯度下降";
            // 
            // lr
            // 
            this.lr.Location = new System.Drawing.Point(685, 328);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(100, 21);
            this.lr.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(518, 331);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(161, 12);
            this.label22.TabIndex = 47;
            this.label22.Text = "Learning rate - 学习速率 :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(683, 176);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 49;
            this.label23.Text = "output_2";
            // 
            // target2
            // 
            this.target2.Location = new System.Drawing.Point(657, 190);
            this.target2.Name = "target2";
            this.target2.Size = new System.Drawing.Size(100, 21);
            this.target2.TabIndex = 48;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(22, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 12);
            this.label24.TabIndex = 50;
            this.label24.Text = "BP neural network :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(504, 92);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(101, 12);
            this.label25.TabIndex = 52;
            this.label25.Text = "layer2_weight2_1";
            // 
            // l2w2n1
            // 
            this.l2w2n1.Enabled = false;
            this.l2w2n1.Location = new System.Drawing.Point(506, 107);
            this.l2w2n1.Name = "l2w2n1";
            this.l2w2n1.Size = new System.Drawing.Size(100, 21);
            this.l2w2n1.TabIndex = 51;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(503, 152);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 12);
            this.label26.TabIndex = 54;
            this.label26.Text = "layer2_weight1_2";
            // 
            // l2w1n2
            // 
            this.l2w1n2.Enabled = false;
            this.l2w1n2.Location = new System.Drawing.Point(507, 166);
            this.l2w1n2.Name = "l2w1n2";
            this.l2w1n2.Size = new System.Drawing.Size(100, 21);
            this.l2w1n2.TabIndex = 53;
            // 
            // l2w2n2
            // 
            this.l2w2n2.Enabled = false;
            this.l2w2n2.Location = new System.Drawing.Point(506, 242);
            this.l2w2n2.Name = "l2w2n2";
            this.l2w2n2.Size = new System.Drawing.Size(100, 21);
            this.l2w2n2.TabIndex = 55;
            // 
            // lossfunc
            // 
            this.lossfunc.AutoSize = true;
            this.lossfunc.ForeColor = System.Drawing.Color.Red;
            this.lossfunc.Location = new System.Drawing.Point(518, 304);
            this.lossfunc.Name = "lossfunc";
            this.lossfunc.Size = new System.Drawing.Size(167, 12);
            this.lossfunc.TabIndex = 56;
            this.lossfunc.Text = "Loss function - 损失函数 : ";
            // 
            // lf
            // 
            this.lf.Enabled = false;
            this.lf.Location = new System.Drawing.Point(685, 301);
            this.lf.Name = "lf";
            this.lf.Size = new System.Drawing.Size(100, 21);
            this.lf.TabIndex = 57;
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Location = new System.Drawing.Point(683, 47);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(0, 12);
            this.op1.TabIndex = 58;
            // 
            // oput1
            // 
            this.oput1.AutoSize = true;
            this.oput1.Location = new System.Drawing.Point(638, 47);
            this.oput1.Name = "oput1";
            this.oput1.Size = new System.Drawing.Size(149, 12);
            this.oput1.TabIndex = 59;
            this.oput1.Text = "sigmoid(output_1_weight)";
            // 
            // oput2
            // 
            this.oput2.AutoSize = true;
            this.oput2.Location = new System.Drawing.Point(638, 152);
            this.oput2.Name = "oput2";
            this.oput2.Size = new System.Drawing.Size(149, 12);
            this.oput2.TabIndex = 60;
            this.oput2.Text = "sigmoid(output_2_weight)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 567);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 12);
            this.label11.TabIndex = 61;
            this.label11.Text = "Partial derivative(PD) - 偏导数";
            // 
            // pd111
            // 
            this.pd111.AutoSize = true;
            this.pd111.Location = new System.Drawing.Point(204, 9);
            this.pd111.Name = "pd111";
            this.pd111.Size = new System.Drawing.Size(71, 12);
            this.pd111.TabIndex = 62;
            this.pd111.Text = "PD111偏导数";
            // 
            // pd121
            // 
            this.pd121.AutoSize = true;
            this.pd121.Location = new System.Drawing.Point(204, 80);
            this.pd121.Name = "pd121";
            this.pd121.Size = new System.Drawing.Size(71, 12);
            this.pd121.TabIndex = 63;
            this.pd121.Text = "PD121偏导数";
            // 
            // pd112
            // 
            this.pd112.AutoSize = true;
            this.pd112.Location = new System.Drawing.Point(204, 139);
            this.pd112.Name = "pd112";
            this.pd112.Size = new System.Drawing.Size(71, 12);
            this.pd112.TabIndex = 64;
            this.pd112.Text = "PD112偏导数";
            // 
            // pd122
            // 
            this.pd122.AutoSize = true;
            this.pd122.Location = new System.Drawing.Point(204, 215);
            this.pd122.Name = "pd122";
            this.pd122.Size = new System.Drawing.Size(71, 12);
            this.pd122.TabIndex = 65;
            this.pd122.Text = "PD122偏导数";
            // 
            // pd211
            // 
            this.pd211.AutoSize = true;
            this.pd211.Location = new System.Drawing.Point(518, 12);
            this.pd211.Name = "pd211";
            this.pd211.Size = new System.Drawing.Size(71, 12);
            this.pd211.TabIndex = 66;
            this.pd211.Text = "PD211偏导数";
            // 
            // pd221
            // 
            this.pd221.AutoSize = true;
            this.pd221.Location = new System.Drawing.Point(518, 80);
            this.pd221.Name = "pd221";
            this.pd221.Size = new System.Drawing.Size(71, 12);
            this.pd221.TabIndex = 67;
            this.pd221.Text = "PD221偏导数";
            // 
            // pd212
            // 
            this.pd212.AutoSize = true;
            this.pd212.Location = new System.Drawing.Point(518, 140);
            this.pd212.Name = "pd212";
            this.pd212.Size = new System.Drawing.Size(71, 12);
            this.pd212.TabIndex = 68;
            this.pd212.Text = "PD212偏导数";
            // 
            // pd222
            // 
            this.pd222.AutoSize = true;
            this.pd222.Location = new System.Drawing.Point(518, 215);
            this.pd222.Name = "pd222";
            this.pd222.Size = new System.Drawing.Size(71, 12);
            this.pd222.TabIndex = 69;
            this.pd222.Text = "PD222偏导数";
            // 
            // sh1
            // 
            this.sh1.AutoSize = true;
            this.sh1.Location = new System.Drawing.Point(351, 47);
            this.sh1.Name = "sh1";
            this.sh1.Size = new System.Drawing.Size(113, 12);
            this.sh1.TabIndex = 70;
            this.sh1.Text = "sigmoid(hiddent_1)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(217, 567);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(185, 12);
            this.label29.TabIndex = 72;
            this.label29.Text = "Activation function - 激活函数";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(331, 251);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(0, 12);
            this.label30.TabIndex = 73;
            // 
            // sh2
            // 
            this.sh2.AutoSize = true;
            this.sh2.Location = new System.Drawing.Point(351, 152);
            this.sh2.Name = "sh2";
            this.sh2.Size = new System.Drawing.Size(113, 12);
            this.sh2.TabIndex = 74;
            this.sh2.Text = "sigmoid(hiddent_2)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(413, 567);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(185, 12);
            this.label27.TabIndex = 75;
            this.label27.Text = "Sigmoid() - 一种常用的激活函数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 592);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.sh2);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.sh1);
            this.Controls.Add(this.pd222);
            this.Controls.Add(this.pd212);
            this.Controls.Add(this.pd221);
            this.Controls.Add(this.pd211);
            this.Controls.Add(this.pd122);
            this.Controls.Add(this.pd112);
            this.Controls.Add(this.pd121);
            this.Controls.Add(this.pd111);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.oput2);
            this.Controls.Add(this.oput1);
            this.Controls.Add(this.op1);
            this.Controls.Add(this.lf);
            this.Controls.Add(this.lossfunc);
            this.Controls.Add(this.l2w2n2);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.l2w1n2);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.l2w2n1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.target2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lr);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.step6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.step7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.step5);
            this.Controls.Add(this.step4);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labeln2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.l1w2n2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.l1w1n2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.l1w2n1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l2w1n1);
            this.Controls.Add(this.l1w1n1);
            this.Controls.Add(this.target1);
            this.Controls.Add(this.hidden2);
            this.Controls.Add(this.hidden1);
            this.Controls.Add(this.input_2);
            this.Controls.Add(this.input_1);
            this.Controls.Add(this.init);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Backpropagation Learner - 反向传播小霸王学习机 ------ Author : Alex Leung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button init;
        private System.Windows.Forms.TextBox input_1;
        private System.Windows.Forms.TextBox input_2;
        private System.Windows.Forms.TextBox hidden1;
        private System.Windows.Forms.TextBox hidden2;
        private System.Windows.Forms.TextBox target1;
        private System.Windows.Forms.TextBox l1w1n1;
        private System.Windows.Forms.TextBox l2w1n1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox l1w2n1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox l1w1n2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox l1w2n2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labeln2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label tips;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button step2;
        private System.Windows.Forms.Button step3;
        private System.Windows.Forms.Button step4;
        private System.Windows.Forms.Button step5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button step7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button step6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox lr;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox target2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox l2w2n1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox l2w1n2;
        private System.Windows.Forms.TextBox l2w2n2;
        private System.Windows.Forms.Label lossfunc;
        private System.Windows.Forms.TextBox lf;
        private System.Windows.Forms.Label op1;
        private System.Windows.Forms.Label oput1;
        private System.Windows.Forms.Label oput2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label pd111;
        private System.Windows.Forms.Label pd121;
        private System.Windows.Forms.Label pd112;
        private System.Windows.Forms.Label pd122;
        private System.Windows.Forms.Label pd211;
        private System.Windows.Forms.Label pd221;
        private System.Windows.Forms.Label pd212;
        private System.Windows.Forms.Label pd222;
        private System.Windows.Forms.Label sh1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label sh2;
        private System.Windows.Forms.Label label27;
    }
}

