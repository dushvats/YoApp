var YoYoTestViewModel = function (data, baseUri) {
    self = this;
    self.data = data;
    self.baseUri = baseUri;

    self.initialiseTimer = function (maxValue) {
        $("#circle-1").Circlebar({
            maxValue: maxValue,
            fontSize: "14px",
            triggerPercentage: true
        });
    }
}

var pageNamespace = {};
pageNamespace.viewModel = new YoYoTestViewModel("data", "~/YoYoTest");
pageNamespace.viewModel.initialiseTimer(10);