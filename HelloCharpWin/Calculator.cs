using System;

namespace HelloCharpWin
{
    public partial class Calculator : Form
    {
        // enum 열거형 데이터 타입을 선언
        // public enum Season { Spring, Summer, Fall, Winter }
        // 열거형 데이터 타입을 할당
        // Season CurrentSeason = Season.Spring;

        public enum Operators { Add, Sub, Multi, Div };

        public int Result = 0;
        // isNewNum이 true인 때는 처음 시작했을 때, + 버튼이 클릭되었을 때
        public bool isNewNum = true;

        public Operators Opt = Operators.Add;

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
            // sender가 object 형태이므로 Button 형태로 바꿔서 변수에 담아준다.
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
            // 변수 = 0;
            // 연산자 = +;

            // 숫자 입력
            // 연산자 버튼 - 숫자 완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장
            // 숫자 입력

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