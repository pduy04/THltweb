var  dem =1;
function them(){
    var check =0;
    var tb = document.getElementById("myTable");
    var ten = document.getElementById("ten").value;
    var hang = document.getElementById("hang").value;
    var gia = document.getElementById("gia").value;  
    var dateRM = new Date(document.getElementById("ngay").value);
    var now = new Date();
    var date = dateRM.getDate() +"/"+(dateRM.getMonth()+1)+"/"+dateRM.getFullYear();
    var form = document.getElementById("Form1");
    if(ten==="") check++;
    if(hang==="") check++;
    if(gia==="") check++;
    if(dateRM === null) {
        alert("Ngay Null");
    }
    if(check !=0){
        alert("Bạn phải nhập đầy đủ thông tin!");
    }else if((dateRM.getDate()===now.getDate() 
        && dateRM.getMonth() === now.getMonth()
        && dateRM.getFullYear()=== now.getFullYear())
        ||( dateRM < now))
        {
            var row = tb.insertRow();
            var cell1 = row.insertCell();
            var cell2 = row.insertCell();
            var cell3 = row.insertCell();
            var cell4 = row.insertCell();
            var cell5 = row.insertCell();
            cell1.innerHTML = dem;
            cell2.innerHTML = ten
            cell3.innerHTML = hang;
            cell4.innerHTML = date;
            cell5.innerHTML = gia;
            dem++;
            form.submit();
    }else {
        alert("Ngày không hợp lệ, Ngày ra mắt không thể lớn hơn ngày hiện tại! ")
    }
}

function huy(){
    document.getElementById("ten").value = "";
    document.getElementById("hang").value="";
    document.getElementById("ngay").value=" " ;
    document.getElementById("gia").value ="";
}