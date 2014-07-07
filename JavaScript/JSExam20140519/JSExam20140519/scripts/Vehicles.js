taskName = "<br>";
message = "<br>"

function Main(bufferElement) {

    var number = ReadLine("Enter a number: ");

    SetSolveButton(function () {
        SolveProblem(number.value);
    });
}

function SolveProblem(number) {

    var intNumber = parseInt(number);
    var tenProduct = intNumber / 10 | 0;
    var fourProduct = intNumber / 4 | 0;
    var threeproduct = intNumber / 3 | 0;

    var count = 0;
    debugger

    for (var n = 0; n <= threeproduct; n++) {
        for (var j = 0; j <= fourProduct; j++) {
            for (var i = 0; i <= tenProduct; i++) {

                if (((i * 10 + j * 4 + n * 3) === intNumber) && (intNumber % (i * 10 + j * 4 + n * 3) === 0)) {
                    count++
                }
            }

        }
    }

    console.log(count);
}

