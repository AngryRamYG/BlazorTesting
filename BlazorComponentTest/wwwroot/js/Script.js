    
let counter = 0;
let divSelected = document.querySelector(".testdiv")

export function test() {

    divSelected.innerHTML = counter;
    counter++;
}