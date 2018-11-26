<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="UpdateTable.aspx.cs" Inherits="Admin_QlTable_UpdateTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titleAdmin" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LinkPageAdmin" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentRight" runat="Server">
    <div class="col-12 mt-5">
        <div class="card">
            <form action="/Admin/QlTable/UpdateTable.aspx" runat="server">
                <div class="card-body">
                    <h4 class="header-title">Update this Table </h4>
                    <asp:Label ID="mss" runat="server" />
                    <div class="form-group">
                        <label for="example-text-input" class="col-form-label">ID Table <label style="color: red">(*)</label></label>
                        <asp:TextBox runat="server" ID="txtidtb"  CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="reidtb" runat="server" ErrorMessage="The field is required" ControlToValidate="txtidtb" Display="Dynamic" ForeColor="Red" />

                    </div>
                    <div class="form-group">
                        <label for="example-text-input" class="col-form-label">Name Table<label style="color: red">(*)</label></label>
                        <asp:TextBox runat="server" ID="txtnametb"  CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="reNameTable" runat="server" ErrorMessage="The field is required" ControlToValidate="txtnametb" Display="Dynamic" ForeColor="Red" />
                        
                    </div>
                    <div class="form-group">
                        <label for="example-text-input" class="col-form-label">Trạng thái bàn<label style="color: red">(*)</label></label>
                        <br />
                        <input type="radio" name="tt" value="Đã được đặt" runat="server" id="rdoddd"/> Bàn đã được đặt
                        <br />
                        <input type="radio" name="tt" value="chưa được đặt" runat="server" id="rdocdd"/> Bàn chưa được đặt
                        
                        
                    </div>
                    <div class="form-group">
                        <label for="example-text-input" class="col-form-label">Mô Tả Table<label style="color: red">(*)</label></label>
                        <asp:TextBox runat="server" ID="txtmota"  CssClass="form-control" /> 
                        <asp:RequiredFieldValidator ID="remotaa" runat="server" ErrorMessage="The field is required" ControlToValidate="txtmota" Display="Dynamic" ForeColor="Red" />
                        
                    </div>

                    
                    <asp:Button Text="Update" runat="server" class="btn btn-primary mt-4 pr-4 pl-4" ID="updattb" OnClick="updattb_Click"   />
                    <asp:Button Text="Cancel" runat="server" class="btn btn-primary mt-4 pr-4 pl-4" ID="resetaaddtb"  />
                    
                    <br />
                </div>
                <%--<button type="submit" class="btn btn-primary mt-4 pr-4 pl-4" id="listtb" >Danh sách bàn</button>--%>
            </form>

        </div>
    </div>
</asp:Content>

