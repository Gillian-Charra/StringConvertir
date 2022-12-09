namespace GILLIAN_nombreromain.test
{
    public class NombresRomainsTest
    {
        [Fact]
        public void Test1()
        {
            const int nombreArabe = 1;

            var resultat=ConvertisseurNombresRomains.Convertir(nombreArabe);

            Assert.Equal("I",resultat);
        }
    }
}