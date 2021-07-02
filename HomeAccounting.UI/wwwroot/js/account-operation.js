async function createAccount(e) {
    e.preventDefault();
    let frm = document.getElementById("frmCreateSimpleAccount");

    let Title = frm.elements[0].value;
    let Amount = parseInt(frm.elements[1].value);
    //let Type = 1;

    let dto = { Title, Amount};
    let result = await fetch("/api/Accounts",
        {
            method: "POST",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json;charset=UTF-8'
            },
            //headers: [{ "contentType" : "application/json" }],
            body: JSON.stringify(dto)
        });

    if (result.status == 200) {
        alert('Счёт создан');
    }
    
}

window.addEventListener("load", () => {
    let ok = document.getElementById("Ok");
    ok.addEventListener("click", createAccount);
})