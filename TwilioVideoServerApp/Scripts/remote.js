


$(document).ready(function () {

    $("#btnGenerateTokenRemote").click(function () {
        $.ajax({
            type: "GET",
            url: "/api/Video/GetToken",
            data: { identity: "remote" },
            contentType: "application/text; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data);
                var accessToken = data;
                var accessManager = Twilio.AccessManager(accessToken);
                var client = Twilio.Conversations.Client(accessManager);
                console.log(client)

                client.inviteToConversation('local').then(onInviteAccepted);
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
