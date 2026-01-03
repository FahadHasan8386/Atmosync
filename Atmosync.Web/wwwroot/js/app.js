window.addEventListener("DOMContentLoaded", () => {
    console.log("Js load properly");
});


let tempChart, humidityChart;

function renderTempChart(labels, values) {
    const ctx = document.getElementById('tempChart');
    if (!ctx) return;

    if (tempChart) {
        tempChart.destroy();
    }
    tempChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: [{
                label: 'Temperature',
                data: values,
                borderWidth: 2,
                tension: 0.4
            }]
        },
        options: {
            responsive: true,
            scales: {
                y: {
                    min: 0,
                    max: 100,
                    ticks: {
                        stepSize: 500
                    }
                }
            }
        }
    });
}


function renderHumidityChart(labels, values) {
    const ctx = document.getElementById('humidityChart');
    if (!ctx) return;

    if (humidityChart) {
        humidityChart.destroy();
    }
    humidityChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: [{
                label: 'Humidity',
                data: values,
                borderWidth: 2,
                tension: 0.4
            }]
        },
        options: {
            responsive: true,
            scales: {
                y: {
                    min: 0,
                    max: 100,
                    ticks: {
                        stepSize: 500
                    }
                }
            }
        }
    });
}

