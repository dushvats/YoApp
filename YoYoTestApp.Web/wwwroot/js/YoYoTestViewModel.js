var YoYoTestViewModel = function (data, baseUri, maxValue) {
    self = this;
    self.data = data;
    self.baseUri = baseUri;
    self.maxValue = maxValue;
    self.timerStarted = false;

    self.hideTimer = function () {
        document.getElementById('circle-1').style.display = "none";
    }
    self.showTimer = function () {
        document.getElementById('circle-1').style.display = "block";
    }
    self.disableStartTimerButton = function () {
        document.getElementById("startTimerButton").disabled = true;
        $("#startTimerButton").toggleClass('disabled');
    }

    self.hideTimer();

    self.initialiseTimer = function (maxValue) {
        $("#circle-1").Circlebar({
            maxValue: maxValue,
            fontSize: "14px",
            triggerPercentage: true
        });
    }
    
    self.startTimer = function () {
        if (!self.timerStarted) {            
            self.showTimer();
            self.disableStartTimerButton();
            self.initialiseTimer(self.maxValue);
            self.timerStarted = true;
        }
    }
}
