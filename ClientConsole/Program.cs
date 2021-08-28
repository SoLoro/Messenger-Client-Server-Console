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
        
    }
}
