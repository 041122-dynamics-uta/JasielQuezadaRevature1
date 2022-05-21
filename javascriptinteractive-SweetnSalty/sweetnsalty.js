document.getElementById("rules").addEventListener("keypress", function(e){ 
  if (e.key === "Enter")
  {
      e.preventDefault();
      document.getElementById("rules").click();
  }
});
document.getElementById("enter1").addEventListener("keypress", function(e){ 
  if (e.key === "Enter")
  {
      e.preventDefault();
      document.getElementById("enter1").click();
  }
});
document.getElementById("enter2").addEventListener("keypress", function(e){ 
  if (e.key === "Enter")
  {
      e.preventDefault();
      document.getElementById("enter2").click();
  }
});
document.getElementById("enter3").addEventListener("keypress", function(e){ 
  if (e.key === "Enter")
  {
      e.preventDefault();
      document.getElementById("enter3").click();
  }
});
function entergame(){
  data[0] = document.getElementsByid("entergame")[0].value;
  document.getElementById("entergame").style.display = 'block';
  //var firstInput = document.getElementById()
}

var num1, num2;
function enter1(){
  let errmessage = []
  num1 = document.getElementById("num1").value;
  console.log(num1);
  if (num1 >= 0)
  {
  document.getElementById("error11").innerHTML = '';
  document.getElementById("step1").style.display = "block"
  }
  else document.getElementById("err1").append('Number cannot be negative');
  
}

function enter2(){
  num2 = document.getElementById("secondnum").value
    var num1 = parseInt(num1);
    var num2 = parseInt(num2);
    if (num2 > num1 && num2-num1>200 && num2-num1<10000)
    {
        document.getElementById("error2").innerHTML = '';
        document.getElementById("step3").style.display = "block"
        //console.log(num2)

    }
    else document.getElementById("error2").append('Your numbers must be at least 200 apart but not more than 1000.')
}
function calcfunc()
{

}



//page reset

rulesButton.addEventListener('load', (event) => {
  console.log('rules is loaded');
});


function resetPage() {
  location.reload();
}
enter1Button.addEventListener('click', (e) => 
{ 
  let sw = 0; 
  let st = 0;
  let swst = 0;
  let check = 0; //keep count of how many of each there is
  let line = '';
  userinput = input.value;
  if (userinput > Num) 
  {
    console.log(s);
     if (s % 20 == 0)//seperate by 20     
    {
         //console.log(line)
         document.write('');
         line = '';
     }  
    if (s % 3 == 0 && s % 5 == 0)//divisible by 3 & 5
     {
       column.innerHTML += "<div>Sweet'nSalty</div>";   
       //console.log("Sweet'nSalty ");
        swst++;
     }
  }
});
enter2Button.addEventListener('submit', (e) => 
{

});








//function to create the reset submitButton
function createResetButton() {
  body.innerHTML += `<button type="reset" id="reset">Restart The GAME ??</button>`
  resetButton = document.getElementById('reset');
  resetButton.addEventListener('click', (e) => {
    e.preventDefault();
    resetPage();
    toggleSubmitButton();
  });
}

//print sweet,salty,sweetnsalty and numbers to screen
//40 number per line with a comma
//need a reset button



// function enter() {
//   document.getElementById("button").innerHTML = "Enter Your Starting Number";
// }


// button.addEventListener('click', updateButton);

// function update() {
//   if (button.value === 'enter') {
//     button.value = 'Enter';
//     paragraph.textContent = 'Enter!';
//   } 
// }



// const button = document.querySelector('input');
// const p1 = document.querySelector('p1');


// var firstinput = document.getElementById("startnum")
// firstinput.addEventListener("keypress", function(e){ //this eventlistener and function lets user press enter as an alternative to clicking submit
//     if (e.key === "Enter")
//     {
//         e.preventDefault();
//         document.getElementById("btn1").click();
//     }
// })
// function buttonFunc()
// {   firstinput = document.getElementById("startnum").nodeValue;
//     console.log(firstinput);
//     let errmessage = []

//     if (firstinput >= 0)
//     {firstinput = document.getElementById("startnum");}
//     else errmessage.push("Number cannot be negative")
// }
// function swtSlt()
/////c#code

// let sw = 0; 
// let st = 0;
// let swst = 0;
// let check = 0; //keep count of how many of each there is
// let line = '';
// for ( var s = 1; s <= 1000; s++)// Print the numbers 1 to 1000 to the console. 
// {
//     console.log(s);
//     if (s % 20 == 0)//seperate by 20 
//     {
//         console.log(line)
//         line = '';
//     }  
//     if (s % 3 == 0 && s % 5 == 0)//divisible by 3 & 5
//     {
//       column.innerHTML += "<div>Sweet'nSalty</div>";
//         //console.log("Sweet'nSalty ");
//         swst++;
//     }
//     else if ( s % 3 == 0) //divisible by 3
//     {
//         column.innerHTML += "<div>Sweet</div>";
//         //console.log("Sweet");
//         sw++;
//     }
//     else if (s % 5 == 0)//divisble by 5
//     {
//         column.innerHTML += "<div>Salty</div>";
//         //console.log("Salty");
//         st++;
//     }            
//     else
//     {
//         column.innerHTML += "<div>" + s + "</div>";
//         //console.log(s);//just print number
//     }
//     check++;                
// }

//         column.innerHTML += "<div>Salty</div>";
//         console.log();
//         console.log(`The Number of Sweet is: ${sw}`);
//         console.log(`The Number of Sweet is: ${st}`);
//         console.log(`The Number of Sweet is: ${swst}`);
//         console.log();