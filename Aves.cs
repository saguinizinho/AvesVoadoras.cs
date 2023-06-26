using System;

namespace AvesVirtual

{
 public class Aves
 {
    public int Id {get; set;}
    public string Especie  {get; set;}
    public string Nome {get; set;}

     public virtual void Voar(){
      Console.WriteLine("Voador");
    }
 }

}