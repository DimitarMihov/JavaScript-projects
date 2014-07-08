taskName = "<br>";
message = "<br>"

function Main(bufferElement) {

        SolveProblem();
}

function SolveProblem(arr) {
    
  //  var arr = [
  //   '3 5',
  //'dr dl dl ur ul',
  //'dr dr ul ul ur',
  //'dl dr ur dl ur'
  //  ]



    var rAndCStr = arr[0].split(" ");
    var rows = parseInt(rAndCStr[0]);
    var cols = parseInt(rAndCStr[1]);

    arr = arr.slice(1);
    var arrValues = [];//array with values
    debugger
    for (var i = 0; i < rows; i++) {
        arrValues[i] = [];
        for (var j = 0; j < cols; j++) {
            if (j === 0) {
                arrValues[i][j] = (Math.pow(2, i));
            }
            else {
                arrValues[i][j] = arrValues[i][j - 1] + 1;
            }
        }
    }

    //debugger
    var dirsArr = arr;
    var len = dirsArr.length;

    for (var i = 0; i < len; i++) {
        dirsArr[i] = dirsArr[i].split(' ');
    }

    //WriteLine(Format("arrValues \n{0}", arrValues));
    //WriteLine(Format("dirsArr {0}", dirsArr[0]));

    //var posStr = [0,0];     //стартова позиция
    var row = 0; //current position X
    var column = 0; //current position Y
    var nextDir;

    var used = {};
    var sum = 0;
    var dir = 0;
    //var count = 0; трябва да върнем позицията вместо броя стъпки


    //debugger
    while (true) {

        

        if (!inRange(row, rows) || !inRange(column, cols)) {
            return "successed with " + sum;
            //WriteLine(Format("successed with {0}", sum));
        }
        if (used[row * cols + column]) {
            return "failed at (" + row + ", " + column + ")"; //трябва да върнем позицията вместо броя стъпки
            //WriteLine(Format("failed at {0}, {1}", row, column));
            //break;
        }
        //count++;
        used[row * cols + column] = true;
        //sum += row * cols + column + 1;
        sum += arrValues[row][column];

        nextDir = dirsArr[row][column];
        switch (nextDir) {
            case 'dr':
                row = row + 1;
                column = column + 1;
                break;
            case 'ur':
                row = row - 1;
                column = column + 1;
                break;
            case 'ul':
                row = row - 1;
                column = column - 1;
                break;
            case 'dl':
                row = row + 1;
                column = column - 1;
                break;
            default:
                //WriteLine(Format("Error in switch"));

        }



        //WriteLine(Format("nextDir {0}", nextDir));
        //dir++;
        //dir %= dirs.length;
    }

    function inRange(pos, range) {
        return 0 <= pos && pos < range;
    }
}

