using códigos.Models;

int[] arrayInt = new int[3];
int [] arrayInt2 = new int[arrayInt.Length * 2];

arrayInt[0] = 10;
arrayInt[1] = 20;
arrayInt[2] = 30;

Console.WriteLine("**Percorrendo com FOREACH**");
foreach(int ValoresDoArray in arrayInt){
    Console.WriteLine(ValoresDoArray);
}

Console.WriteLine("**Percorrendo com FOR**");
for(int i = 0; i < arrayInt.Length; i++){
    Console.WriteLine(arrayInt[i]);
}

Console.WriteLine("**Redimensionar tamanho de array**");
Console.WriteLine($"Tamanho antigo: {arrayInt.Length}");
Array.Resize(ref arrayInt, arrayInt.Length * 2);
Console.WriteLine($"Tamanho novo: {arrayInt.Length}");

Console.WriteLine("**Copiando um Array para outro**");
Array.Copy(arrayInt, arrayInt2, arrayInt.Length);
foreach(int ValoresDoArray in arrayInt2){
    Console.WriteLine(ValoresDoArray);
}

Console.WriteLine("**Trabalhando com listas**");
List<string> ListaNomes = new List<string>();
ListaNomes.Add("Silas");
ListaNomes.Add("Tayna");
ListaNomes.Add("Olívia");

Console.WriteLine($"Nomes na Lista: {ListaNomes.Count} - Capacidade: {ListaNomes.Capacity}");

ListaNomes.Remove("Olívia");

Console.WriteLine($"Nomes na Lista: {ListaNomes.Count} - Capacidade: {ListaNomes.Capacity}");
