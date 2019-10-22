using System.Threading;
using OpenQA.Selenium;
using System;

namespace GloboChallenge.Pages
{
    public class RegisterPage : BasePage
    {
        public By registerName = By.Name("first_name");
        public By registerLastName = By.Name("last_name");
        public By registerNickName = By.Name("como_gostaria_de_ser_chamado");
        public By sexo = By.Name("sexo");
        public By email = By.Name("username");
        public By office = By.Name("cargo");
        public By editoria = By.Name("editoria");
        public By vehicle = By.Name("veiculo");
        public By country = By.Name("pais");
        public By city = By.Name("cidade");
        public By ddd_telephone = By.Name("telefone_ddd");
        public By telephone = By.Name("telefone_numero");
        public By ddd_cell_phone = By.Name("celular_ddd");
        public By cell_phone = By.Name("celular_numero");
        public By password = By.Name("password1");
        public By password_confirmation = By.Name("password2");
        public By button_accept_terms = By.Name("termos");
        public By button_request_registration = By.XPath("//*[text()='SOLICITAR CADASTRO']");
        public By validate_message_error_email = By.XPath("//*[@id='form - create']/div[1]/div[6]/ul/li");


        public void ToWriteName()
        {
            //Thread.Sleep(5000);
            ToWrite(registerName, "teste");
        }
        public void ToWriteLastName()
        {
            ToWrite(registerLastName, "testing");
        }
        public void ToWriteNickName()
        {
            ToWrite(registerNickName, "test");
        }
        public void ToSelectSexo()
        {
            //Thread.Sleep(4000);
            ToSelectByText(sexo, "Masculino");
        }
        public void ToWriteEmail()
        {
            ToWrite(email, "teste5@teste.com");
        }
        public void ToSelectOffice()
        {
            //Thread.Sleep(4000);
            ToSelectByText(office, "Estagiário");
        }
        public void ToSelectEditoria()
        {
            //Thread.Sleep(7000);
            ToSelectByText(editoria, "Tecnologia");
        }
        public void ToWriteVehicle()
        {
            ToWrite(vehicle, "Veículo 1");
        }
        public void ToWriteCountry()
        {
            ToWrite(country, "Brasil");
        }
        public void ToWriteCity()
        {
            ToWrite(city, "Rio de Janeiro");
        }
        public void ToWriteDDDTel()
        {
            ToWrite(ddd_telephone, "21");
        }
        public void ToWriteTel()
        {
            ToWrite(telephone, "33423576");
        }
        public void ToWriteDDDCel()
        {
            ToWrite(ddd_cell_phone, "21");
        }
        public void ToWriteCel()
        {
            ToWrite(cell_phone, "994609999");
        }
        public void ToWritePassword()
        {
            ToWrite(password, "Globo@2019");
        }
        public void ToWritePasswordConfirmation()
        {
            ToWrite(password_confirmation, "Globo@2019");
        }
        public void ToClickButtonAcceptTerms()
        {
            //Thread.Sleep(3000);
            ToClick(button_accept_terms);
        }
        public void ToClickButtonRequestRegistration()
        {
            //Thread.Sleep(3000);
            ToClick(button_request_registration);
        }
        public void ToValidateMessageErrorRegistration()
        {
            //Thread.Sleep(3000);
            //GetText(validate_message_error_email);
            Console.WriteLine(validate_message_error_email);
            Equals(validate_message_error_email, "Já existe um cadastro com este e-mail.");
        }
    }
}
