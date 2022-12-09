namespace GILLIAN_nombreromain.test
{
    public class NombresRomainsTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestUnites1a3(int n)
        {
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attendu = new string('I', n);
            Assert.Equal(attendu, resultat);
        }
        [Fact]
        public void TestUnites4()
        {
            const int n = 4;
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attendu = "IV";
            Assert.Equal(attendu, resultat);
        }
    }
}