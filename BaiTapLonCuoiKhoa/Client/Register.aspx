<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Client_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DDHT || SIGN UP</title>
    <base href="../Assets/AssetsAdmin/">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="shortcut icon" type="image/png" href="images/icon/favicon.ico">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/font-awesome.min.css">
    <link rel="stylesheet" href="css/themify-icons.css">
    <link rel="stylesheet" href="css/metisMenu.css">
    <link rel="stylesheet" href="css/owl.carousel.min.css">
    <link rel="stylesheet" href="css/slicknav.min.css">
    <!-- amchart css -->
    <link rel="stylesheet" href="https://www.amcharts.com/lib/3/plugins/export/export.css" type="text/css" media="all" />
    <!-- others css -->
    <link rel="stylesheet" href="css/typography.css">
    <link rel="stylesheet" href="css/default-css.css">
    <link rel="stylesheet" href="css/styles.css">
    <link rel="stylesheet" href="css/responsive.css">
    <!-- modernizr css -->
    <script src="js/vendor/modernizr-2.8.3.min.js"></script>



    <link href="/Assets/css/StyleCustom.css" rel="stylesheet" />
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark site_navbar bg-dark site-navbar-light login-page" id="site-navbar">
        <div class="container">
            <a class="navbar-brand" href="/TrangChu.aspx">EatWell</a>
        </div>
    </nav>
    <div class="login-area">
        <div class="container">
            <div class="login-box ptb--100">
                <form id="form1" runat="server" action="/Client/Register.aspx">
                    <div class="login-form-head">
                        <h4>Sign up</h4>
                        <p>Hello there, Sign up and Join with Us</p>
                    </div>
                    <div class="login-form-body">
                        <div class="form-gp">
                            <label for="txtfullname">Full Name</label>
                            <asp:TextBox runat="server" ID="txtfullname" />
                            <asp:RequiredFieldValidator ID="refullname" runat="server" ErrorMessage="The field is required" ControlToValidate="txtfullname" Display="Dynamic" ForeColor="Red" />
                            <i class="ti-user"></i>
                        </div>
                        <div class="form-gp">
                            <label for="txtconfirmpassword">User name</label>
                            <asp:TextBox runat="server" ID="txtusername" />
                            <asp:RequiredFieldValidator ID="reusername" runat="server" ErrorMessage="The field is required" ControlToValidate="txtusername" Display="Dynamic" ForeColor="Red" />
                            <asp:RegularExpressionValidator ID="regusername" runat="server" ErrorMessage="Username in the range of 6 to 15 characters" ControlToValidate="txtusername" ValidationExpression=".{6,15}" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                            <i class="ti-user"></i>
                        </div>
                        <div class="form-gp">
                            <label for="txtphone">Phone</label>
                            <asp:TextBox runat="server" ID="txtphone" TextMode="Phone" />
                            <asp:RegularExpressionValidator ID="regphone" runat="server" ErrorMessage="Username in the range of 9 to 11 numbers" Display="Dynamic" ControlToValidate="txtphone" ForeColor="Red" ValidationExpression=".{9,11}" />
                            <asp:RequiredFieldValidator ID="rephone" runat="server" ErrorMessage="The field is required" Display="Dynamic" ControlToValidate="txtphone" ForeColor="Red" />
                            <i class="ti-lock"></i>
                        </div>
                        <div class="form-gp">
                            <label for="txtemail">Email address</label>
                            <asp:TextBox runat="server" ID="txtemail" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="reemail" runat="server" ErrorMessage="The field is required" ControlToValidate="txtemail" Display="Dynamic" ForeColor="Red" />
                            <asp:RegularExpressionValidator ID="regemail" runat="server" ControlToValidate="txtemail" ErrorMessage="Wrong format" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red" />
                            <i class="ti-email"></i>
                        </div>
                        <div class="form-gp">
                            <label for="txtpassword">Password</label>
                            <asp:TextBox runat="server" ID="txtpassword" CssClass="form-control" TextMode="Password" />
                            <asp:RequiredFieldValidator ID="repassword" runat="server" ErrorMessage="The field is required" ForeColor="Red" ControlToValidate="txtpassword" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="regpassword" runat="server" ErrorMessage="Username in the range of 6 to 15 numbers" ControlToValidate="txtpassword" ValidationExpression=".{6,15}" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                            <i class="ti-lock"></i>
                        </div>
                        <div class="form-gp">
                            <label for="txtconfirmpassword">Confirm Password</label>
                            <asp:TextBox runat="server" ID="txtconfirmpassword" CssClass="form-control" TextMode="Password" />
                            <asp:CompareValidator ID="compassword" runat="server" ControlToCompare="txtpassword" ControlToValidate="txtconfirmpassword" ErrorMessage="Password not match" ForeColor="Red"></asp:CompareValidator>
                            <i class="ti-lock"></i>
                        </div>
                    </div>
                    <div class="submit-btn-area">
                        <asp:Button CssClass="btn btn-primary mt-4 pr-4 pl-4" runat="server" ID="btnregister" Text="REGISTER" OnClick="btnregister_Click"/>
                    </div>
                    <div class="form-footer text-center mt-5">
                        <p class="text-muted">Have an account? <a href="/Client/Login.aspx">Sign in</a></p>
                    </div>
                </form>
            </div>
    </div>
    </div>

    <!-- jquery latest version -->
    <script src="js/vendor/jquery-2.2.4.min.js"></script>
    <!-- bootstrap 4 js -->
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/metisMenu.min.js"></script>
    <script src="js/jquery.slimscroll.min.js"></script>
    <script src="js/jquery.slicknav.min.js"></script>

    <!-- others plugins -->
    <script src="js/plugins.js"></script>
    <script src="js/scripts.js"></script>
</body>
</html>
