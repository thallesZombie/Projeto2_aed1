using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class Loja{
   
  List<Produto> produtos = new List<Produto>();
  
  private void CarregarProduto(){

    string[] linhas = File.ReadAllLines("produtoparavenda.txt");
    
    foreach(string linha in linhas){
      string[] dados = linha.Split(";");
      Produto p = new Produto(dados[0], float.Parse(dados[1]), Int16.Parse(dados[2]),Int16.Parse(dados[3]));
      produtos.Add(p); 
    }  
  }

  public void MostrarProduto(){
    CarregarProduto();
    foreach(Produto p in produtos){
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(p.ToString());
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("============================");
      Console.ForegroundColor = ConsoleColor.White;

    }
  }

  public bool BuscarPorID(int id ){
     foreach(Produto p in produtos){
      if ( id == p.getId() ){
        Console.WriteLine(p.ToString());
        return true; 
      }
        
    } 
      return false;
  }

  public void ComprarProduto( int id  ,int quantidade){
    
    foreach(Produto p in produtos){
      if ( id == p.getId()){
        p.setQuantidade(p.getQuantidade()-quantidade);
        SalvarTxt();
      }
    }
  }

  public void SalvarTxt(){
      
    List <string> ListaProArquivo = new List<string>();

    foreach (Produto linha in produtos){
        ListaProArquivo.Add(linha.getNome() + ";" +linha.getValor() + ";" + linha.getQuantidade() + ";" + linha.getId());
    }

    File.WriteAllLines("produtoparavenda.txt",ListaProArquivo);  
  }

  public void ValorCompra( int id  ,int quantidade){
     
    foreach(Produto p in produtos){
      if ( id == p.getId()){
        float valorcompra =(quantidade*p.getValor());
        Console.WriteLine(valorcompra);
      }
    }
  }

}

