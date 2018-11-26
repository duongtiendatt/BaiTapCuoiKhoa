<%@ Page Title="DDHT || List members" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="ListMembers.aspx.cs" Inherits="Admin_QlMembers_ListMembers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titleAdmin" runat="Server">
    DDHT || List members
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LinkPageAdmin" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentRight" runat="Server">
    <form runat="server">
        <div class="col-12 mt-5">
            <div class="card">
                <div class="card-body">
                    <h4 class="header-title">List members</h4>
                    <div class="data-tables datatable-dark">
                        <div id="dataTable3_wrapper" class="dataTables_wrapper dt-bootstrap4 no-footer">
                            <div class="row">
                                <div class="col-sm-12 col-md-6">
                                    <div class="dataTables_length" id="dataTable3_length">
                                        <label>
                                            Show
                                        <select name="dataTable3_length" aria-controls="dataTable3" class="custom-select custom-select-sm form-control form-control-sm">
                                            <option value="10">10</option>
                                            <option value="25">25</option>
                                            <option value="50">50</option>
                                            <option value="100">100</option>
                                        </select>
                                            entries</label>
                                    </div>
                                </div>
                                <div class="col-sm-12 col-md-6">
                                    <div id="dataTable3_filter" class="dataTables_filter" style="line-height: 30px;">
                                        <label style="display: inline-flex;">
                                            Search:<form action="#">
                                                <input type="search" class="form-control form-control-sm" placeholder="Search" aria-controls="dataTable3">
                                                <i class="ti-search"></i>
                                            </form>
                                        </label>

                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-12">
                                    <table id="dataTable3" class="text-center dataTable no-footer dtr-inline" role="grid" aria-describedby="dataTable3_info" style="width: 959px;">
                                        <thead class="text-capitalize">
                                            <tr role="row">
                                                <th class="sorting_asc" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 226px;" aria-sort="ascending" aria-label="Fullname: activate to sort column descending">Fullname</th>
                                                <th class="sorting" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 111px;" aria-label="Phone: activate to sort column ascending">Phone</th>
                                                <th class="sorting" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 94px;" aria-label="Mail: activate to sort column ascending">Mail</th>
                                                <th class="sorting" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 54px;" aria-label="Username: activate to sort column ascending">Username</th>
                                                <th class="sorting" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 109px;" aria-label="Type Date: activate to sort column ascending">Type</th>
                                                <th class="sorting" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 77px;" aria-label="salary: activate to sort column ascending">Action</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <%
                                                var listMembers = new DataUtil().GetListMembers();
                                                foreach (var mb in listMembers)
                                                {
                                                    Response.Write("<tr role=row class=odd>");
                                                    Response.Write("<td tabindex=0  class=sorting_1>" + mb.member_fullname + "</td>");
                                                    Response.Write("<td>" + mb.member_phone + "</td>");
                                                    Response.Write("<td>" + mb.member_mail + "</td>");
                                                    Response.Write("<td>" + mb.member_username + "</td>");
                                                    if (mb.member_type == 1)
                                                    {
                                                        Response.Write("<td>Admin</td>");
                                                    }
                                                    else
                                                    {
                                                        Response.Write("<td>User</td>");
                                                    }
                                                    Response.Write("<td><a href='/Admin/QlMembers/DeleteMember.aspx?idtable="+mb.member_id+"'>Xóa</a> | <a href='/Admin/QlMembers/UpdateMember.aspx?idmember=" + mb.member_id + "'>Sửa</a></td>");
                                                    Response.Write("</tr>");
                                                }
                                            %>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

</asp:Content>

