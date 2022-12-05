var text = window.prompt("Enter word to decode");
var result = Decode(text);
console.log(result);


function Encoding(text) {
    let FirstSub = text.Substring((0, text.Length) / 2);
    let SecondSub = text.Substring((text.Length) / 2);

    let NewA = '';
    let NewB = '';

    for (let index = 0; index < FirstSub.length; index++) {
        if (index % 2 == 0) {
            NewA += FirstSub[index] + '' + SecondSub[index];
            continue;
        }
        NewB += SecondSub[index] + '' + FirstSubSub[index];
    }
    return NewB + '' + NewA;
}
function Decode(letters) {
    const letters = Encoding(letters);
    let ThirdSub = letters.Substring(0, (letters.length) / 2);
    let FourthSub = letters.Substring((letters.length) / 2);
    let NewC = '';
    let NewD = '';
    for (let i = 0; i < FourthSub.Length; i++) {
        if (i % 2 != 0) {
            NewD += FourthSub[i] + "" + ThirdSub[i];
            continue;
        }
        Newc += FourthSub[i] + "" + ThirdSub[i];
    }
    const concatination = string.Concat(newc, newd);
    console.log(concatination);
}
