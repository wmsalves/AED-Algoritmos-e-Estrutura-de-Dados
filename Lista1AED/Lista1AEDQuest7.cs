using System;
using System.Collections;

class Program {
    public static void Main (string[] args) {
    Console.WriteLine("7 – Crie o procedimento public void ConcatenaArrayList2(ArrayList AL1, ArrayList AL2, ArrayList AL3), o qual copia todos os elementos de AL1 e AL2 para AL3. ");
    Console.WriteLine(" ");

      
    ArrayList AL1 = new ArrayList();
    AL1.Add(20);
    AL1.Add(55);
    AL1.Add(2);
    AL1.Add(4);
    AL1.Add(5);

    ArrayList AL2 = new ArrayList();
    AL2.Add(1);
    AL2.Add(2);
    AL2.Add(3);
    AL2.Add(4);
    AL2.Add(5);
    ArrayList AL3 = ConcatenaArrayList(AL1, AL2);
    Console.WriteLine("Mostrar nova ArrayList contendo todos elementos: ");
   	foreach (object o in AL3){
      Console.WriteLine(o + " ");
    }
  }

    static public ArrayList ConcatenaArrayList(ArrayList AL1, ArrayList AL2){
    ArrayList AL3 = new ArrayList(AL1.Count + AL2.Count);
    for (int i = 0; i < AL1.Count; i++){
      AL3.Add(AL1[i]);
    }
    for (int i = 0; i < AL2.Count; i++){
      AL3.Add(AL2[i]);
    }
    return AL3;
  }
}