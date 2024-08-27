<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="CMPG223_MedAppoint_Group59.ContactUs" %>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ContactUs</title>
    <link rel="stylesheet" href="StyleSheet1.css">
</head>

<body>
    <!-- Navigation bar -->
    <nav class="navbar">
        <ul class="nav-list">
            <li><a href="#home">Home</a></li>
            <li><a href="#about">About</a></li>
            <li><a href="LogInPage.html">Login</a></li>
            <li><a href="RegistrationPage.html">Register</a></li>
        </ul>
    </nav>

    <div class="container">
        <div class="contactUs">
            <h2>Contact Us</h2>
            
             <form action="#">
                <div class="input-box">
                    <input type="text" id="firstName" required>
                    <label>Name and Surname</label>
                </div>

                <div class="input-box">
                    <input type="text" id="contactNumber" onkeypress="return /[0-9]/i.test(event.key)" minlength="10" maxlength="10" required>
                    <label>Contact Number</label>
                </div>

                <div class="input-box">
                    <input type="email" id="email" required>
                    <label>Email</label>
                    </div>

                    <div class="input-box2">
                         <textarea id="Message" required></textarea>
                        <label for="Message">Your Message</label>
                   </div>


                &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp <button id="btnSubmit" type="submit" class="btn">Submit</button>

            </form>
        </div>
    </div>
    
</body>

</html>
