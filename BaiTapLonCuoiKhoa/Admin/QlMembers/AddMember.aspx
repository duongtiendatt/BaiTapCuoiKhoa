<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AddMember.aspx.cs" Inherits="Admin_QlMembers_AddMember" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titleAdmin" runat="Server">
    DDHT || Add new user
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LinkPageAdmin" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentRight" runat="Server">
    <div class="col-12 mt-5">
        <div class="card">
            <div class="card-body">
                <form id="formadduser" runat="server" action="/Admin/QlMembers/AddMember.aspx">
                    <h4 class="header-title">Add a new user to website</h4>
                    <asp:Label ID="msg" runat="server" />

                    <div class="form-group">
                        <label for="example-text-input" class="col-form-label">
                            Full name
                            <label style="color: red">(*)</label></label>
                        <asp:TextBox runat="server" ID="txtfullname" placeholder="Example: Dương Tiến Đạt" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="refullname" runat="server" ErrorMessage="The field is required" ControlToValidate="txtfullname" Display="Dynamic" ForeColor="Red" />
                    </div>
                    <div class="form-group">
                        <label for="example-search-input" class="col-form-label">
                            User name
                            <label style="color: red">(*)</label></label>
                        <asp:TextBox runat="server" ID="txtusername" placeholder="Example: duongtiendat" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="reusername" runat="server" ErrorMessage="The field is required" ControlToValidate="txtusername" Display="Dynamic" ForeColor="Red" />
                        <asp:RegularExpressionValidator ID="regusername" runat="server" ErrorMessage="Username in the range of 6 to 15 characters" ControlToValidate="txtusername" ValidationExpression=".{6,15}" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                    </div>
                    <div class="form-group">
                        <label for="example-email-input" class="col-form-label">
                            Email
                            <label style="color: red">(*)</label></label>
                        <asp:TextBox runat="server" ID="txtemail" placeholder="Example: name@example.com" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="reemail" runat="server" ErrorMessage="The field is required" ControlToValidate="txtemail" Display="Dynamic" ForeColor="Red" />
                        <asp:RegularExpressionValidator ID="regemail" runat="server" ControlToValidate="txtemail" ErrorMessage="Wrong format" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red" />
                    </div>
                    <div class="form-group">
                        <label for="example-tel-input" class="col-form-label">
                            Telephone
                            <label style="color: red">(*)</label></label>
                        <asp:TextBox runat="server" ID="txtphone" placeholder="Example: 0336515294" CssClass="form-control" TextMode="Phone" />
                        <asp:RegularExpressionValidator ID="regphone" runat="server" ErrorMessage="Username in the range of 9 to 11 numbers" Display="Dynamic" ControlToValidate="txtphone" ForeColor="Red" ValidationExpression=".{9,11}" />
                        <asp:RequiredFieldValidator ID="rephone" runat="server" ErrorMessage="The field is required" Display="Dynamic" ControlToValidate="txtphone" ForeColor="Red" />
                    </div>
                    <div class="form-group">
                        <label for="inputPassword" class="">Password</label>
                        <asp:TextBox runat="server" ID="txtpassword" CssClass="form-control" TextMode="Password" />
                        <asp:RequiredFieldValidator ID="repassword" runat="server" ErrorMessage="The field is required" ForeColor="Red" ControlToValidate="txtpassword" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regpassword" runat="server" ErrorMessage="Username in the range of 6 to 15 numbers" ControlToValidate="txtpassword" ValidationExpression=".{6,15}" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                    </div>
                    <div class="form-group">
                        <label for="inputPassword" class="">Confirm Password</label>
                        <asp:TextBox runat="server" ID="txtconfirmpassword" CssClass="form-control" TextMode="Password" />
                        <asp:CompareValidator ID="compassword" runat="server" ControlToCompare="txtpassword" ControlToValidate="txtconfirmpassword" ErrorMessage="Password not match" ForeColor="Red"></asp:CompareValidator>
                    </div>
                    <div class="form-group">
                        <label class="col-form-label">Type</label>
                        <asp:DropDownList ID="ddltype" runat="server" CssClass="form-control">
                            <asp:ListItem Enabled="true" Text="Member" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Admin" Value="1"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:Button CssClass="btn btn-primary mt-4 pr-4 pl-4" runat="server" ID="btnsubmit" Text="ADD" OnClick="btnsubmit_Click" />
                </form>
            </div>

        </div>
    </div>
</asp:Content>

