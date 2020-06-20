 using System;
using System.IO;
using System.Text;

class MainClass {
   
  public static void Main (string[] args) {
    int  entradaUsuario = 0;
    bool verifica = true;
    string entrada = null;
    int sair = 1;
    
    while(sair != 0 ){
      

        Console.WriteLine(" Para entrar no nosso sistema: \n Informe se você é uma pessoa fisica ou uma pessoa juridica:");

        
        Console.WriteLine(" Digite 1 para Pessoa fisica:\n =============================\n Digite 2 para Pessoa Juridico:");
 
        entrada = Console.ReadLine();
        //Tratar a entrada inicial
        verifica = digitosCertos(entrada);
        entradaUsuario = int.Parse(entrada);

        
        

        int opcao = 0;
        
   
       HistoricoFisico historicoFisico = new HistoricoFisico();

       HistoricoJuridico historicoJuridico = new HistoricoJuridico();


      try{
        Console.WriteLine("ok");
        
        if (verifica == false){
           throw new Exception("Nome inválido!**");
           Console.WriteLine("ok");
          
      }else{
        switch (entradaUsuario){

      case 1: 
      Console.WriteLine("Digite 0 para volta:");

      Console.WriteLine("Digite 1 para fazer um cadastro no nosso Sistema:\nDigite 2 se você já é cadastrado:");
      opcao = int.Parse(Console.ReadLine());
      if (opcao == 1){


         Console.WriteLine("Digite seu nome para cadastro:");
         string nome  = (Console.ReadLine());

         Console.WriteLine("Digite seu email para cadastro:");
         string  email = (Console.ReadLine());
      
         Console.WriteLine("Digite seu cep:");
         string  cep = (Console.ReadLine());

         Console.WriteLine("Digite sua senha para cadastrar:");
         string  senha  = (Console.ReadLine());

         Console.WriteLine("Digite sua cpf para cadastrar:");
         string  cpf  = (Console.ReadLine());


      
         Fisico  usuario = new Fisico(nome,email,cep,senha,cpf);

         usuario.CadastroUsuarioFisico(nome, email,cep,senha,cpf);
         Console.ForegroundColor = ConsoleColor.White; 
      break;
        }
        if(opcao == 2){

        Console.WriteLine("Digite 1 para comprar\n Digite 2 para olhar seu historico:");
        int opcaoUsuarioF = int.Parse(Console.ReadLine());

        Fisico  usuario = new Fisico();

        Console.WriteLine("Digite seu email:");
        string  email = (Console.ReadLine());

        Console.WriteLine("Digite sua senha:");
        string  senha = (Console.ReadLine());

        Console.WriteLine();

        if(usuario.Login(email,senha)){

        int opcaoUsuario = 0;

        Console.WriteLine();

       
        if(opcaoUsuarioF == 1){

          Loja loja = new Loja();

          Console.WriteLine("Esse são todos os nossos produtos para venda:");

          loja.MostrarProduto();
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine();

          Console.WriteLine("Digite o ID do produto que você deseja comprar:");
          int   id  = int.Parse(Console.ReadLine());
        
          if(loja.BuscarPorID(id)){
       
          Console.WriteLine();
          Console.WriteLine("Agora que você escolheu o seu ID, coloque a quantidade de produtos que você quer comprar:");
          int   quantidade = int.Parse(Console.ReadLine());

          historicoFisico.ColocandoNoHistorico(email,id,quantidade);

          loja.ComprarProduto(id,quantidade);
          Console.WriteLine("Se deseja comprar mais produto, digite aperte o s");
          string  desejacompra = Console.ReadLine();

          string desejacompra1 ="";

          while(desejacompra == "s"|| desejacompra1 == "s"){
               
            if(desejacompra == "s"){
        
            Console.WriteLine("Digite o ID do produto que você deseja comprar:");
            int   id1  = int.Parse(Console.ReadLine());
            
            if(loja.BuscarPorID(id1)){
        
            Console.WriteLine("Agora que você escolheu o seu ID, coloque a quantidade de produtos que você quer comprar:");
            int   quantidade1 = int.Parse(Console.ReadLine());

            loja.ComprarProduto(id1,quantidade1);

            historicoFisico.ColocandoNoHistorico(email,id1,quantidade1); 
            }
          }
          if(desejacompra != "s"){
              break;
          }

          Console.WriteLine("Se deseja comprar mais produto, digite aperte o s");
          desejacompra1 = Console.ReadLine();

          if(desejacompra1 != "s"){
            break;
            }
        }

        }
        else{
          Console.WriteLine("ID errado, tente novamente!!!");
        } 
      
        }
        if(opcaoUsuarioF == 2){
          HistoricoFisico historico = new HistoricoFisico();
          Console.WriteLine("Esse é todo o seu historico em nossa loja");
          historico.MostrarHistorico(email);

        }
        if(opcaoUsuario == 89){
          break;
        }
        }  
      }  


       

       
      break;
/* //////////////*/
      case 2:
        Console.WriteLine("Digite 3 para fazer um cadastro no nosso Sistema:\nDigite 4 se você já é cadastrado:");
      opcao = int.Parse(Console.ReadLine());
        if(opcao == 2){

        Console.WriteLine("Digite 1 para comprar\n Digite 2 para olhar seu historico:");
        int opcaoUsuarioF = int.Parse(Console.ReadLine());

        Fisico  usuario = new Fisico();

        Console.WriteLine("Digite seu email:");
        string  email = (Console.ReadLine());

        Console.WriteLine("Digite sua senha:");
        string  senha = (Console.ReadLine());

        Console.WriteLine();

        if(usuario.Login(email,senha)){

        int opcaoUsuario = 0;

        Console.WriteLine();

       
        if(opcaoUsuarioF == 1){

          Loja loja = new Loja();

          Console.WriteLine("Esse são todos os nossos produtos para venda:");

          loja.MostrarProduto();
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine();

          Console.WriteLine("Digite o ID do produto que você deseja comprar:");
          int   id  = int.Parse(Console.ReadLine());
        
          if(loja.BuscarPorID(id)){
       
          Console.WriteLine();
          Console.WriteLine("Agora que você escolheu o seu ID, coloque a quantidade de produtos que você quer comprar:");
          int   quantidade = int.Parse(Console.ReadLine());

          historicoFisico.ColocandoNoHistorico(email,id,quantidade);

          loja.ComprarProduto(id,quantidade);
          Console.WriteLine("Se deseja comprar mais produto, digite aperte o s");
          string  desejacompra = Console.ReadLine();

          string desejacompra1 ="";

          while(desejacompra == "s"|| desejacompra1 == "s"){
               
            if(desejacompra == "s"){
        
            Console.WriteLine("Digite o ID do produto que você deseja comprar:");
            int   id1  = int.Parse(Console.ReadLine());
            
            if(loja.BuscarPorID(id1)){
        
            Console.WriteLine("Agora que você escolheu o seu ID, coloque a quantidade de produtos que você quer comprar:");
            int   quantidade1 = int.Parse(Console.ReadLine());

            loja.ComprarProduto(id1,quantidade1);

            historicoFisico.ColocandoNoHistorico(email,id1,quantidade1); 
            }
          }
          if(desejacompra != "s"){
              break;
          }

          Console.WriteLine("Se deseja comprar mais produto, digite aperte o s");
          desejacompra1 = Console.ReadLine();

          if(desejacompra1 != "s"){
            break;
            }
        }

        }
        else{
          Console.WriteLine("ID errado, tente novamente!!!");
        } 
      
        }
        if(opcaoUsuarioF == 2){
          HistoricoFisico historico = new HistoricoFisico();
          Console.WriteLine("Esse é todo o seu historico em nossa loja");
          historico.MostrarHistorico(email);

        }
        if(opcaoUsuario == 89){
          break;
        }
        }  
      }
      if(opcao == 3){

      Console.WriteLine("Digite seu nome para cadastro:");
      string nomeJ  = (Console.ReadLine());

      Console.WriteLine("Digite seu email para cadastro:");
      string  emailJ = (Console.ReadLine());
      
      Console.WriteLine("Digite seu cep:");
      string  cepJ = (Console.ReadLine());

      Console.WriteLine("Digite sua senha para cadastrar:");
      string  senhaJ  = (Console.ReadLine());

      Console.WriteLine("Digite sua cnpj para cadastrar:");
      string  cnpj  = (Console.ReadLine());
      
      Juridico  usuarioJ = new Juridico(nomeJ,emailJ,cepJ,senhaJ,cnpj);

      usuarioJ.CadastroUsuarioJuridico2(nomeJ, emailJ,cepJ,senhaJ,cnpj);
      Console.ForegroundColor = ConsoleColor.White; 
      break;
      }

      if(opcao == 4){
        Console.WriteLine("Digite 1 para comprar\n Digite 2 para olhar seu historico:");
        int opcaoUsuarioJ = int.Parse(Console.ReadLine());

        Juridico  usuarioJ = new Juridico();

        Console.WriteLine("Digite seu email:");
        string  emailJ = (Console.ReadLine());

        Console.WriteLine("Digite sua senha:");
        string  senhaJ= (Console.ReadLine());

        Console.WriteLine();

        if(usuarioJ.Login2(emailJ,senhaJ)){

        int opcaoUsuario = 0;

        Console.WriteLine();

       
        if(opcaoUsuarioJ == 1){

          Loja lojaJ = new Loja();

          Console.WriteLine("Esse são todos os nossos produtos para venda:");

          lojaJ.MostrarProduto();
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine();

          Console.WriteLine("Digite o ID do produto que você deseja comprar:");
          int   idJ  = int.Parse(Console.ReadLine());
        
          if(lojaJ.BuscarPorID(idJ)){
       
          Console.WriteLine();
          Console.WriteLine("Agora que você escolheu o seu ID, coloque a quantidade de produtos que você quer comprar:");
          int   quantidadeJ = int.Parse(Console.ReadLine());

          historicoJuridico.ColocandoNoHistorico2(emailJ,idJ,quantidadeJ);

          lojaJ.ComprarProduto(idJ,quantidadeJ);

          Console.WriteLine("Se deseja comprar mais produto, digite aperte o s");
          string  desejacompraJ = Console.ReadLine();

          string desejacompraJ2 ="";
        

          while(desejacompraJ == "s"){
               
            if(desejacompraJ2 == "s"){
             
            Console.WriteLine("Digite o ID do produto que você deseja comprar:");
            int   idJ1  = int.Parse(Console.ReadLine());
            
            if(lojaJ.BuscarPorID(idJ1)){
        
            Console.WriteLine("Agora que você escolheu o seu ID, coloque a quantidade de produtos que você quer comprar:");
            int   quantidadeJ1 = int.Parse(Console.ReadLine());

            lojaJ.ComprarProduto(idJ1,quantidadeJ1);

            historicoJuridico.ColocandoNoHistorico2(emailJ,idJ1,quantidadeJ1); 
            }
          }
          if(desejacompraJ != "s"){
              break;
          }

          Console.WriteLine("Se deseja comprar mais produto, digite aperte o s");
          desejacompraJ2 = Console.ReadLine();

          if(desejacompraJ2 != "s"){
            break;
            }
        }

        }
        else{
          Console.WriteLine("ID errado, tente novamente!!!");
        } 
      
        }
        if(opcaoUsuarioJ == 2){
          HistoricoJuridico historicoJ = new HistoricoJuridico();
          Console.WriteLine("Esse é todo o seu historico em nossa loja");
          historicoJ.MostrarHistorico2(emailJ);

        }
        if(opcaoUsuarioJ == 89){
          break;
        }
        }  
      }

      break;


  
      if(opcao == 89){
          break;
          Console.WriteLine("Obrigado por visitar o nosso site!!!");
      }  

      


        
      if(opcao == 0){
          break;
          Console.WriteLine("Obrigado por visitar o nosso site!!!");
      }  


          }
        
        }


        }
       

      catch(Exception){

        Console.WriteLine("Nome inválido!");
        continue;

      }


      
     }
  }
    public static bool digitosCertos(string entrada){
    char primeiroCaracter = entrada[0];
    int codigo = Convert.ToInt32(primeiroCaracter );
    if(codigo < 48 || codigo > 51 || entrada.Length > 1){
      Console.WriteLine("Opção inválida");
      Console.WriteLine("Digite uma opção correta ou 0 volta");
      System.Threading.Thread.Sleep(TimeSpan.FromSeconds(4));
      Console.Clear();
      return false;
    }
    
    return true;  
  }
 }
 
 
  

 