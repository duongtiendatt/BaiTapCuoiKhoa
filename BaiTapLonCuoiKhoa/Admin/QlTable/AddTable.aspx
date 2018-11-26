<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AddTable.aspx.cs" Inherits="Admin_OrderTable_AddTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titleAdmin" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LinkPageAdmin" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentRight" Runat="Server">
 <div class="col-12 mt-5">
        <div class="card">
            <div class="card-body">
                <form id="formadduser" runat="server" action="/Admin/QLtable/AddTable.aspx">
                    <h4 class="header-title">Add a new table to website</h4>
                    <asp:label  runat="server" ID="mss" />
                    <asp:Label ID="msg" runat="server"/>

                    <div class="form-group">
                        <label for="example-text-input" class="col-form-label">Name Table <label style="color: red">(*)</label></label>
                        <asp:TextBox runat="server" ID="txtnametb" placeholder="Example: bàn 1" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="renametb" runat="server" ErrorMessage="The field is required" ControlToValidate="txtnametb" Display="Dynamic" ForeColor="Red" />
                    </div>
                    <div class="form-group">
                        <label for="example-text-input" class="col-form-label">Mô tả <label style="color: red">(*)</label></label>
                        <asp:TextBox runat="server" ID="txtmato" placeholder="Example: bàn to hay nhỏ, màu gì" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="remota" runat="server" ErrorMessage="The field is required" ControlToValidate="txtmato" Display="Dynamic" ForeColor="Red" />
                    </div>
                    
                    <asp:Button CssClass="btn btn-primary mt-4 pr-4 pl-4" runat="server" ID="btnsubmit" Text="ADD" OnClick="btnsubmit_Click"/>
                </form>
            </div>

        </div>
    </div>
</asp:Content>

