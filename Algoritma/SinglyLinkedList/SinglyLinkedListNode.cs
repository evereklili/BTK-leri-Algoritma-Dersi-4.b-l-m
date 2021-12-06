using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Algoritma.SinglyLinkedList
{
    public class SinglyLinkedListNode<T>
    {

        //bir dizide bir yere ekeleme yapabilriz. sona da ekeleme yapabiliriz. bu senaryoları dikkate alacağız bu şekilde ilerleyeceğz. 
        //datastructure içine bir klasör ekleyelim 
        //öncelikle düğüm tasarımı yapacağız. kodlama yaparken  neyi kodluyorsak, dilin söz dizimi ingilizce olduğu için 
        //for while gibi yapılar olduğu için her şeyi ingilizce olarak kodlamaya çalışacağız. 
        //bir node tasarımı yapıyoruz. bir anlamda temel yapısını teşkil edecekher bir düğümü biz bağlayacağız. 
        //ilgili düğümlerde ayrı özelliler olacatır. 
        //iki temel ifade var. dğer tutması gerekiyordu ki bunu item ve bir de next şeklinde işaretçimiz vardı. 


        public SinglyLinkedListNode<T> Next { get; set; }
        public T Value { get; set; }
        public T? Value1 { get; }

        public SinglyLinkedListNode(SinglyLinkedListNode<T> next, T value)
        {
            
            Value = value;
        }

        public SinglyLinkedListNode(T? value)
        {
            Value1 = value;
        }

        //geçersiz kılma yani override olacaktır. 
        public override string ToString()=>$"{Value}";
    }
}