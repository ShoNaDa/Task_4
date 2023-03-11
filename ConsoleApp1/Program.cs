using System.Text.RegularExpressions;

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        
    }

    public static bool BiggestNumber(int first, int second)
    {
        return first > second;
    }

    public static int MToSm(int meters)
    {
        return meters * 100;
    }

    public static bool DateIsExist(string date)
    {
        DateTime newDate;
        return DateTime.TryParse(date, out newDate);
    }

    public static bool Authorize(string login, string password, Dictionary<string, string> listUsers)
    {
        if (listUsers.Keys.Contains(login))
        {
            return listUsers[login] == password;
        }

        return false;
    }

    public static bool Register(string login, string passsword, string email, string birth,
        Dictionary<string, string> listUsers)
    {
        //login is not exist
        if (!listUsers.Keys.Contains(login))
        {
            Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match matchEmail = regexEmail.Match(email);

            //check email
            if (matchEmail.Success)
            {
                DateTime ddate;
                //check datetime
                if (DateTime.TryParse(birth, out ddate))
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        return false;
    }
}