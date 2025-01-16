//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    //화면에 나오는 표를 화면에 출력해볼 겁니다.
//    //단 빈 칸이 하나라도 잇는 데이터는 제외합니다.
//    //표를 통해 구조체 customer를 만들어줍니다.
//    //만약 표에 중복된 고객이 존재할 경우 1개의 내용만 사용합니다.

//    struct customer '고객' 구조체
//    {
//        public string name; //  이름
//        public int year;  // 출생 년도
//        public string addr; // 주소
//        public int number;   //연락처
//        public string item;   //구매 목록
//        public int price;   //단가
//        public int amount;   //수량

//        public customer(string name, int year, string address, string phone_number, string item, int price, int count)
//        {
//            this.name = name;
//            this.year = year;
//            this.address = address;
//            this.phone_number = phone_number;
//            this.item = item;
//            this.price = price;
//            this.count = count;
//        }
//    }
//    }
//    internal class table1 
//    {
//        static void Customers(ref Customers c, string name, int year, string addr, int number, string item, int price, int amount)
//        {
//            c.name = name;
//            c.year = year;
//            c.addr = addr;
//            c.number = number;
//            c.item = item;
//            c.price = price;
//            c.amount = amount;


//            static void Customers(Customers c)
//            {
//                Console.WriteLine("이름\t출생년도\t주소\t연락처\t구매목록\t단가\t수량");
//                Console.WriteLine($"{c.name}  |  {c.year}  |  {c.addr}  |  {c.number} {c.item} {c.price} {c.amount}");


//            }

//    internal class table
//    {
//        static void PrintTable(customer[] c)
//        {
//            Console.WriteLine("==============================================");
//            Console.WriteLine("고객명 출생년도 주소 연락처 구매목록 단가 수량");
//            Console.WriteLine("==============================================");
//            for (int i = 0; i < c.Length; i++)
//            {
//                Console.WriteLine($"{c[i].name} {c[i].year} {c[i].address} {c[i].phone_number} {c[i].item} {c[i].price} {c[i].count}");
//            }
//            Console.WriteLine("==============================================");
//        }

//        static void Main(string[] args)
//        {
//            Customers c = new Customers();

//            Customers c1; //구조체 선언
//            c1 = new Customers();   //  구조체 생성     ---> 생성할 경우 구조체가 가지는 값은 기본 값을 가지게 됩니다.(기본 값은 0)
//            c1.name = "김원범";
//            c1.year = 1993;
//            c1.addr = "안산";
//            c1.number = 67421045;
//            c1.item = "폰";
//            c1.price = 1000;
//            c1.amount = 1;


//            //CustomersStteing(c1, , "투썸레몬", Gender.남, 24);
//            // 선언만 된 구조체를 넣어서 작업하는 것은 불가능합니다. 값을 넣어주거나 비교해줄 것이 필요함.
//            // 구조체 생성을 통해 구조체를 초기화하여 작업합니다.


//        }

//        static void Main(string[] args)
//        {
//            customer[] customers =
//            {
//                new customer("김용수",1979,"서울","010-222-2222","USB",11000,1)
//                ,
//                new customer("유성연",1988,"전남","019-777-4444","책",13000,1)
//                ,
//                new customer("차주원",1965,"경기","010-444-4444","샤프",3000,1)
//                ,
//                new customer("임현식",1960,"경북","011-555-5555","음료수",1500,30)
//                ,
//                new customer("성시경",1997,"경북","012-666-6666","책",17000,1)
//                ,
//                new customer("양미현",1991,"서울","010-777-7777","노트",2000,5)
//                ,  
//                new customer("임무혁",1993,"경북","011-888-8888","샤프",3000,1)
//            };
//            PrintTable(customers);
//        }
//    }
//}
