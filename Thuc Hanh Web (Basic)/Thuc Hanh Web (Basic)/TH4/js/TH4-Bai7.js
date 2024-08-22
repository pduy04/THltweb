


function themClick(){
    var hang = document.getElementById("hang");
    var btnThem= document.getElementById("them");
    var btnLuu= document.getElementById("luu");
    var hangSX = document.getElementById("hangSX");
    hang.style.display = "block";
    btnLuu.style.display = "block";
    btnThem.style.display = "none";
    hangSX.focus();
}

function luuClick(){
    var select = document.getElementById("select");
    var hangSX = document.getElementById("hangSX");
    var hang = document.getElementById("hang");
    var btnThem= document.getElementById("them");
    var btnLuu= document.getElementById("luu"); 
    var hangS = hangSX.value;
    if(hangS === ""){
        alert("Yeu Cau Nhap Du Lieu!");
        hangSX.focus();
    }else{
            var op = document.createElement("option");
            op.setAttribute("value", hangS);
            var textNode = document.createTextNode(hangS);
            op.appendChild(textNode);
            select.appendChild(op);
            btnLuu.style.display = 'none';
            btnThem.style.display ='block';
            hang.style.display ='none';
            hangSX.value ="";
        }
}

function huyClick(){
    var hang = document.getElementById("hang");
    var btnThem= document.getElementById("them");
    var btnLuu= document.getElementById("luu");
    hang.style.display = "none";
    btnLuu.style.display ="none";
    btnThem.style.display ="block";
}

