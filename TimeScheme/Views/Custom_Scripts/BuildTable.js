$(document).ready(function () {

    $.ajax({
        url: '/ToDoes/BuildTodoTable',
        success: function (result) {
            $('#tableDiv').html(result);

        }
    })
}
    
    
    )