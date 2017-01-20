function FirstNameIsEmpty(){
    if (document.getElementById("txtFirstName").value == "") {
        return "名字不能为空";
    }
    else {
        return "";
    }
}

function IsValid(){
    var firstNameEmptyMessage = FirstNameIsEmpty();
    var FinalErrorMessage = "Errors:";
    if (firstNameEmptyMessage != "")
    {
        FinalErrorMessage += "\n"+firstNameEmptyMessage;
    }

    if (FinalErrorMessage != "Errors:") {
        alert(FinalErrorMessage);
        return false;
    }
    else { return true;}
}