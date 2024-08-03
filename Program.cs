using System.Reflection.Metadata;
using Trilha_C_.Models; 




int quantidadeEmEstoque = 10;
 int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;



Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
Console.WriteLine($"é possivel realizar a venda? {possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("Venda Realizada");

}
else
{
    Console.WriteLine("Desculpe,não temos a quantidade desejada!");
}







// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual);










// Pessoa p = new Pessoa(); 

// p.Nome = "Yuri";
// p.Idade = 30;
// p.Apresentar();
