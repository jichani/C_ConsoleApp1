using System;

namespace HelloCharpWin
{
    public partial class Calculator : Form
    {
        public int Result = 0;
        // isNewNum이 true인 때는 처음 시작했을 때, + 버튼이 클릭되었을 때
        public bool isNewNum = true;

        public Calculator()
        {
            InitializeComponent();
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

        // 변수 = 0;

        // 숫자 입력
        // 더하기 버튼 - 숫자 완성, 변수와 숫자 합, 결과를 변수에 다시 저장
        // 숫자 입력
        // 더하기 버튼 - 숫자 완성, 변수와 숫자 합, 결과를 변수에 다시 저장
        // 반복

        private void NumButton1_Click(object sender, EventArgs e)
        {
            SetNum("1");
        }

        private void NumButton2_Click(object sender, EventArgs e)
        {
            SetNum("2");
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

        private void NumPlus_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumScreen.Text);
            Result = Result + num;

            NumScreen.Text = Result.ToString();
            isNewNum = true;
        }
    }
}