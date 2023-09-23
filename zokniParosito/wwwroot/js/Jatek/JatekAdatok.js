function GetZoknikByNehezseg(nehezseg) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Jatek/GetZoknikByNehezseg',
            type: "GET",
            data: { nehezseg: parseInt(nehezseg, 10) }, // Ensure fokozat is an integer
            dataType: "json",
            success: function (data) {
                resolve(data); // Az adatok visszaadása a Promise-szel
            },
            error: function (error) {
                reject(`Error ${error}`);
            }
        });
    });
}

function GetZoknik() {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Jatek/GetZoknik',
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

