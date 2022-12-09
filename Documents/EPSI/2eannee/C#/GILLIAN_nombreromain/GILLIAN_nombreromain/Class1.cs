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
                    case  <= 1:
                        nombreRomain = new string('I', nombreArabe);
                        break;
                };
            }

            return nombreRomain;
        }
    }
}