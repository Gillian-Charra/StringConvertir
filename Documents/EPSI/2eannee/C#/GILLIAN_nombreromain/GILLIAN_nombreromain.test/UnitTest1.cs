namespace GILLIAN_nombreromain.test
{
    public class NombresRomainsTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(20)]
        [InlineData(21)]
        [InlineData(22)]
        [InlineData(23)]
        public void TestUnites0a3puis10a13et20a23(int n)
        {
            int DizaineArabe = 0;
            if (n.ToString().Length >= 2)
            {
                DizaineArabe = Int32.Parse(n.ToString()[n.ToString().Length - 2].ToString());
            }
            int UniteArabe = Int32.Parse(n.ToString()[n.ToString().Length - 1].ToString());
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attendu = new string('X', DizaineArabe) + new string('I', UniteArabe);
            Assert.Equal(attendu, resultat);
        }
        [Theory]
        [InlineData(4)]
        [InlineData(14)]
        [InlineData(24)]
        public void TestUnites4puis14et24(int n)
        {
            int DizaineArabe = 0;
            if (n.ToString().Length >= 2)
            {
                DizaineArabe = Int32.Parse(n.ToString()[n.ToString().Length - 2].ToString());
            }
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attendu = new string('X', DizaineArabe)+"IV";
            Assert.Equal(attendu, resultat);
        }
        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]

        public void TestUnites15a18(int n)
        {
            int DizaineArabe = 0;
            if (n.ToString().Length >= 2)
            {
                DizaineArabe = Int32.Parse(n.ToString()[n.ToString().Length - 2].ToString());
            }
            int UniteArabe = Int32.Parse(n.ToString()[n.ToString().Length - 1].ToString());
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attend = new string('X', DizaineArabe)+"V" + new string('I', UniteArabe - 5);
            Assert.Equal(attend, resultat);
        }
        [Theory]
        [InlineData(9)]
        [InlineData(19)]
        public void TestUnites19(int n)
        {
            int DizaineArabe = 0;
            if (n.ToString().Length >= 2)
            {
                DizaineArabe = Int32.Parse(n.ToString()[n.ToString().Length - 2].ToString());
            }
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attendu =  new string('X', DizaineArabe)+"IX";
            Assert.Equal(attendu, resultat);
        }
    }
}