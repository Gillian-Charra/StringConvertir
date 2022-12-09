namespace GILLIAN_nombreromain
{
    public class ConvertisseurNombresRomains
    {
        public static char[,] SIGNES =
        {
            {'I','V'},
            {'X','L'}
        };
        public static string Convertir(int nombreArabe)
        {
            string nombreRomain = "";
            string chiffreRomain = "";
            for (int i = 0; i < nombreArabe.ToString().Length; i++)
            {
                int chiffreSelectionne = Int32.Parse(nombreArabe.ToString()[nombreArabe.ToString().Length-i-1].ToString());
                switch (chiffreSelectionne)
                {
                    case 0:
                        chiffreRomain = "";
                        break;
                    case <= 3:
                        chiffreRomain = new string(SIGNES[i, 0], chiffreSelectionne);
                        break;
                    case 4:
                        chiffreRomain = new string(SIGNES[i, 0].ToString() + SIGNES[i, 1]);
                        break;
                    case <= 8:
                        chiffreRomain = SIGNES[i, 1] + new string(SIGNES[i, 0], chiffreSelectionne - 5);
                        break;
                    case 9:
                        chiffreRomain = new string(SIGNES[i, 0].ToString() + SIGNES[i + 1, 0]);
                        break;
                };
                nombreRomain =chiffreRomain+ nombreRomain;
            }
            return nombreRomain;
        }
    }
}