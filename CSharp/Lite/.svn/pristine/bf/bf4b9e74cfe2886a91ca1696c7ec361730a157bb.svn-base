(function () {

    // get references to select list and display text box
    var br = document.getElementById('selectBranch');
    var userBranch = br.options[br.selectedIndex].text;
    var dte = document.getElementById('date');


    function getSelectedOption(br) {
        var opt;
        for (var i = 0, len = br.options.length; i < len; i++) {
            opt = br.options[i];
            if (opt.selected === true) {
                break;
            }
        }
        return opt;
    }

    // assign onchange handlers to the buttons
    document.getElementById('showVal').onclick = function () {
        dte.value = sel.value;
    }

}());
// immediate function to preserve global namespace