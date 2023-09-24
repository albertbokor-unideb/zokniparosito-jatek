function GetLeaderBoard(Nehezseg) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Leaderboard/GetLeaderBoard',
            type: "GET",
            data: { nehezseg: parseInt(nehezseg, 10) }, 
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

