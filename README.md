# Messenger(Client-Server-Console) project
____
## Installation
```
    https://github.com/SoLoro/Messenger-Client-Server-Console.git
```
____
## Languages
*C#*
____
## Libraries
*.NETCoreApp, Docker, UML, Newtonsoft, .NETFramework, ASP.Net Core, SDK*
____
## How to use it?
- After downloading the project, first of all you need to run the server part of the project (Server. sln). This will allow you to synchronize data and unpack the platform on which this application works
- Then it all depends on which version of the client application you want to use
    - *If this is the GUI version, then you need to run DotChatWF.sln*
    - *If the console version , then DotChat.sln*
- ___Working with the GUI___
    - Initially, the main menu will open in front of you, from which, before you start working with the chat , you must either log in by clicking on the ,,Authentication,, , button or register by clicking on the ,,Registration,, button.
        - In the registration window, you need to enter your new username and password and click on the button ,,Registration,,
        - In the authorization window, you must enter an existing username and password to it (IP-optional), and click on the button ,,Login,,
    - After the manipulations performed, you find yourself in the main dialog box of the program, where you can write and read messages from other users while already in your account. To write a message, you just need to enter it in the ,,Message,, field and click on the button ,,SEND,,.
    - **Each message in the main panel consists of: date, month, time of sending, the sender's login, the sent message, the ID of this message in the current panel**
    - **There is also identification of online and offline user states with corresponding chat alerts, as well as identification of new user registration**
- ___Working with the Console___
    - A single panel opens in front of you, where you can perform all the above actions
____
## Administration
- Data
    - ***By default, I made the data for the administrator***
        - *username: admin*
        - *password: admin*
- Opportunities
    - **Being in the administrator account, you have the ability to delete any user messages**
    - **This is done using the ID**
    - *You just need to send the following message to the chat:*
        ```
            /delete ID
        ```
    - ***Where ID in this case is the number of the message in the chat (the information with the number is indicated next to each of the chat messages)***
    - *Example of deleting a message with ID 13:*
        ```
            /delete 13
        ```

