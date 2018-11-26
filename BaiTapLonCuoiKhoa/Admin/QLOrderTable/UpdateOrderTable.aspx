<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="UpdateOrderTable.aspx.cs" Inherits="Admin_OrderTable_UpdateOrderTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titleAdmin" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LinkPageAdmin" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentRight" Runat="Server">
        <div class="col-12 mt-5">
        <div class="card">
            <form action="/Admin/QLOrderTable/UpdateOrderTable.aspx" runat="server">
                <div class="card-body">
                    <h4 class="header-title">Update this OrderTable </h4>
                    <asp:Label ID="mss" runat="server" />
                    <div class="form-group">
                        <label for="example-text-input" class="col-form-label">ID OrderTable <label style="color: red">(*)</label></label>
                        <asp:TextBox runat="server" ID="txtidotb"  CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="reidotb" runat="server" ErrorMessage="The field is required" ControlToValidate="txtidotb" Display="Dynamic" ForeColor="Red" />
                        

                    </div>
                    <div class="form-group">
                        <label for="example-text-input" class="col-form-label">ID User <label style="color: red">(*)</label></label>
                        <asp:TextBox runat="server" ID="txtuser"  CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="The field is required" ControlToValidate="txtuser" Display="Dynamic" ForeColor="Red" />

                    </div>
                    <div class="form-group">
                        <label for="example-text-input" class="col-form-label">Ngày tháng Oder<label style="color: red">(*)</label></label>
                        <br />
                        
                        <input type="date" runat="server" id="dt"  class="date"/>
                        
                    </div>
                    <div class="form-group">
                        <label for="example-text-input" class="col-form-label">ID Bàn đặt <label style="color: red">(*)</label></label>
                        <asp:TextBox runat="server" ID="txtidb"  CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="The field is required" ControlToValidate="txtidb" Display="Dynamic" ForeColor="Red" />

                    </div>
                    <div class="form-group">
                        <label for="example-text-input" class="col-form-label">Đã thanh toán hay chưa<label style="color: red">(*)</label></label>
                        <br />
                        <input type="radio" name="tt" value="Đã thanh toán" runat="server" id="rdodtt"/> Bàn đã thanh toán
                        <br />
                        <input type="radio" name="tt" value="chưa thanh toán" runat="server" id="rdoctt"/> Bàn chưa thanh toán
                        
                        
                    </div>
                   

                    
                    <asp:Button Text="Update" runat="server" class="btn btn-primary mt-4 pr-4 pl-4" ID="updatotb" OnClick="updatotb_Click"    />
                    <asp:Button Text="Cancel" runat="server" class="btn btn-primary mt-4 pr-4 pl-4" ID="resetaaddotb"  />
                    
                    <br />
                </div>
                <%--<button type="submit" class="btn btn-primary mt-4 pr-4 pl-4" id="listtb" >Danh sách bàn</button>--%>
            </form>

        </div>
    </div>
</asp:Content>

