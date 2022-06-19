$(function () {

    $(document).on("click", ".task-update-partial", function () {
        refreshTaskListPartial();
    });

    function refreshTaskListPartial() {
        $.ajax({
            method: "GET",
            url: "/Task/IndexPartial",
            success: function (result) {
                $(".partial").html(result);
            }
        });
        console.log("wtf");
    }
});
