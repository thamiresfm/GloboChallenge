using GloboChallenge.Pages;
using System;
using TechTalk.SpecFlow;

namespace GloboChallenge.Challenge.Features
{
    [Binding]
    public class ErrorRegisterSteps : BasePage
    {
        public RegisterPage RegisterPage { get; private set; }

        public ErrorRegisterSteps()
        {
            RegisterPage = new RegisterPage();

        }

        [Then(@"vejo a mensagem de que não foi possível se cadastrar com sucesso")]
        public void EntaoVejoAMensagemDeQueNaoFoiPossivelSeCadastrarComSucesso()
        {
            RegisterPage.ToValidateMessageErrorRegistration();
        }
    }
}
