namespace clotchstore;

public class User
{
    private string _fullName;
    private string _email;
    private string _password;

    public void registration(string fullName, string email, string password)
    {
        this._fullName = fullName;
        this._email = email;
        this._password = password;
    }

    public bool auth(string email, string password)
    {
        if (this._email == email && this._password == password) return true;
        else return false;
    }

    public string getEmail()
    {
        return this._email;
    }

    public string getPassword()
    {
        return this._password;
    }
}
