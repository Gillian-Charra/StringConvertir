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
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(20)]
        public void TestUnites10a13et20(int n)
        {
            int DizaineArabe = Int32.Parse(n.ToString()[n.ToString().Length - 2].ToString());
            int UniteArabe = Int32.Parse(n.ToString()[n.ToString().Length - 1].ToString());
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attendu = new string('X', DizaineArabe) + new string('I', UniteArabe);
            Assert.Equal(attendu, resultat);
        }
        [Fact]
        public void TestUnites14()
        {
            const int n = 14;
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attendu = "XIV";
            Assert.Equal(attendu, resultat);
        }
        [Theory]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]

        public void TestUnites15a18(int n)
        {
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attend = "XV" + new string('I', n - 15);
            Assert.Equal(attend, resultat);
        }
        [Fact]
        public void TestUnites19()
        {
            const int n = 19;
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attendu = "XIX";
            Assert.Equal(attendu, resultat);
        }
    }
}