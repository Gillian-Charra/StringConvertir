namespace GILLIAN_nombreromain.test
{
    public class NombresRomainsTest
    {
        [Theory]
        [InlineData(0)]
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
        [InlineData(8)]

        public void TestUnites5a8(int n)
        {
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attend = "V" + new string('I', n - 5);
            Assert.Equal(attend, resultat);
        }
        [Fact]
        public void TestUnites9()
        {
            const int n = 9;
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attendu = "IX";
            Assert.Equal(attendu, resultat);
        }
        [Theory]
        [InlineData(10)]
        public void TestUnites10(int n)
        {
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attendu = "X"+new string('I', n-10);
            Assert.Equal(attendu, resultat);
        }
    }
}