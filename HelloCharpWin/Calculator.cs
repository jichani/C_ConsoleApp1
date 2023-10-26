using System;

namespace HelloCharpWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {
            // HelloLabel.Text = "Hello C#";

            int number1 = 1;
            int number2 = 2;

            int sum = number1 + number2;

            HelloLabel.Text = sum.ToString();
        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Sum1.Text);
            int number2 = Convert.ToInt32(Sum2.Text);

            int sum = Add(number1, number2);
            SumResult.Text = sum.ToString();
        }

        // 정수형 더하기 함수를 생성하는 방법
        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        // 실수형 더하기 함수를 생성하는 방법
        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        // 리턴 값이 없다는 것을 void로 쓴다.
        // 함수의 오버로딩. 같은 이름과 같은 매개변수는 불가능. 매개변수가 다르다면 함수 이름이 같은 것을 몇개든 만들 수 있다.
        // 리턴형은 중요하지 않다.

        // 빼기 함수
        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }
    }
}