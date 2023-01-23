using Chapter.WebApi.Controllers;
using Chapter.WebApi.Models;
using Chapter.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace TesteIntegracao
{
    public class LoginControllerTeste
    {
        [Fact]
        public void LoginController_Retornar_Usuario_Invalido()
        {
            //Arrange - Prepara��o
            var repositoryEspelhado = new Mock<IUsuarioRepository>();

            repositoryEspelhado.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns((Usuario)null);

            var controller = new LoginController(repositoryEspelhado.Object);

            LoginViewModel dadosUsuario = new LoginViewModel();
            dadosUsuario.email = "joao@email.com";
            dadosUsuario.senha = "1234";

            //Act - A��o

            var resultado = controller.Login(dadosUsuario);


            //Assert - Verifica��o
            Assert.IsType<UnauthorizedObjectResult>(resultado);

        }

        [Fact]

        public void LoginController_Retornar_Token()
        {
            //Arrange - Prepara��o

            Usuario usuarioRetornado = new Usuario();
            usuarioRetornado.Email = "email@email.com";
            usuarioRetornado.Senha = "1234";
            usuarioRetornado.Tipo = "0";
            usuarioRetornado.id = 1;

            var repositoryEspelhado = new Mock<IUsuarioRepository>();

            repositoryEspelhado.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns(usuarioRetornado);

            LoginViewModel dadosUsuario = new LoginViewModel();
            dadosUsuario.email = "joao@email.com";
            dadosUsuario.senha = "1234";

            var controller = new LoginController(repositoryEspelhado.Object);
            string issuervalido = "chapter.webapi";

            //Act - A��o

           OkObjectResult resultado = (OkObjectResult)controller.Login(dadosUsuario);

           string tokenString = resultado.Value.ToString().Split(' ')[3];

           var jwtHandler = new JwtSecurityTokenHandler();

           var tokenJwt = jwtHandler.ReadJwtToken(tokenString);


            //Assert - Verifica��o
            Assert.Equal(issuervalido, tokenJwt.Issuer);


        }

    }
}