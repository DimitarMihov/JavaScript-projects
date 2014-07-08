taskName = "<br>";
message = "<br>"

function Main(bufferElement) {

    var xNumber = ReadLine("Enter a number for X: ");
    var yNumber = ReadLine("Enter a number for Y: ");

    SetSolveButton(function () {
        SolveProblem(xNumber.value, yNumber.value);
    });
}

function SolveProblem(x, y) {

    //var xN = parseInt(x);
    //var yN = parseInt(y);
    var n,
    x = readline(),
    y = readline();
    (x * y > 0) ? ((x > 0) ? n = 1 : n = 2) : ((x > 0) ? n = 3 : n = 0)
    console.log(n)


    WriteLine(Format("{0}", n));
}

