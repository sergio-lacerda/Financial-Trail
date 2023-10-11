/***************** Getting Intraday Data ********************/
async function getIntradayData() {
    try {        
        const response = await $.ajax({
            type: "GET",
            url: "/Home/GetIntradayData", 
            dataType: "json"
        });        

        let _intradayData = ['', 0, 0, 0, 0];

        if (response != null) {
            _intradayData = [];
            let limit = response.length > 11 ? 11 : response.length;                 

            for (var i = 0; i < limit - 1; i++) {
                let auxDate = new Date(response[i]['date'])
                let hour = auxDate.getHours();
                let minut = auxDate.getMinutes();
                hour = hour < 10 ? '0' + hour.toString() : hour.toString();
                minut = minut < 10 ? '0' + minut.toString() : minut.toString();
                _intradayData.push(
                    [
                        hour + ':' + minut,    
                        response[i]['high'],
                        response[i]['open'],                                                
                        response[i]['close'],
                        response[i]['low']
                    ]
                );
            }
        }

        _intradayData.reverse();       
        return _intradayData;
   

    } catch (error) {
        
    }
}


/***************** Drawing Intraday Candlestick Chart ********************/

google.charts.load('current', { 'packages': ['corechart'] });
google.charts.setOnLoadCallback(drawCandlestickChart);

async function drawCandlestickChart() {
    let data = google.visualization.arrayToDataTable(await getIntradayData(), true);

    let options = {
        legend: 'none',
        colors: ['green']
    };

    let chart = new google.visualization.CandlestickChart(document.getElementById('price_chart'));

    chart.draw(data, options);
}


/***************** Getting Historical Price Data ********************/
async function getHistoricalPriceData() {
    try {
        const response = await $.ajax({
            type: "GET",
            url: "/Home/GetHistoricalPriceData",
            dataType: "json"
        });

        let _historicalPriceData = ['', 0];

        if (response != null) {
            _historicalPriceData = [ ];
            let limit = response['historical'].length > 366 ? 366 : response.length;

            for (var i = 0; i < limit - 1; i++) {
                _historicalPriceData.push(
                    [
                        response['historical'][i]['date'],                
                        response['historical'][i]['close']
                    ]
                );
            }
        }

        _historicalPriceData.reverse();
        _historicalPriceData.unshift(['Date', 'Close price']);         
        return _historicalPriceData;


    } catch (error) { }
}



/***************** Drawing Historical Price Line Chart ********************/

google.charts.load('current', { 'packages': ['corechart'] });
google.charts.setOnLoadCallback(drawChart);

async function drawChart() {
    let data = google.visualization.arrayToDataTable(await getHistoricalPriceData());

    let options = {        
        colors: ['green'],
        legend: 'none'
    };

    let chart = new google.visualization.LineChart(document.getElementById('historicalprice_chart'));

    chart.draw(data, options);
}