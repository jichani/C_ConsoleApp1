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
            int number1 = 0;
            int number2 = 0;

            // 빈 문자와 공백인지를 확인해주는 메서드 IsNullOrWhiteSpace
            if (string.IsNullOrWhiteSpace(Sum1.Text))
            {
                MessageBox.Show("Sum1에 숫자를 입력해주세요");
                Sum1.Focus();
                return;
            }

            if (int.TryParse(Sum1.Text, out number1) == false)
            {
                MessageBox.Show("Sum1에 문자가 들어왔습니다. 숫자를 입력해주세요");
                Sum1.SelectAll();
                Sum1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Sum2.Text))
            {
                MessageBox.Show("Sum2에 숫자를 입력해주세요");
                return;
            }

            if (int.TryParse(Sum2.Text, out number1) == false)
            {
                MessageBox.Show("Sum2에 문자가 들어왔습니다. 숫자를 입력해주세요");
                return;
            }

            // int.TryParse int형으로 바꾸는 데 바꿔지면 true. 바꿔지지 않으면 false.

            number1 = Convert.ToInt32(Sum1.Text);
            number2 = Convert.ToInt32(Sum2.Text);

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