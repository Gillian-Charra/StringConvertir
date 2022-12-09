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
        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void TestUnites5a7(int n)
        {
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attend = "V" + new string('I', n - 5);
            Assert.Equal(attend, resultat);
        }
    }
}