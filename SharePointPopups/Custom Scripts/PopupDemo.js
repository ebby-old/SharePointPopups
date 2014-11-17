function openInDialog(dlgWidth, dlgHeight, dlgAllowMaximize, dlgShowClose, needCallbackFunction, pageUrl ) {
    var options = {
        url: pageUrl,
        width: dlgWidth,
        height: dlgHeight,
        allowMaximize: dlgAllowMaximize,
        showClose: dlgShowClose
    };

    if (needCallbackFunction) {
        options.dialogReturnValueCallback = Function.createDelegate(null, CloseDialogCallback);
    }
    SP.SOD.execute('sp.ui.dialog.js', 'SP.UI.ModalDialog.showModalDialog', options);
}


var redirectUrlValue = "";

function openInDialogAndRedirect(dlgWidth, dlgHeight, dlgAllowMaximize, dlgShowClose, pageUrl, redirectUrl ) {
    var options = {
        url: pageUrl,
        width: dlgWidth,
        height: dlgHeight,
        allowMaximize: dlgAllowMaximize,
        showClose: dlgShowClose
    };
    redirectUrlValue = redirectUrl;
    options.dialogReturnValueCallback = Function.createDelegate(null, CloseDialogAndRedirectCallback);

    SP.SOD.execute('sp.ui.dialog.js', 'SP.UI.ModalDialog.showModalDialog', options);
}

function CloseDialogCallback(dialogResult, returnValue) {
    if (dialogResult == SP.UI.DialogResult.OK) { // refresh parent page
        SP.SOD.execute('sp.ui.dialog.js', 'SP.UI.ModalDialog.RefreshPage', SP.UI.DialogResult.OK);

    }
    // if user click on Close or Cancel
    else if (dialogResult == SP.UI.DialogResult.cancel) { // Do Nothing or add any logic you want 
    } else { //alert("else " + dialogResult);
    }
}

function CloseDialogAndRedirectCallback(dialogResult, returnValue) {
    if (dialogResult == SP.UI.DialogResult.OK) { // refresh parent page
        SP.SOD.execute('sp.ui.dialog.js', 'SP.UI.ModalDialog.RefreshPage', SP.UI.DialogResult.OK);
        window.location.href = redirectUrlValue;
    }
    // if user click on Close or Cancel
    else if (dialogResult == SP.UI.DialogResult.cancel) { // Do Nothing or add any logic you want 
    } else { //alert("else " + dialogResult);
    }
}