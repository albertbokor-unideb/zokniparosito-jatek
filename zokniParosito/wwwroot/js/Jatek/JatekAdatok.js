function GetZoknik() {
    $.ajax({
        url: '/Jatek/GetZoknik',
        type: "GET",
        success: function (data) {
            let x = JSON.stringify(data);
            console.log(x);
        },
        error: function (error) {
            console.log(`Error ${error}`);
        }
    });
}
