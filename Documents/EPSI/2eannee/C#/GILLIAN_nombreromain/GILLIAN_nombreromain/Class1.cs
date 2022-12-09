namespace GILLIAN_nombreromain
{
    public class ConvertisseurNombresRomains
    {
        public static string Convertir(int nombreArabe)
        {
            string nombreRomain = "";

            if (nombreArabe.ToString().Length == 1)
            {
                 switch (nombreArabe) {
                    case  <= 3:
                        nombreRomain = new string('I', nombreArabe);
                        break;
                    case 4:
                        nombreRomain = new string("IV");
                        break;
                };
            }

            return nombreRomain;
        }
    }
}