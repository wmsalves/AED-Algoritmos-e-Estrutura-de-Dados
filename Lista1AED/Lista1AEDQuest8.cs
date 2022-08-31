using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("8 – Crie a função public ArrayList Intersecao(ArrayList AL1, ArrayList AL2) que retorna um ArrayList contendo os elementos em comum armazenados em AL1 e AL2, sem repetição. ");
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
    ArrayList AL3 = Intersecao(AL1, AL2);
    Console.WriteLine("Mostrar ArrayList: ");
   	foreach (object o in AL3){
      Console.WriteLine(o + " ");
    }
  } 
  static public ArrayList Intersecao(ArrayList AL1, ArrayList AL2){

    ArrayList intersec = new ArrayList();

    foreach (object o in AL1){
      if (AL2.Contains(o) && !intersec.Contains(o)){
        intersec.Add(o);
      }
    }
    return intersec;
  }
}