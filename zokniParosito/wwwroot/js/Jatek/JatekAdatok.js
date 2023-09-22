function GetZoknik() {
    $.ajax({
        url: '/Jatek/GetZoknik',
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
