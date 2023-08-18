// System  네임 스페이스를 사용한다.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 네임스페이스 선언
namespace ConsoleApp1
// 공간 선언을 통해 중복되는 이름을 피할 수 있기 때문에. ex) ConsoleApp1.Apple클래스 ConsoleApp2.Apple클래스
{
    // class는 하나의 객체를 표현한다.
    // class Program은 C#에서 프로그램의 가장 첫번째 실행되는 Main 메소드를 포함하는 용도로 주로 사용한다.
    class Program
    {

        // ex) class Car가 있으면 자동차의 구성요소(멤버변수)와 행동적인요소(method)를 가질 수 있다.
        class Car {
            private string handle = "AMODEL";

            public void Run()
            {
                Console.WriteLine("자동차를 움직인다.");
            }
        }

        // 프로그램의 주시작점. Main
        static void Main(string[] args)
        {
            //System네임스페이스의 Console클래스의 WriteLine메소드 호출
            System.Console.WriteLine("Syste을 이용한 호출");
            Console.WriteLine("Hello World!");

        }
    }
}
// 무조건 암기해야하는 단축키
//  ctrl + s => 저장
//  단축키 ctrl + shift + B => 빌드
//  ctrl + F5 => 실행