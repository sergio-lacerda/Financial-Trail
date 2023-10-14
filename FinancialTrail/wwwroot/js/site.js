/***************** Getting Intraday Data ********************/
async function getIntradayData() {
    let _intradayData = [];    
    
    try {        
        const response = await $.ajax({
            type: "GET",
            url: "/Home/GetIntradayData", 
            dataType: "json"
        });   

        if (response != null) {
            _intradayData = [];
            let limit = response.length > 11 ? 11 : response.length;                 

            for (let i = 0; i < limit - 1; i++) {
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
            _intradayData.reverse();
        }
            
        return _intradayData;   

    } catch (error) {
        _intradayData = [['No data available', 0, 0, 0, 0]];
        return _intradayData;
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
    let _historicalPriceData = [];

    try {
        const response = await $.ajax({
            type: "GET",
            url: "/Home/GetHistoricalPriceData",
            dataType: "json"
        });        

        if (response != null) {
            _historicalPriceData = [ ];
            let limit = response['historical'].length > 366 ? 366 : response.length;

            for (let i = 0; i < limit - 1; i++) {
                _historicalPriceData.push(
                    [
                        response['historical'][i]['date'],                
                        response['historical'][i]['close']
                    ]
                );
            }

            _historicalPriceData.reverse();
            _historicalPriceData.unshift(['Date', 'Close price']); 
        }
                
        return _historicalPriceData;


    } catch (error) {
        _historicalPriceData = [['Date', 'Close price'], ['No data available', 0]];
        return _historicalPriceData;
    }
}



/***************** Drawing Historical Price Line Chart ********************/

google.charts.load('current', { 'packages': ['corechart'] });
google.charts.setOnLoadCallback(drawLineChart);

async function drawLineChart() {
    let data = google.visualization.arrayToDataTable(await getHistoricalPriceData());

    let options = {        
        colors: ['green'],
        legend: 'none'
    };

    let chart = new google.visualization.LineChart(document.getElementById('historicalprice_chart'));

    chart.draw(data, options);
}


/***************** Getting Dividends by Year Data ********************/
async function getDividendsByYear() {
    let _divByYear = [];

    try {
        const response = await $.ajax({
            type: "GET",
            url: "/Home/GetDividendsByYear",
            dataType: "json"
        });
        
        if (response != null) {
            _divByYear = [];

            let limit = response.length > 10 ? 10 : response.length;

            for (let i = 0; i < limit; i++) {
                _divByYear.push(
                    [
                        response[i]['year'],
                        response[i]['total'],
                        response[i]['total']
                    ]
                );
            }

            _divByYear.reverse();
            _divByYear.unshift(['Year', 'Total', { role: 'annotation' }]);
        }
                
        return _divByYear;

    } catch (error) {
        _divByYear = [['Year', 'Total'], ['No data available', 0]];
        return _divByYear;
    }
}


/***************** Drawing Dividends by Year Column Chart ********************/


google.charts.load("current", { packages: ['corechart'] });
google.charts.setOnLoadCallback(drawColumnChart);
async function drawColumnChart() {
    let data = google.visualization.arrayToDataTable(await getDividendsByYear());

    let view = new google.visualization.DataView(data);
    

    let options = {        
        colors: ['green'],
        bar: { groupWidth: "95%" },
        legend: { position: "none" },
    };
    let chart = new google.visualization.ColumnChart(document.getElementById("dividendsByYear_chart"));
    chart.draw(view, options);
}