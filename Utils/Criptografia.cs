namespace webapi.Health_Clinic.Utils
{
    public class Criptografia
    {
        public static string GerarHashCode(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        public static bool CompararHashCode(string senhaForm, string senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);
        }
    }
}
