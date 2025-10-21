using System;
using System.Drawing;
using System.Windows.Forms;

//以下代码不用写，直接用Form App生成UI界面，就像seminar上面讲的一样
namespace ModernCalculator
{
    public partial class MainForm : Form
    {
        private TextBox txtNum1;      // 第一个数
        private TextBox txtNum2;      // 第二个数
        private TextBox txtResult;    // 结果
        private Button btnAdd;        // 加法
        private Button btnSubtract;   // 减法
        private Button btnMultiply;   // 乘法
        private Button btnDivide;     // 除法
        private Button btnPower;      // x的y次方
        private Button btnRoot;       // x的y次方根
        private Label lblDeveloper;   // 开发者信息

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // 窗体设置
            this.Text = "计算器";
            this.Size = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 244, 248);

            // 开发者信息标签
            lblDeveloper = new Label
            {
                Text = "Developer: Yiwen Zhang",
                Font = new Font("Arial", 9, FontStyle.Italic),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(40, 10),
                Size = new Size(310, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // 第一个数输入框
            txtNum1 = new TextBox
            {
                Font = new Font("Arial", 12),
                Location = new Point(40, 40),
                Size = new Size(310, 30),
                Text = "0"
            };

            // 第二个数输入框
            txtNum2 = new TextBox
            {
                Font = new Font("Arial", 12),
                Location = new Point(40, 90),
                Size = new Size(310, 30),
                Text = "0"
            };

            // 结果显示框
            txtResult = new TextBox
            {
                Font = new Font("Arial", 14, FontStyle.Bold),
                Location = new Point(40, 290),
                Size = new Size(310, 30),
                ReadOnly = true,
                BackColor = Color.White,
                TextAlign = HorizontalAlignment.Center
            };

            // 创建按钮
            btnAdd = CreateButton("+", 40, 150, Color.FromArgb(59, 130, 246));
            btnSubtract = CreateButton("−", 145, 150, Color.FromArgb(139, 92, 246));
            btnMultiply = CreateButton("×", 250, 150, Color.FromArgb(236, 72, 153));
            btnDivide = CreateButton("÷", 40, 210, Color.FromArgb(249, 115, 22));
            btnPower = CreateButton("x^y", 145, 210, Color.FromArgb(34, 197, 94));
            btnRoot = CreateButton("ʸ√x", 250, 210, Color.FromArgb(168, 85, 247));

            // 绑定事件
            btnAdd.Click += (s, e) => txtResult.Text = MathEngine.Add(txtNum1.Text, txtNum2.Text);
            btnSubtract.Click += (s, e) => txtResult.Text = MathEngine.Subtract(txtNum1.Text, txtNum2.Text);
            btnMultiply.Click += (s, e) => txtResult.Text = MathEngine.Multiply(txtNum1.Text, txtNum2.Text);
            btnDivide.Click += (s, e) => txtResult.Text = MathEngine.Divide(txtNum1.Text, txtNum2.Text);
            btnPower.Click += (s, e) => txtResult.Text = MathEngine.Power(txtNum1.Text, txtNum2.Text);
            btnRoot.Click += (s, e) => txtResult.Text = MathEngine.Root(txtNum1.Text, txtNum2.Text);

            // 添加控件到窗体
            this.Controls.AddRange(new Control[]
            {
                lblDeveloper,
                txtNum1, txtNum2, txtResult,
                btnAdd, btnSubtract, btnMultiply,
                btnDivide, btnPower, btnRoot
            });
        }

        // 创建按钮
        private Button CreateButton(string text, int x, int y, Color color)
        {
            var btn = new Button
            {
                Text = text,
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(x, y),
                Size = new Size(95, 45),
                BackColor = color,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }
    }
}