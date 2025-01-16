using System.Security.Cryptography.X509Certificates;

namespace Practice
{
    public class Car  // 차 클래스를 생성하고 각각 자동차의 특징들이나 기능들을 정리한다.
    {

        // 클래스 멤버들

        // 필드
        // 메서드
        // 속성
        // 생성자

        public string Model { get; set; }  // 모델 속성
        public string Color { get; set; }  // 색깔 속성
        public int Year { get; set; }  // 년도 속성
       

        public Car(string model, string color, int year)  // 생성자
        {
            Model = model;
            Color = color;
            Year = year;
        }


        // 기능을 넣어줄 메서드(함수)를 생성합니다.
        // 모든 함수는 자식클래스에 오버라이딩해주어 자식클래스에서 사용해준다
        // virtual - override로 생성해주고 각 자식 클래스마다 뿌려주어 활용할 수 있다.
        public virtual void Accelerate() // 가속 메서드  클래스는 메서드를 가질 수 있음 
        {
            Console.WriteLine("The car is accelerating");  // 함수가 호출되어 잘 작용하는지 확인하기 위해 디버그를 찍어봄
        }

        public virtual void Brake()  // 브레이크 메서드
        {
            Console.WriteLine("The car is braking"); // 함수가 호출되어 잘 작용하는지 확인하기 위해 디버그를 찍어봄
        }

        public virtual void Stop()  // 멈춤 메서드
        {
            Console.WriteLine($"MyCaris stopped"); // 함수가 호출되어 잘 작용하는지 확인하기 위해 디버그를 찍어봄
        }

    }

    // SportsCar 클래스를 생성하고, Car 클래스의 메서드를 받아옵니다.
    // Car 클래스의 메서드를 오버라이딩하여 재활용합니다.
    public class SportsCar : Car // SportsCar 클래스의 추가적인 멤버들
    {
        public SportsCar(string model, string color, int year) : base(model, color, year)
        {
        }

        public override void Accelerate() //  오버라이딩하여 Car 클래스의 메서드를 받아옴
        {
            Console.WriteLine($"Sports car {Model} is accelerating");
        }

        public override void Stop()
        {
            Console.WriteLine($"Sports Car ({Model}) is stopped");
        }

        public override void Brake()
        {
            Console.WriteLine("Sports car is braking");
        }
    }

    public class FriendCar : Car  // 오버라이딩하여 Car 클래스의 메서드를 받아와 재활용
    {
        public FriendCar(string model, string color, int year) : base(model, color, year)
        {
        }

        public override void Brake()
        {
            Console.WriteLine($"Friend car ({Model}, {Color}) is braking");
        }
    }

    public class BankAccount  // 계좌번호의 클래스 생성
    {
        private decimal balance;  // 금액을 캡슐화 해줌

        public decimal Balance  // 캡슐화를 할 때 get, set 정리
        {
            get { return balance; }
            set { balance = value; }
        }
    }



    public static class Program  // 자식 클래스를 가질 수 없음 (정적 클래스)
    {
        
        public static void Main(string[] args)  // Main은 static 을 포함한다.
        {


            Car myCar = new Car("Tesla Model S", "Black", 2024);    //  Car 객체 생성  Car 클래스의 속성과 메서드를 사용할 수 있다.
            myCar.Model = "Tesla Model S";  // Car 클래스에서 생성해준 Model 을 사용합니다. public string Model { get; set; } Model 생성 = 초기화;
            myCar.Color = "Black"; // Color 생성 = 초기화;
            myCar.Year = 2024;  // Year 생성 = 초기화;

            FriendCar friendCar = new FriendCar("Toyota Corolla", "Yellow", 2022);  // Car 인스턴스 생성 -> FriendCar의 오버라이딩값을 가짐.
            friendCar.Model = "Toyota Corolla";  // 생성 초기화
            friendCar.Color = "Yellow"; // 생성 초기화
            friendCar.Year = 2022;  // 생성 초기화



            SportsCar sportsCar = new SportsCar("Hyundai H","Red", 2016);
            sportsCar.Model = "Hyundai H";
            sportsCar.Color = "Red";
            sportsCar.Year = 2016;

            
            //sportsCar.Brake();


            Console.WriteLine($"Car Model : {myCar.Model}");
            Console.WriteLine($"Friend Car Model : {friendCar.Model}");
            Console.WriteLine($"Sports Car Model : {sportsCar.Model}");
            Console.WriteLine($"Sports Car Color : {sportsCar.Color}");
            sportsCar.Accelerate(); // 메서드를 호출하여 동작 확인  
            myCar.Accelerate();

            friendCar.Brake();

            myCar.Stop();
            
            
            sportsCar.Stop(); // 메서드를 호출하여 동작 확인


            CharacterType.Warrior player1 = new CharacterType.Warrior();

            CharacterType.Wizard player2 = new CharacterType.Wizard();
        }
    }

   

    public class CharacterType
    {
        public class Warrior
        {
            // 전사 클래스의 속성과 동작, 기능들을 넣어준다.
        }

        public class Wizard
        {
            // 마법사 클래스의 속성과 동작, 기능들을 넣어준다
        }

    }

    public class Weapon
    {
        // 공격 무기 클래스의 속성과 동작, 기능들을 넣어준다.
    }

    public class Armor
    {
        // 방어구의 클래스의 속성과 동작, 기능들을 넣어준다.
    }


}

    
       
    

