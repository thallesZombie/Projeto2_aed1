using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class HistoricoJuridico{

  public string email{get;set;}
  public int   quantidade{get;set;}
  public int  id{get;set;}

  List<HistoricoJuridico> historicojuridico
   = new List<HistoricoJuridico>();

  public  HistoricoJuridico(){
    email = "4444";
    quantidade = 0;
    id = 0;
  
  }
  
  public HistoricoJuridico(string e, int q, int i){
    email = e;
    quantidade =q;
    id = i;
  }

 


  public  void ColocandoNoHistorico2(string e, int q, int i ){
   
    StreamWriter streamWriter = File.AppendText("HistoricoJuridico.txt");
    streamWriter.WriteLine(e+";" + q + ";" + i );
    streamWriter.Close();

  }
   
  private void AtualizarHistorico2(){
    
    string[] linhas = File.ReadAllLines
    
    ("HistoricoJuridico.txt");
      

    historicojuridico.Clear();
    
    foreach(string linha in linhas){
  
      string[] dados = linha.Split(";");
    
      HistoricoJuridico hj= new HistoricoJuridico(dados[0],Int16.Parse(dados[1]),Int16.Parse(dados[2]));
      historicojuridico.Add(hj);
        
      }
  } 


  public void  MostrarHistorico2(string email){
    
    AtualizarHistorico2();
    
    foreach(HistoricoJuridico   h in historicojuridico){
      if ( email == h.email){
           Console.WriteLine("Você comprou: {0} produtos , com id{1}",h.id,h.quantidade);
        
      }
    
      }

    } 

  }
  


