
$(document).ready(function () {
    CKEDITOR.replace("#txtContent", { customConfig: 'admin/js/plugins/ckeditor/config.js'});
    $("#btnSelectImage").click(function () {
        var finder = new CKFinder();
        finder.selectActionFunction = function (fileUrl) {
            $("#txtImages").val(fileUrl);
        }
        finder.popup();
    })
});