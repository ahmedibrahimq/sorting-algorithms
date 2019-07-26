//
//Heap Sort Algorithm using max heap
//Input: a  sequence of numbers
//output: numbers in sorted sequence
//run-time :O(nlg(n))
//

var A = [4,1,3,2,16,9,10,14,8,7];
var heapsize = A.length - 1;

function in_Range(A,i) {
    return (i <= heapsize);
}

function left(i){return (2 * i)}
function right(i){return (2 * i + 1)}
function parent(i){return Math.floor(i / 2)}

function max_Heapify(A, i) {
    var l = left(i);
    var r = right(i);
    var largest = i;

    if (in_Range(A,l) && A[i] < A[l]) {
        largest = l;    
    }

    if(in_Range(A,r) && A[r] > A[largest]) {
        largest = r;
    }

    if (i != largest) {
        exchange(i,largest);
        if (largest <= heapsize/2){
            max_Heapify(A,largest);
        }
    }

}

function build_Max_Heap(A) {
    var len = Math.floor((A.length)/2);
    for(var j = len - 1; j >= 0; j--){
        max_Heapify(A,j);
    }

}

function heap_Sort(A) {
    build_Max_Heap(A);
    for (var k = A.length - 1; k >= 1; k--) {
        exchange(k, 0);
        heapsize = heapsize - 1;
        max_Heapify(A,0);
    }
}

function exchange(x,y) {
    var temporary = A[x];
    A[x] = A[y];
    A[y] = temporary;
}

console.log(A);
heap_Sort(A);
console.log(A);
