$(document).ready(function () {

    $("#_tblGeneralLedgers").DataTable({
        "processing": false,
        "serverSide": true,
        "filter": true,
        "orderMulti": false,
        "responsive": true,
        "language": {
            "search": "Search by Ledger Name:"
        },
        "ajax": {
            "url": "/GeneralLedgers/GeneralLedgersList",
            "type": "POST",
            "datatype": "json"
        },
        "columns": [
            { "data": "accountID", "name": "AccountID", "autoWidth": true },
            { "data": "description", "name": "Description", "autoWidth": true },
            { "data": "shortName", "name": "ShortName", "autoWidth": true },
            { "data": "currencyID", "name": "Currency", "autoWidth": true }
        ]
    });
    // Setup - add a text input to each header cell 
    //$('#_tblGeneralLedgers thead th').each(function () {
    //    var title = $('#_tblGeneralLedgers thead th').eq($(this).index()).text();
    //    $(this).html('<input type="text" placeholder="Search ' + title + '" />');      
    //});


    $('#_tblGeneralLedgers tbody').on('click', 'tr', function () {
        $("#_tblGeneralLedgers tbody tr").removeClass('row_selected');
        $(this).addClass('row_selected');
        //Get the hidden Attributes
        $("#myControls").removeAttr('hidden');     

        var currentRow = $(this).closest("tr");

        var col1 = currentRow.find("td:eq(0)").text();
      
        var link = document.getElementById("btnedit");
        link.setAttribute('href', "/GeneralLedgers/EditGeneralLedger?AccountID=" + col1 +"");

        var link = document.getElementById("btnview");
        link.setAttribute('href', "/GeneralLedgers/ViewGeneralLedger?AccountID=" + col1 + "");

        var link = document.getElementById("btndisable");
        link.setAttribute('href', "/GeneralLedgers/DisableGL?AccountID=" + col1 + "");
    });
});

