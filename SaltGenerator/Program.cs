Console.WriteLine(GenerateSalt());

static string GenerateSalt(int size = 16)
{
    var salt = new byte[size];
    using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
    {
        rng.GetBytes(salt);
    };

    return Convert.ToBase64String(salt);
}
