using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class HistoricoFisico{

  public string email{get;set;}
  public int   quantidade{get;set;}
  public int  id{get;set;}

  List<HistoricoFisico> historicofisico
   = new List<HistoricoFisico>();

  public  HistoricoFisico(){
    email = "4444";
    quantidade = 0;
    id = 0;
  
  }
  
  public HistoricoFisico(string e, int q, int i){
    email = e;
    quantidade =q;
    id = i;
  }

 


  public  void ColocandoNoHistorico(string e, int q, int i ){
   
    StreamWriter streamWriter = File.AppendText("HistoricoFisico.txt");
    streamWriter.WriteLine(e+";" + q + ";" + i );
    streamWriter.Close();

  }
   
  private void AtualizarHistorico(){
    
    string[] linhas = File.ReadAllLines
    
    ("HistoricoFisico.txt");
      

    historicofisico.Clear();
    
    foreach(string linha in linhas){
  
      string[] dados = linha.Split(";");
    
      HistoricoFisico hf= new HistoricoFisico(dados[0],Int16.Parse(dados[1]),Int16.Parse(dados[2]));
      historicofisico.Add(hf);
        
      }
  } 


  public void  MostrarHistorico(string email){
    
    AtualizarHistorico();
    
    foreach(HistoricoFisico   h in historicofisico){
      if ( email == h.email){
        Console.WriteLine("Você comprou: {0} produtos , com id{1}",h.id,h.quantidade);
        
      }
    } 
  }
}