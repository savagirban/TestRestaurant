namespace RestaurantFis.Models.Domain.Models
{
    public class PasswordEncryptor
    {
        private readonly string _password;
        
        public PasswordEncryptor(string password)
        {
            _password = password;
        }

        public string Encrypt()
        {
            string encrypt = _password.Replace(' ', '_');
            encrypt = encrypt.ToLower();
            encrypt = encrypt.Replace('s', '#');
            encrypt = encrypt.Replace('#', '+');
            encrypt = encrypt.Replace('+', 'b');
            encrypt = encrypt.Replace('a', '$');
            encrypt = encrypt.Replace('e', '@');
            encrypt = encrypt.Replace('@', '3');

            return encrypt;
        }
    }
}
