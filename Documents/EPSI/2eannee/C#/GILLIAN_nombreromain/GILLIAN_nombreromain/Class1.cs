namespace GILLIAN_nombreromain
{
    public class ConvertisseurNombresRomains
    {
        public static string Convertir(int nombreArabe)
        {
            string UniteRomain = "";
            string DizaineRomain = "";

            if (nombreArabe.ToString().Length >= 1)
            {
                int UniteArabe= Int32.Parse(nombreArabe.ToString()[nombreArabe.ToString().Length-1].ToString());

                
                 switch (UniteArabe) {
                     case  0:
                        UniteRomain = "";
                        break;
                     case <= 3:
                         UniteRomain = new string('I', UniteArabe);
                         break;
                    case 4:
                        UniteRomain = new string("IV");
                        break;
                    case <=8:
                        UniteRomain = 'V'+new string('I', UniteArabe - 5);
                        break;
                    case 9:
                        UniteRomain = new string("IX");
                        break;

                };
            }
            if (nombreArabe.ToString().Length >= 2)
            {
                int DizaineArabe = Int32.Parse(nombreArabe.ToString()[nombreArabe.ToString().Length - 2].ToString());


                switch (DizaineArabe)
                {
                    case 0:
                        DizaineRomain = "";
                        break;
                    case <= 3:
                        DizaineRomain = new string('X', DizaineArabe);
                        break;
                    case 4:
                        DizaineRomain = new string("XL");
                        break;
                    case <= 8:
                        DizaineRomain = 'L' + new string('X', DizaineArabe - 5);
                        break;
                    case 9:
                        DizaineRomain = new string("XC");
                        break;

                };
            }
            
            return DizaineRomain+UniteRomain;
        }
    }
}