using System;
using Terminal.Gui;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Net.Cache;
using System.Timers;

namespace DotChat
{
    [Serializable]
    public class Message {
        public string username = "";
        public string text = "";
        public DateTime timestamp;
    }

    class Program
    {
        private static MenuBar menu;
        private static Window winMain;
        private static Window winMessages;
        private static Label labelUsername;
        private static Label labelMessage;
        private static TextField fieldUsername;
        private static TextField fieldMessage;
        private static Button btnSend;

        private static List<Message> messages = new List<Message>();

        static void Main(string[] args)
        {
            Application.Init();

            //ColorScheme colorDark = new ColorScheme();
            //colorDark.Normal = new Terminal.Gui.Attribute(Color.White, Color.DarkGray);

            // Создание верхнего меню приложения
            menu = new MenuBar(new MenuBarItem[]
            {
                new MenuBarItem("_App", new MenuItem[]
                {
                    new MenuItem("_Quit", "Close the app", Application.RequestStop),
                }),
            })
            {
                X = 0, Y = 0,
                Width = Dim.Fill(),
                Height = 1,
            };
            Application.Top.Add(menu);
            
            // Создание главного окна
            winMain = new Window() {
                X = 0,
                Y = 1,
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                Title = "DotChat",
            };
            //winMain.ColorScheme = colorDark;
            Application.Top.Add(winMain);
            
            // Создание окна с сообщениями
            winMessages = new Window() {
                X = 0,
                Y = 0,
                Width = winMain.Width,
                Height = winMain.Height - 2,
            };
            winMain.Add(winMessages);
            
            // Создание надписи с username
            labelUsername = new Label() { 
                X = 0,
                Y = Pos.Bottom(winMain) - 5,
                Width = 15,
                Height = 1,
                Text = "Username:",
                TextAlignment = TextAlignment.Right,
            };
            winMain.Add(labelUsername);
            
            // Создание надписи с message
            labelMessage = new Label()
            {
                X = 0,
                Y = Pos.Bottom(winMain) - 4,
                Width = 15,
                Height = 1,
                Text = "Message:",
                TextAlignment = TextAlignment.Right,
            };
            winMain.Add(labelMessage);
            
            // Создание поля ввода username
            fieldUsername = new TextField()
            {
                X = 15,
                Y = Pos.Bottom(winMain) - 5,
                Width = winMain.Width - 15,
                Height = 1,
            };
            winMain.Add(fieldUsername);
            
            // Создание поля ввода message
            fieldMessage = new TextField()
            {
                X = 15,
                Y = Pos.Bottom(winMain) - 4,
                Width = winMain.Width - 15,
                Height = 1,
            };
            winMain.Add(fieldMessage);
            
            // Создание кнопки отправки
            btnSend = new Button()
            {
                X = Pos.Right(winMain) - 15,
                Y = Pos.Bottom(winMain) - 4,
                Width = 15,
                Height = 1,
                Text = "  SEND  ",
            };
            btnSend.Clicked += OnBtnSendClick;
            winMain.Add(btnSend);
        }
    }
}
