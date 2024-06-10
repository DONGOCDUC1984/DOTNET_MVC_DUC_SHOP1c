$(document).ready(function () {
    DrawChart();
});
async function DrawChart() {
    var ChartType = $("#ChartType").val();
    var ChartView = document.getElementById("ChartView");
    ChartView.innerHTML = "&nbsp;";
    $("#ChartView").append
        ('<canvas id="myChart" style="max-width:500px; max-height:500px;"></canvas>');
    try {
        var res = await fetch("/AnnualProfit/GetProfitData");
        var data = await res.json();
        // console.log(data);
        if (res.status == 200) {
            var _chartLabels = data[0];
            // console.log(_chartLabels);
            var _chartData = data[1];
            // console.log(_chartData);
            const ctx = document.getElementById('myChart');
            new Chart(ctx, {
                type: ChartType,
                data: {
                    labels: _chartLabels,
                    datasets: [{
                        data: _chartData,
                        borderWidth: 1
                    }]
                },
                options: {
                    scales: {
                        y: {
                            beginAtZero: true
                        }
                    }
                }
            });

        }
    }
    catch (err) {
        console.log(err);
    }

};


//If $("#ChartType") is changed, DrawChart() will be called
$("#ChartType").change(function () {
    DrawChart();
});