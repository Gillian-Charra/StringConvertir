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
        [InlineData(30)]
        [InlineData(4)]
        [InlineData(14)]
        [InlineData(24)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]
        [InlineData(25)]
        [InlineData(26)]
        [InlineData(27)]
        [InlineData(28)]
        [InlineData(9)]
        [InlineData(19)]
        [InlineData(29)]
        public void TestUnites0a3puis10a13et20a23(int n)
        {
            int DizaineArabe = 0;
            if (n.ToString().Length >= 2)
            {
                DizaineArabe = Int32.Parse(n.ToString()[n.ToString().Length - 2].ToString());
            }
            int UniteArabe = Int32.Parse(n.ToString()[n.ToString().Length - 1].ToString());
            var resultat = ConvertisseurNombresRomains.Convertir(n);
            var attendu = new string('X', DizaineArabe);
            switch (UniteArabe)
            {
                case <=3:
                    attendu+=new string('I', UniteArabe);
                    break;
                case 4:
                    attendu += "IV";
                    break;
                case <= 8:
                    attendu += "V" + new string('I', UniteArabe - 5);
                    break;
                case 9:
                    attendu += "IX";
                    break;
            }

            Assert.Equal(attendu, resultat);
        }
    }
}