<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TestApplication.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <!--<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">-->
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>Sedna - A Free HTML5/CSS3 website by Peter Finlan</title>
    <meta name="description" content=""/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="apple-touch-icon" href="apple-touch-icon.png"/>
    <link rel="icon" type="image/png" href="favicon-32x32.png" sizes="32x32" />
    <link rel="icon" type="image/png" href="favicon-16x16.png" sizes="16x16" />
    <link rel="stylesheet" href="css/normalize.min.css"/>
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
    <link rel="stylesheet" href="css/jquery.fancybox.css"/>
    <link rel="stylesheet" href="css/flexslider.css"/>
    <link rel="stylesheet" href="css/styles.css"/>
    <link rel="stylesheet" href="css/queries.css"/>
    <link rel="stylesheet" href="css/etline-font.css"/>
    <link rel="stylesheet" href="bower_components/animate.css/animate.min.css"/>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"/>
    <script src="js/vendor/modernizr-2.8.3-respond-1.4.2.min.js"></script>
</head>
<body>
  <!--[if lt IE 8]>
    <p class="browserupgrade">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
    <![endif]-->
    <section class="hero">
        <section class="navigation">
            <header>
                <div class="header-content">
                    <div class="logo"><a href="Index.aspx"><img src="img/sedna-logo.png" alt="Sedna logo"></a></div>
               </div>
            </header>
        </section>
   <div class="down-arrow floating-arrow"><a href="#"><i class="fa fa-angle-down"></i></a></div>
    </section>

    <section class="sign-up section-padding text-center" id="download">
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-md-offset-3">
                    <h3>Get started with IoT Platform, absolutely awsome!</h3>
                    <form class="signup-form" runat="server" >
                        <div class="form-input-group">
                            <i class="fa fa-envelope"></i><input type="text" class="" placeholder="Enter your email" runat="server"/>
                        </div>
                        <div class="form-input-group">
                            <i class="fa fa-lock"></i><input type="text" class="" placeholder="Enter your password" runat="server"/>
                        </div>
                        <div class="form-input-group">
                            <i class="fa fa-lock"></i><input type="text" class="" placeholder="Enter Factory Name" runat="server"/>
                        </div>
                        <asp:Button class="btn-fill sign-up-btn" ID="btnSignUP" Text="Sign Up" runat="server" OnClick="btnSignUP_Click"/> 
                        <%--<button type="submit" class="btn-fill sign-up-btn" runat="server">Sign up</button>--%>
                    </form>
                </div>
            </div>
        </div>
    </section>
    <section class="to-top">
        <div class="container">
            <div class="row">
                <div class="to-top-wrap">
                    <a href="#top" class="top"><i class="fa fa-angle-up"></i></a>
                </div>
            </div>
        </div>
    </section>

     <footer>
        <div class="container">
            <div class="row">
                <div class="col-md-7">
                    <div class="footer-links">
                        <ul class="footer-group">
                            <li><a href="Index.aspx">IoT Platforms</a></li>
                            <li><a href="Register.aspx">Sign up</a></li>
                        </ul>
                        <p>Copyright © 2019 <a href="#">PiCs Academy</a><br>
                        <a href="http://picstrainingacademy.com/">Licence</a> | Crafted with <span class="fa fa-heart pulse2"></span> by <a href="http://pinetrainingacademy.com/">PinE Training Academy</a>.</p>
                    </div>
                </div>
                <div class="social-share">
                    <p>Share PiCs Workshop learnign with your friends</p>
                    <a href="https://www.facebook.com/PiCSTrainingAcademy/" class="facebook-share"><i class="fa fa-facebook"></i></a>
                </div>
            </div>
        </div>
    </footer>

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script>window.jQuery || document.write('<script src="js/vendor/jquery-1.11.2.min.js"><\/script>')</script>
    <script src="bower_components/retina.js/dist/retina.js"></script>
    <script src="js/jquery.fancybox.pack.js"></script>
    <script src="js/vendor/bootstrap.min.js"></script>
    <script src="js/scripts.js"></script>
    <script src="js/jquery.flexslider-min.js"></script>
    <script src="bower_components/classie/classie.js"></script>
    <script src="bower_components/jquery-waypoints/lib/jquery.waypoints.min.js"></script>
    <!-- Google Analytics: change UA-XXXXX-X to be your site's ID. -->
    <script>
    (function(b,o,i,l,e,r){b.GoogleAnalyticsObject=l;b[l]||(b[l]=
    function(){(b[l].q=b[l].q||[]).push(arguments)});b[l].l=+new Date;
    e=o.createElement(i);r=o.getElementsByTagName(i)[0];
    e.src='//www.google-analytics.com/analytics.js';
    r.parentNode.insertBefore(e,r)}(window,document,'script','ga'));
    ga('create','UA-XXXXX-X','auto');ga('send','pageview');
    </script>
</body>
</html>
