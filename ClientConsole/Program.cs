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
        }
    }
}
