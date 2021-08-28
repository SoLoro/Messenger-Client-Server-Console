using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
  [Serializable]
  public class message
  {
    public string username { get; set; }
    public string text { get; set; }
    public string timestamp { get; set; }

    public message()
    {
      this.username = "Server";
      this.text = "Server is running...";
      this.timestamp = DateTime.Now.ToString("dd MMM H:mm");
    }

    public message(string username, string text)
    {
      this.username = username;
      this.text = text;
      this.timestamp = DateTime.Now.ToString("dd MMM H:mm");
    }
  }
  [Serializable]
  public class SessionsClass
  {
    public List<tokens> list_tokens = new List<tokens>();
    
    public SessionsClass()
		{

		}

    public void addValera()
    {
      Random rand = new Random();
      int int_token = rand.Next(1000 * 1000, 10 * 1000 * 1000);
      tokens token_record = new tokens(int_token, "Valera", "UWP");
      token_record.login = "Valera";
      token_record.password = "UWP";
      token_record.token = int_token;
      list_tokens.Add(token_record);
    }

    public int GenToken()
    {
      Random rand = new Random();
      return rand.Next(10 * 1000 , 100 * 1000 );
    }

    public int login(AuthData auth_data)
    {
      string login = auth_data.login;
      string password = auth_data.password;
      bool login_exist = false;
      int row_num = 0;
      
      foreach (tokens item in this.list_tokens)
      {
        Console.WriteLine(item.login);
        if (item.login == login)
        {
          login_exist = true;
          if (item.password == password)
          {
            int token = GenToken();
            tokens record_token = new tokens(token, login, password);
            this.list_tokens[row_num].token = token;
            //list_tokens.Add(record_token);
            Console.WriteLine($"Аутификация успешно login: {login} password: {password} token: {token}");
            return token;
          }
          else
          {
            return -1;
          }
        }
        row_num++;
      }
      if (!login_exist)
      {        
        return -2;
      }
      return -200;   // ошибка логики
    }

    public int registration(AuthData auth_data)
    {
      bool login_exist = false;
      foreach (tokens item in this.list_tokens)
      {
        if (item.login == auth_data.login)
        {
          login_exist = true;
        }
      }
      if (!login_exist) 
      { 
        int token = GenToken();
        tokens record_token = new tokens(token, auth_data.login, auth_data.password);
        this.list_tokens.Add(record_token);
        Console.WriteLine($"Регистрация успешно login: {auth_data.login} password: {auth_data.password} token: {token}");
        return token;
      }
      return -1;
    }


    public void SaveToFile(string filename = "data_sessions.json")
    {  
      try
      {
        var serializer = new JsonSerializer();

        StringWriter writejson = new StringWriter();

        serializer.Serialize(writejson, this.list_tokens);

        using (StreamWriter sw = new StreamWriter(filename))
        {
          sw.Write(writejson);
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

    }

    public void LoadFromFile(string filename = "data_sessions.json")
    {
      long size = 0;
      if (File.Exists(filename)) 
      { 
       System.IO.FileInfo file = new System.IO.FileInfo(filename);
       size = file.Length;
      }
      if (size > 0)
      {
        try
        {
          //Console.WriteLine("Dannie vigruzheni");
          string json = "";
          using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
          {
            json = sr.ReadToEnd();
          }

          var deserializer = new JsonSerializer();

          this.list_tokens = (List<tokens>)deserializer.Deserialize(new StringReader(json), typeof(List<tokens>));
          for (int i = 0; i < list_tokens.Count; i++)
          {
            this.list_tokens[i].token = 0;
          }

          // После того, как записали юзеров из файла, заполняем словарь онлайна
          foreach(tokens t in this.list_tokens)
					{
            Program.onlineUsers.Add(t.login, 0);
					}
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }
        // Console.WriteLine($"Загружено записей: {this.list_tokens.Count}");
      }

    }

    // Заполнение
  }
}
