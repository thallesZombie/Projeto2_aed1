using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class  Fisico : Usuario{

  List<Usuario> usuarios = new List<Usuario>();

  private string cpf;

  public Fisico(){
    cpf = "CPF";   
  }
  
  public Fisico(string n ,string e , string cp,string s,string c ): base(n,e,cp,s){
    cpf = c;
  }

  
  public string getCPF(){
    return cpf;
  }

  public void setCPF(string c){
    cpf = c;
  }

  public bool  VerificarCadastro(string email){
  
    AtualizarLista();
  
    foreach(Usuario  u in usuarios){
      if ( email == u.getEmail() ){

      return false;
      }
    } 
    return true;
  }
  
  public static int qtdLinhas(){
    FileStream  leiturarqvoluntario= new FileStream
    ("PessoaFisica.txt",FileMode.Open,FileAccess.Read);

    StreamReader lerinfobasic =new StreamReader(leiturarqvoluntario,Encoding.UTF8);

    int id = 1;

    while(!lerinfobasic.EndOfStream){
      lerinfobasic.ReadLine();
      id++;
    } 

    lerinfobasic.Close();
    leiturarqvoluntario.Close();
    return id;

  }


  public  void CadastroUsuarioFisico(string n, string e ,string  cp, string  s, string cf ){
      int id = qtdLinhas();

      if (VerificarCadastro(email)){
  
      StreamWriter streamWriter = File.AppendText("PessoaFisica.txt");
      streamWriter.WriteLine(n +";" + e  + ";" + id + ';' + cp +';'+s +';'+cf );
      streamWriter.Close();
      }
      else{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Esse email já foi cadastrado!!");
      } 
  } 

  private void AtualizarLista(){
    
    string[] linhas = File.ReadAllLines
    
    ("PessoaFisica.txt");
  
    usuarios.Clear();
   
    foreach(string linha in linhas){
 
      string[] dados = linha.Split(";");
     
      Fisico usuario = new Fisico(dados[0],dados[1],dados[2], dados[3] , dados[4]);
      usuarios.Add(usuario);   
    }
  } 

  public bool Login( string email, string senha){
      
    AtualizarLista();
    
    foreach(Usuario  u in usuarios){
      if ( email == u.getEmail() && senha == u.getSenha() ){
        Console.WriteLine("Seja bem vindo!!!, "+u.getNome());
        return true;
      }
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Essa senha ou email não são cadastrados no nosso sistema:\nTente novamente!!!");
    Console.ForegroundColor = ConsoleColor.White;
    return false;
  }

}