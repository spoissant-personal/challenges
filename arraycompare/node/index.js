// function compareArrays(arr1, arr2) {
//     const sorted1 = [...arr1].sort()
//     const sorted2 = [...arr2].sort()
//     let v1 = sorted1.shift()
//     let v2 = sorted2.shift()
//     let same = []
//     let inA = []
//     let inB = []
//     while(v1 !== undefined || v2 !== undefined) {
//         if(v1 === v2) {
//             same.push( v1 )
//             v1 = sorted1.shift()
//             v2 = sorted2.shift()
//         } else if(v1 === undefined) {
//             inB = [...inB, v2, ...sorted2]
//             v1 = undefined
//             v2 = undefined
//         } else if(v2 === undefined) {
//             inA = [...inA, v1, ...sorted1]
//             v1 = undefined
//             v2 = undefined
//         } else if(v1 > v2) {
//             inB.push(v2)
//             v2 = sorted2.shift()
//         } else if(v2 > v1) {
//             inA.push(v1)
//             v1 = sorted1.shift()
//         }
//     }
//     return { same, inA, inB }
//     // a b c d f
//     // c d e f g
// }

function compareArrays2(arr1, arr2) {
    const same = arr1.filter(v => arr2.includes(v))
    const inA = arr1.filter(v => !same.includes(v))
    const inB = arr2.filter(v => !same.includes(v))

    return { same, inA, inB }
}

// console.log("compareArrays(['a', 'b', 'c', 'd', 'f'], ['c', 'd', 'e', 'f', 'g'])")
// console.log(compareArrays(['a', 'b', 'c', 'd', 'f'], ['c', 'd', 'e', 'f', 'g']))

console.log("compareArrays2(['a', 'b', 'c', 'd', 'f'], ['c', 'd', 'e', 'f', 'g'])")
console.log(compareArrays2(['a', 'b', 'c', 'd', 'f'], ['c', 'd', 'e', 'f', 'g']))
