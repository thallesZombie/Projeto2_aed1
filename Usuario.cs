using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Usuario{

  protected  string email;
  protected string nome;
  protected string cep;
  protected string senha;
  
  public string getEmail(){
    return email;
  }

  public string getNome(){
    return nome;
  }

  public void setEmail(string e){
    email = e;
  }

  public void setNome(string n){
    nome = n;
  }

  public string getCep(){
    return cep;
  }

  public void setCep(string cp){
    cep = cp;
  }

  public string getSenha(){
    return senha;
  }
 
  public void setSenha(string s){
    senha = s;
  }

  public Usuario(){

    nome = "Nome";
    email = "Email";
    cep = "dfaf";
    senha = "9erwr3";
  }

  public Usuario( string n ,string e , string cp,string s){
    
    nome = n;
    email = e;
    cep = cp;
    senha = s;
  }

}