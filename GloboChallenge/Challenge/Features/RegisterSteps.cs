using GloboChallenge.Pages;
using System.Configuration;
using TechTalk.SpecFlow;

namespace GloboChallenge.Challenge.Features
{
    [Binding]
    public class RegisterSteps : BasePage
    {
        

        public HomePage HomePage { get; private set; }
        public RegisterPage RegisterPage { get; private set; }

        public RegisterSteps()
        {
            HomePage = new HomePage();
            RegisterPage = new RegisterPage();

    }

    [Given(@"que eu navegue para a tela Home")]
        public void DadoQueEuNavegueParaATelaHome()
        {
            
            HomePage.GoTo(ConfigurationManager.AppSettings["globoHome"]);
        }
        
        [When(@"clico em Novo Cadastro")]
        public void QuandoClicoEmNovoCadastro()
        {
            HomePage.ToClickButtonNovoCadastro();
        }
        
        [When(@"preencho os dados")]
        public void QuandoPreenchoOsDados()
        {
            RegisterPage.ToWriteName();
            RegisterPage.ToWriteLastName();
            RegisterPage.ToWriteNickName();
            RegisterPage.ToSelectSexo();
            RegisterPage.ToWriteEmail();
            RegisterPage.ToSelectOffice();
            RegisterPage.ToSelectEditoria();
            RegisterPage.ToWriteVehicle();
            RegisterPage.ToWriteCountry();
            RegisterPage.ToWriteCity();
            RegisterPage.ToWriteDDDTel();
            RegisterPage.ToWriteTel();
            RegisterPage.ToWriteDDDCel();
            RegisterPage.ToWriteCel();
            RegisterPage.ToWritePassword();
            RegisterPage.ToWritePasswordConfirmation();
            RegisterPage.ToClickButtonAcceptTerms();
            RegisterPage.ToClickButtonRequestRegistration();
            
        }
        
        [Then(@"vejo a mensagem de cadastrado com sucesso")]
        public void EntaoVejoAMensagemDeCadastradoComSucesso()
        {
            HomePage.ToValidateMessageRegistration();
        }
    }
}
