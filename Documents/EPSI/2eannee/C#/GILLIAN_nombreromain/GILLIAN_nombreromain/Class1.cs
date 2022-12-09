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
                    case <=8:
                        nombreRomain = 'V'+new string('I',nombreArabe-5);
                        break;
                };
            }

            return nombreRomain;
        }
    }
}