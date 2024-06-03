let copertine = ["https://m.media-amazon.com/images/I/412FZmYY0sL.jpg", "https://m.media-amazon.com/images/I/41dbYUr0rUL.jpg", "https://m.media-amazon.com/images/I/41R38uCEyGL.jpg","https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTfYGgvx44ivyiIuNymh8hWpBMpRBWI0HbrQg&s", "https://m.media-amazon.com/images/I/71yxc8fLNgL._AC_UF1000,1000_QL80_.jpg", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXpiuDCTdxqD3xwJgKUbl3NYk0tl3Xd3QEmA&s"];
let i = 3;
document.getElementById("bottoneCerca").addEventListener("click", function () {
    let n1 = document.getElementById("intputRicerca").value;
})

document.getElementById("bottoneAvanti").addEventListener("click", function () {
    document.getElementById("img1").src = document.getElementById("img2").src;
    document.getElementById("img2").src = document.getElementById("img3").src;
    document.getElementById("img3").src = copertine[i++];
    if (i>=6) {
        i = 0;
    }
})

document.getElementById("bottoneIndietro").addEventListener("click", function () {
    document.getElementById("img3").src = document.getElementById("img2").src;
    document.getElementById("img2").src = document.getElementById("img1").src;
    document.getElementById("img1").src = copertine[i--];
    if (i < 0) {
        i = 5;
    }
})