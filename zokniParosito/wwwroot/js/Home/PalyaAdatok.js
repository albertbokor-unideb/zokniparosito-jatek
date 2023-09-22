function GetPalyak() {
    $.ajax({
        url: '/Jatek/GetPalyak',
        type: "GET",
        dataType: "json", 
        success: function (data) {
            console.log(data);
        },
        error: function (error) {
            console.log(`Error ${error}`);
        }
    });
}
function GetPalyakByFokozat(fokozat) {
    $.ajax({
        url: '/Jatek/GetPalyakByFokozat',
        type: "GET",
        data: { fokozat: parseInt(fokozat, 10) }, // Ensure fokozat is an integer
        dataType: "json",
        success: function (data) {
            console.log(data);
        },
        error: function (error) {
            console.log(`Error ${error}`);
        }
    });
}
