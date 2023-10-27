using System;

namespace HelloCharpWin
{
    public partial class Calculator : Form
    {
        // enum ������ ������ Ÿ���� ����
        // public enum Season { Spring, Summer, Fall, Winter }
        // ������ ������ Ÿ���� �Ҵ�
        // Season CurrentSeason = Season.Spring;

        public enum Operators { Add, Sub, Multi, Div };

        public int Result = 0;
        // isNewNum�� true�� ���� ó�� �������� ��, + ��ư�� Ŭ���Ǿ��� ��
        public bool isNewNum = true;

        public Operators Opt = Operators.Add;

        public Calculator()
        {
            InitializeComponent();
        }

        // ������ ���ϱ� �Լ��� �����ϴ� ���
        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        // �Ǽ��� ���ϱ� �Լ��� �����ϴ� ���
        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        // ���� ���� ���ٴ� ���� void�� ����.
        // �Լ��� �����ε�. ���� �̸��� ���� �Ű������� �Ұ���. �Ű������� �ٸ��ٸ� �Լ� �̸��� ���� ���� ��� ���� �� �ִ�.
        // �������� �߿����� �ʴ�.

        // ���� �Լ�
        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

        // ���� = 0;

        // ���� �Է�
        // ���ϱ� ��ư - ���� �ϼ�, ������ ���� ��, ����� ������ �ٽ� ����
        // ���� �Է�
        // ���ϱ� ��ư - ���� �ϼ�, ������ ���� ��, ����� ������ �ٽ� ����
        // �ݺ�

        private void NumButton1_Click(object sender, EventArgs e)
        {
            // sender�� object �����̹Ƿ� Button ���·� �ٲ㼭 ������ ����ش�.
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
        }

        private void NumOpt_Click(object sender, EventArgs e)
        {
            // ���� = 0;
            // ������ = +;

            // ���� �Է�
            // ������ ��ư - ���� �ϼ�, ������ ���ڸ� ����� �����ڷ� ����, ����� ������ ����, ���� �����ڸ� ����
            // ���� �Է�

            if (isNewNum == false)
            {
                int num = int.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                    Result = Add(Result, num);
                else if (Opt == Operators.Sub)
                    Result = Sub(Result, num);

                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }


    }
}