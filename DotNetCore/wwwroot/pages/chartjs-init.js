
/**
* Theme: Syntra Admin Template
* Author: Mannat-themes
* chartjs
*/


( function ( $) {
    "use strict";

   
    //bar chart
    var ctx=document.getElementById( "barChart");
    ctx.height=160;
    var myChart=new Chart( ctx, {
        type: 'bar', data: {
            labels: [ "January", "February", "March", "April", "May", "June", "July"], datasets: [ {
                label: "My First dataset", data: [ 65, 59, 80, 81, 56, 55, 40], borderColor: "rgba(155, 241, 225, 0.5)", borderWidth: "0", backgroundColor: "rgba(155, 241, 225, 0.5)"
            }
            , {
                label: "My Second dataset", data: [ 28, 48, 40, 19, 86, 27, 90], borderColor: "rgba(196,88,80,0.09)", borderWidth: "0", backgroundColor: "rgba(196,88,80,0.07)"
            }
            ]
        }
        , options: {
            scales: {
                yAxes: [ {
                    ticks: {
                        beginAtZero: true
                    }
                }
                ]
            }
        }
    }
    );
    //line chart
    var ctx=document.getElementById( "lineChart");
    ctx.height=150;
    var myChart=new Chart( ctx, {
        type: 'line', data: {
            labels: [ "January", "February", "March", "April", "May", "June", "July"], datasets: [ {
                label: "My First dataset", borderColor: "rgba(0,0,0,.09)", borderWidth: "1", backgroundColor: "rgba(22,205,250,0.07)", data: [ 22, 44, 67, 43, 76, 45, 12]
            }
            , {
                label: "My Second dataset", borderColor: "rgba(30, 50,100, 0.9)", borderWidth: "1", backgroundColor: "rgba(245, 114, 161, 0.5)", pointHighlightStroke: "rgba(26,179,148,1)", data: [ 16, 32, 18, 26, 42, 33, 44]
            }
            ]
        }
        , options: {
            responsive: true, tooltips: {
                mode: 'index', intersect: false
            }
            , hover: {
                mode: 'nearest', intersect: true
            }
        }
    }
    );
    //pie chart
    var ctx=document.getElementById( "pieChart");
    ctx.height=150;
    var myChart=new Chart( ctx, {
        type: 'pie', data: {
            datasets: [ {
                data: [ 25, 20, 15], backgroundColor: [ "#254080", "#b59bc9", "#cccc99"], hoverBackgroundColor: [ "#254080", "#b59bc9", "#cccc99"]
            }
            ], labels: [ "navy blue", "purple", "yellow"]
        }
        , options: {
            responsive: true
        }
    }
    );
    //doughut chart
    var ctx=document.getElementById( "doughutChart");
    ctx.height=150;
    var myChart=new Chart( ctx, {
        type: 'doughnut', data: {
            datasets: [ {
                data: [ 45, 25, 20, 10], backgroundColor: [ "#242440", "#8596a7", "#a7cccc", "#eeeedb"], hoverBackgroundColor: [ "#242440", "#8596a7", "#a7cccc", "#eeeedb"]
            }
            ], labels: [ "blue", "grey", "green", "yellow"]
        }
        , options: {
            responsive: true
        }
    }
    );
    //polar chart
    var ctx=document.getElementById( "polarChart");
    ctx.height=150;
    var myChart=new Chart( ctx, {
        type: 'polarArea', data: {
            datasets: [ {
                data: [ 15, 18, 9, 19], backgroundColor: [ "#242440", "#8596a7", "#a7cccc", "#eeeedb"]
            }
            ], labels: [ "blue", "grey", "green", "yellow"]
        }
        , options: {
            responsive: true
        }
    }
    );
    // single bar chart
    var ctx=document.getElementById( "singelBarChart");
    ctx.height=150;
    var myChart=new Chart( ctx, {
        type: 'bar', data: {
            labels: ["ASP", "AddI SP", "SP", "AddI DIG", "DIG", "AddI IGP"], datasets: [ {
             label: "My First dataset", data: [ 80, 70, 20, 30, 10, 5], borderColor: "rgba(60,186,159,1)", borderWidth: "0", backgroundColor: "rgba(60,186,159,0.2)"
            }
            ]
        }
        , options: {
            scales: {
                yAxes: [ {
                    ticks: {
                        beginAtZero: true
                    }
                }
                ]
            }
        }
    }
    );
   
}

)( jQuery);