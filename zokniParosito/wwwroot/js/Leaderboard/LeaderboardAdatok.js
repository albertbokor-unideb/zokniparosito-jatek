function GetLeaderBoard(nehezseg) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Leaderboard/GetLeaderBoard',
            type: "GET",
            data: {
                nehezseg: nehezseg
            },
            dataType: "json",
            success: function (data) {
                resolve(data);
                console.log(data);
            },
            error: function (error) {
                reject(`Error ${error}`);
            }
        });
    });
}

