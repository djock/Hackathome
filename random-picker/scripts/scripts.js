$(document).ready(function() {
    var t = new Array,
        n = $("#display-result");
    $("#input_listName").keydown(function(n) {
        13 == n.which && ("" == $("#input_listName").val() ? alert("Warning!\nYou did not add any items.") : ($(".ul_current").append($("<li>", {
            text: $("#input_listName").val()
        })), $("#input_listName").each(function() {
            t.push($(this).val())
        }), $("#input_listName").val("")))
    }), $("#btn_pickFromList").click(function() {
        var x = Math.floor(Math.random() * t.length),
            a = 0;
        for (0 === t.length && alert("Warning!\nYou did not add any items."), a = 0; a < t.length && (setTimeout(function(i) {
                return function() {
                    n.text(t[i].toUpperCase())
                    if( i === x ) {
                    n.addClass("winner animated bounceIn infinite ");
                }
                }
            }(a), 200 * a), a !== x); a++);
    })
});
