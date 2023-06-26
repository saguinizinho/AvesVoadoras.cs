using AvesVirtual;
using System;

Aves Aves = new Aves();
AvesNaoVoadoras NVoadoras = new AvesNaoVoadoras();

      Aves.Especie = "pinguim";
      Aves.Id= 7;
      Aves.Nome = "Duque";
Console.WriteLine($"O nome do animal é: {Aves.Nome}");
Console.WriteLine($"A especie do animal é: {Aves.Especie}");
Console.WriteLine($"O idade do animal é: {Aves.Id}");
NVoadoras.Voar();
Console.WriteLine(" ");

     Aves.Especie = "papagaio";
     Aves.Id= 12 ;
     Aves.Nome = "Aufredo";
Console.WriteLine($"O nome do animal é: {Aves.Nome}");
Console.WriteLine($"A especie do animal é: {Aves.Especie}");
Console.WriteLine($"O idade do animal é: {Aves.Id}");
Aves.Voar();
Console.WriteLine(" ");

     Aves.Especie = "aguia";
     Aves.Id= 5;
     Aves.Nome = "Milania";
Console.WriteLine($"O nome do animal é: {Aves.Nome}");
Console.WriteLine($"O peso do animal é: {Aves.Especie}");
Console.WriteLine($"A idade do animal é: {Aves.Id}");
Aves.Voar();