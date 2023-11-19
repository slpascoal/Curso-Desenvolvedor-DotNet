using códigos.Models;

Console.WriteLine("** Comentário de única linha **"); 
// comentário
Console.WriteLine("** Comentário de várias linhas **"); 
/*
    Comentário 1
    Comentário 2
*/
Console.WriteLine("** Comentando nossas classes <summary> **");
/// <summary>
/// Váriavel de número inteiro
/// </summary> 
public class inteiros{
    public int inteiro { get; set; }

/// <summary>
/// Método de soma
/// </summary>
/// <param name="x">O primeiro número da soma</param>
/// <param name="y">O segundo número da soma</param>
    public void Soma(int x, int y){
        Console.WriteLine(x + y);
    }
}