﻿namespace BlazorForms
{
    /// <summary>
    /// Klasa reprezentująca użytkownika - podstawa do utworzenia 
    /// formularza rejestracji.
    /// </summary>
    public class User
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
