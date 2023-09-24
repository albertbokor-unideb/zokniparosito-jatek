function GetPalyak() {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Jatek/GetPalyak',
            type: "GET",
            dataType: "json",
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(`Error ${error}`);
            }
        });
    });
}

function GetPalyakByFokozat(fokozat) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Jatek/GetPalyakByFokozat',
            type: "GET",
            data: { fokozat: parseInt(fokozat, 10) }, // Ensure fokozat is an integer
            success: function (data) {
                resolve(data);
            },
            error: function (error) {
                reject(`Error ${error}`);
            }
        });
    });
}