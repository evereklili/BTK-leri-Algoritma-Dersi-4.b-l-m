//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2.Algoritma.SinglyLinkedList
//{
//    public class Programs
//    {
//        static void Main(string [] args)
//        {

//            var linkedlist = new SinglyLinkedList<int>();
//            linkedlist.AddFirst(1);
//            linkedlist.AddFirst(2);
//            linkedlist.AddFirst(3);
//            Console.ReadLine();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Algoritma.SinglyLinkedList
{
    public class Programs
    {
        static void Main(string[] args)
        {

            var linkedlist = new SinglyLinkedList<int>();
            linkedlist.AddFirst(1);
            linkedlist.AddFirst(2);
            linkedlist.AddFirst(3);
            //1,2,3,
            linkedlist.AddLast(4);
            linkedlist.AddLast(5);
            ////3,2,1,4,5 koyacak o(n) şeklinde çalışır. bunu gözlemleriz. 


            //Console.ReadLine();

            ////bir önceki dersimizde lista başına eklemeyi yaptık. liste başına eklemeye başlayacağzı. 
            ////bunun için referans düğümden liste başına kadar gelir. bu liste başındaki en son düğümü dikkate alırız. 
            ////Next ifadesini eklenmek istenen yeni düğüm ile güncelleme yapacağız. Mevcut listedeki prev yani en son eklenen düğüm işaretçisini güncelleriz. 
            ////bir çevrim dahilinde iteratif şeklinde bunun karmaşılığı o(n) olmak üzere
            ///


            //şimdi araya ekleme yapacağız. bir refereans ekleme alacağız. öncesine de sonrasına da ekleme yapabiliriz. 
            //AddBefore(); AddAfter(); şeklinde ekleme yapabiliriz. 


            //araya ekleme işlemi yapacağız. şimdi devam edelim: 
            linkedlist.AddAfter(linkedlist.Head.Next,32);
            Console.ReadLine(); 
        }
    }
}
