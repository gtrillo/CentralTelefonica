using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralTelefonica;
namespace Pruebas
{
    [TestClass]
    public class CentralitaTest
    {
        [TestMethod]
        public void Centralita_ValidarQueLaListaEsteInstanciadaAlCrearUnObjetoCentralita_NoDeberiaRetornarNull()
        {
            //Arrange el caso de prueba
            
            object resultado = 0;
            //Act -- Invocar el metodo a probar
            Centralita centralita = new Centralita("Pruebita");
            //Assert - verifico que el resultado sea el esperado
            Assert.AreEqual(centralita.Llamadas.Count, resultado);
        }
    }
}
    