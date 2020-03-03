$(document).ready(function () {
    CKEDITOR.replace("#txtContent");
    $("#btnSelectImage").click(function () {
        var finder = new CKFinder();
        finder.selectActionFunction = function (fileUrl) {
            $("#txtImages").val(fileUrl);
        }
        finder.popup();
    })
});