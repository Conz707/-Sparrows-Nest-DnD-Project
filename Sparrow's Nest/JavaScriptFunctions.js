function numberInputOnly(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode < 48 || charCode > 57) {  //if keypress character code < 48 or more than 57 do nothing (ascii char codes)
        return false;
    }
    return true;    //else allow key input
}