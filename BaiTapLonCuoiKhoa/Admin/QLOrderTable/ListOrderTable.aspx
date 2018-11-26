<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="ListOrderTable.aspx.cs" Inherits="Admin_QLOrderTable_ListOrderTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titleAdmin" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LinkPageAdmin" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentRight" Runat="Server">
     <div class="col-12 mt-5">
        <div class="card">
            <div class="card-body">
                <h4 class="header-title">Data Table Dark</h4>
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
                                <div id="dataTable3_filter" class="dataTables_filter">
                                    <label>Search:<input type="search" class="form-control form-control-sm" placeholder="" aria-controls="dataTable3"></label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <table id="dataTable3" class="text-center dataTable no-footer dtr-inline" role="grid" aria-describedby="dataTable3_info" style="width: 959px;">
                                    <thead class="text-capitalize">
                                        <tr role="row">
                                            <th class="sorting_asc" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 111px;" aria-sort="ascending" >ID OrderTable</th>
                                            <th class="sorting" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 94px;" >ID User</th>
                                            <th class="sorting" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 226px;" >Ngày</th>
                                            <th class="sorting" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 94px;" >ID Bàn</th>
                                            <th class="sorting" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 94px;" >Tình trạng</th>
                                            
                                            
                                            <th class="sorting" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 54px;" >Xóa</th>
                                            <%--<th class="sorting" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 109px;" aria-label="Type Date: activate to sort column ascending">Type</th>--%>
                                            <%--<th class="sorting" tabindex="0" aria-controls="dataTable3" rowspan="1" colspan="1" style="width: 77px;" aria-label="salary: activate to sort column ascending">salary</th>--%>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <%
                                            var listOrderTable = new DataUtil().dsOrderTable();
                                            foreach (var tb in listOrderTable)
                                            {
                                                Response.Write("<tr role=row class=odd>");

                                                Response.Write("<td tabindex=0  class=sorting_1>"+tb.ordertable_id+"</td>");
                                                Response.Write("<td>"+tb.ordertable_iduser+"</td>");
                                                Response.Write("<td>"+tb.ordertable_timeset+"</td>");
                                                Response.Write("<td>"+tb.ordertable_id+"</td>");
                                                if(tb.ordertable_status == true)
                                                {
                                                    Response.Write("<td>Đã thanh toán</td>");
                                                }
                                                else
                                                {
                                                    Response.Write("<td>Chưa thanh toán</td>");
                                                }                                                
                                                Response.Write("<td><a href='javascript:void(0)' onclick='funcXoa("+tb.ordertable_id+")'>Xóa</a> | <a href='/Admin/QLOrderTable/UpdateOrderTable.aspx?idotable="+tb.ordertable_id+"'>sửa</a></td>");
                                                                                                                                                
                                                Response.Write("</tr>");


                                            }
                                        %>
                                       <%-- <tr role="row" class="odd">
                                            <td tabindex="0" class="sorting_1">Airi Satou</td>
                                            <td>Accountant</td>
                                           .

















                                            <td>Tokyo</td>
                                            <td>33</td>
                                            <td>2008/11/28</td>
                                            <td>$162,700</td>
                                        </tr>
                                        <tr role="row" class="even">
                                            <td tabindex="0" class="sorting_1">Angelica Ramos</td>
                                            <td>Chief Executive Officer (CEO)</td>
                                            <td>London</td>
                                            <td>47</td>
                                            <td>2009/10/09</td>
                                            <td>$1,200,000</td>
                                        </tr>
                                        <tr role="row" class="odd">
                                            <td tabindex="0" class="sorting_1">Ashton Cox</td>
                                            <td>Junior Technical Author</td>
                                            <td>San Francisco</td>
                                            <td>66</td>
                                            <td>2009/01/12</td>
                                            <td>$86,000</td>
                                        </tr>
                                        <tr role="row" class="even">
                                            <td tabindex="0" class="sorting_1">Bradley Greer</td>
                                            <td>Software Engineer</td>
                                            <td>London</td>
                                            <td>41</td>
                                            <td>2012/10/13</td>
                                            <td>$132,000</td>
                                        </tr>
                                        <tr role="row" class="odd">
                                            <td tabindex="0" class="sorting_1">Bradley Greer</td>
                                            <td>Software Engineer</td>
                                            <td>London</td>
                                            <td>41</td>
                                            <td>2012/10/13</td>
                                            <td>$132,000</td>
                                        </tr>
                                        <tr role="row" class="even">
                                            <td tabindex="0" class="sorting_1">Brenden Wagner</td>
                                            <td>Software Engineer</td>
                                            <td>San Francisco</td>
                                            <td>28</td>
                                            <td>2011/06/07</td>
                                            <td>$206,850</td>
                                        </tr>
                                        <tr role="row" class="odd">
                                            <td tabindex="0" class="sorting_1">Brenden Wagner</td>
                                            <td>Software Engineer</td>
                                            <td>San Francisco</td>
                                            <td>28</td>
                                            <td>2011/06/07</td>
                                            <td>$206,850</td>
                                        </tr>
                                        <tr role="row" class="even">
                                            <td tabindex="0" class="sorting_1">Bruno Nash</td>
                                            <td>Software Engineer</td>
                                            <td>Edinburgh</td>
                                            <td>21</td>
                                            <td>2012/03/29</td>
                                            <td>$433,060</td>
                                        </tr>
                                        <tr role="row" class="odd">
                                            <td class="sorting_1" tabindex="0">Bruno Nash</td>
                                            <td>Software Engineer</td>
                                            <td>Edinburgh</td>
                                            <td>21</td>
                                            <td>2012/03/29</td>
                                            <td>$433,060</td>
                                        </tr>
                                        <tr role="row" class="even">
                                            <td tabindex="0" class="sorting_1">Caesar Vance</td>
                                            <td>Pre-Sales Support</td>
                                            <td>New York</td>
                                            <td>29</td>
                                            <td>2011/12/12</td>
                                            <td>$106,450</td>
                                        </tr>--%>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12 col-md-5">
                                <div class="dataTables_info" id="dataTable3_info" role="status" aria-live="polite">Showing 1 to 10 of 11 entries</div>
                            </div>
                            <div class="col-sm-12 col-md-7">
                                <div class="dataTables_paginate paging_simple_numbers" id="dataTable3_paginate">
                                    <ul class="pagination">
                                        <li class="paginate_button page-item previous disabled" id="dataTable3_previous"><a href="#" aria-controls="dataTable3" data-dt-idx="0" tabindex="0" class="page-link">Previous</a></li>
                                        <li class="paginate_button page-item active"><a href="#" aria-controls="dataTable3" data-dt-idx="1" tabindex="0" class="page-link">1</a></li>
                                        <li class="paginate_button page-item "><a href="#" aria-controls="dataTable3" data-dt-idx="2" tabindex="0" class="page-link">2</a></li>
                                        <li class="paginate_button page-item next" id="dataTable3_next"><a href="#" aria-controls="dataTable3" data-dt-idx="3" tabindex="0" class="page-link">Next</a></li>
                                    </ul>
                                </div>
                            </div>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        function funcXoa(id) {
            var kt = confirm("Bạn có muốn xóa không ?")
            if (kt) {
                $.ajax({
                    type: "POST",
                    url: "/Admin/QlOrderTable/ListOrderTable.aspx/XoaTable",
                    data: "{idtable:"+id+"}",
                    contentType: "application/json; charset=utf-8",
                    //dataType: "json",
                    success: function (msg) {
                        alert(msg.d);
                        location.reload(); 
                    }
                });
            }
        }
     </script>
</asp:Content>

