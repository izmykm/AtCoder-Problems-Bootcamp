const lines=[];
const reader = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
});

reader.on('line', function (line) {
  lines.push(line);
});

//入力後の処理
reader.on('close', function () {
    const input = (lines[0] as string).split(" ");
    const a = +input[0];
    const b = +input[1];

    if (a == b) {
        console.log(1);
        return;
    } 
    let res = 0;
    let numSockets = 1;
    while(numSockets < b){
        numSockets =(numSockets - 1) + a;
        res++;
    }
    console.log(res);
});