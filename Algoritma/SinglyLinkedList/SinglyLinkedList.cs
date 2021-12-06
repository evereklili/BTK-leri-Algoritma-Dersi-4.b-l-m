using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Algoritma.SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {

        //generic bir sınıf tasarımı yapacağız. 
        //bir referans düğme itiyacımız vardır.
        //dinamik bir programama yapıyruz bellek üzerinde. 
        //biz de bir head düğümü tanımlamalıyız. 
        public  SinglyLinkedListNode<T> Head { get; set; }
        //yeni düğüm tasarımı yapacağız. 
        private bool isHeadNull => Head == null ? true : false;
        public void AddFirst(T Value)
        {
            var newNode = new SinglyLinkedListNode<T>(Value); //yeni node tasarımı yapıyoruz. 
            //içine hangi düğümü olan ama nereyi işaret ediyor bilmiyoruz. 
            newNode.Next=Head;
            Head = newNode;
            //Bir değer geldi 25 head. 
            //önce bir değere değişken olarak ifade ediyoruz. bunu böyle düşünürüz. int tanımlamaktan bir farkı yok. 
            //55 değer olarak alırsa, buna bir de next ifadesi değer kazandırıyoruz. next bir sınıf ve değeri null olarak varsayılan değeri geliyor. 
            //böyle bir düğüm tasarımını gerçekleştirdik. Head=newNode dedik. 
            //sorna 44 gelsin. 44 değerini bir düğüme çeviriyoruz. buna next özelliği kazandırıyoruz. varsayılarn referans ve class oldğu için varsayılan değer nulldur. 
            //bundan sonra newNode.next=head olsun diyoruz. 
            //head=newnode diyoruz. 

            
        }

        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;//tanımlarız. 
            if (Head == isHeadNull)
            {
                Head = newNode;
                return; //programı burada keseriz. dön diyebiliriz. void ifade var burada!
            }
            while (current.Next != null)
            {
                current = current.Next;//bir eleman üzerinde dolaşmamızı sağlayacaktır. 

            }
            current.Next = newNode;  //newNode olacak
                                     //dinamik programalama yapıyoruz. önce head üzerinden 
        }


        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            //bizim şu an tasarladığımız liste colleciton da var. 
            // new LinkedList<int>().AddAfter() burada var olduğunu görüyoruz. kendi veri yapımızı aynı kolleksiyon gibi tasarlamamız lazım ki kullanabilelim. 
            //veri yapıları dersinde bu şekilde daha öcne yapılmış yapının modellemenin yarın kullanacağımız zaman özelleştirebilelim. 
            //bu AddAfter aşırı yüklenmiştir. 
            //addAfter biz yaapcağız AdddBefore siz yapacaksınız. 
            //bazı bölümleri size paslamazsak bitmeyen bir kurs ile karşılaşacağız. Önümüzdeki bölümde çok farklı bir yapı ile karşılaşadcağız. 

            //referans düğüm vermeliyim. 
            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            while (current!=null)
            {
                if(node==null)
                {
                    throw new ArgumentException();
                }
                if(Head==null)
                {
                    AddFirst(value);
                    return;//aşağıdaki ifadeler çalışmasın. 
                }
                if(current.Equals(node))
                {
                    newNode.Next = current.Next; //prev karşılık gelir. 
                    current.Next = newNode;//bu şekilde bağlantıları güncelleyeceim
                    return; //void gördüğü zaman durur ve daha fazla ilerlemez. 

                }
                current = current.Next;//bütün bu listeye dolaştık referans düğüme ulaşamadık, rastlamadık, o zaman bir hata fırlatmalıyzı. 

            }
            throw new ArgumentException("The reference node is not in this list.");


        }
    }
}
