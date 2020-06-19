


$(document).ready(function () {

    $("#btnGenerateTokenLocal").click(function () {
        $.ajax({
            type: "GET",
            url: "/api/Video/GetToken",
            data: { identity: "local" },
            contentType: "application/text; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data);
                var accessToken = data;
                var accessManager = Twilio.AccessManager(accessToken);
                var client = Twilio.Conversations.Client(accessManager);
                
                console.log(client);
                client.listen().then(function () {
                    console.log("asdasd");
                    client.on('invite', function (invite) {
                        invite.accept().then(onInviteAccepted);
                    });
                });
            }, //End of AJAX Success function  

            failure: function (data) {
                alert(data.responseText);
            }, //End of AJAX failure function  
            error: function (data) {
                alert(data.responseText);
            } //End
        });
    });
});


// Begin listening for invites to Twilio Video conversations.


//const { connect } = require('twilio-video');

//connect(accessToken).then(room => {
//    console.log(`Successfully joined a Room: ${room}`);
//    room.on('participantConnected', participant => {
//        console.log(`A remote Participant connected: ${participant}`);
//    });
//}, error => {
//    console.error(`Unable to connect to Room: ${error.message}`);
//});