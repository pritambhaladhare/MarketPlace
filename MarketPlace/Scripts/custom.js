$(document).ready(function () {





 

    /* Sign up button */

    $("#btn-signup").click(function () {
        $('#signUpModal').modal('show');
    });

    $("#ProductName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Search/GetProducts/",
                type: "POST",
                dataType: "json",
                data: { ProductName: request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return { label: item.ProductName, value: item.ProductName };
                    }))

                }
            })
        },
        messages: {
            noResults: '',
            results: function (resultsCount) { }
        }
    });  
    

});