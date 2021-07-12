// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


// Write your JavaScript code.

// Return company for selected region

$(function () {
    $(document).on('change', '#select', function (e) {
        e.preventDefault()
        let value = this.value;
        console.log(value);
        $.ajax({
            url: '/api/Info/GetCompany',
            dataType: "html",
            type: "GET",
            contentType: 'application/json; charset=utf-8',
            data: { id: value },
            success: function (data) {                
                $('#myList').html(data);
            },
            error: function (xhr) { }
        });
    });
});

// Return information about customer

$(function () {
    $(document).on('click', '#myList a', function (e) {
        e.preventDefault()
        let value = this.getAttribute("data-cust-id");
        $.ajax({
            url: '/api/Info/GetInfo',
            dataType: "html",
            type: "GET",
            contentType: 'application/json; charset=utf-8',
            data: { id: value },            
            success: function (data) {
                $("#info-card").removeAttr('hidden');
                $('#info').html(data);
            },
            error: function (xhr) { }
        });        
    });    
});

// Update StatusID in maintable for customer

$(function () {
    $(document).on('click', '#saveBtn', function (e) {
        e.preventDefault();
        let chkBox = $("#chkBox").prop('checked') ? "2" : "1"; 
        let value = $("#chkBox").attr("data-id");
        $.ajax({
            url: '/api/Status/UpdateStatus',
            dataType: "html",
            type: "GET",
            contentType: 'application/json; charset=utf-8',
            data: { id: value, status: chkBox },
            success: function (data) {
                console.log("status changed");
            },
            error: function (xhr) { }
        });
    });
});
