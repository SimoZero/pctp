let copertine = [
    "https://m.media-amazon.com/images/I/511suynbMfL._AC_UF1000,1000_QL80_.jpg",
    "https://m.media-amazon.com/images/I/412FZmYY0sL.jpg",
    "https://m.media-amazon.com/images/I/41dbYUr0rUL.jpg",
    "https://m.media-amazon.com/images/I/41R38uCEyGL.jpg",
    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTfYGgvx44ivyiIuNymh8hWpBMpRBWI0HbrQg&s",
    "https://m.media-amazon.com/images/I/71yxc8fLNgL._AC_UF1000,1000_QL80_.jpg",
    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXpiuDCTdxqD3xwJgKUbl3NYk0tl3Xd3QEmA&s",
    "https://m.media-amazon.com/images/I/91l6J37IQ9L._AC_UF1000,1000_QL80_.jpg",
    "https://www.ibs.it/images/9788834740378_0_424_0_75.jpg",
    "https://m.media-amazon.com/images/I/81tNTZMlczL._AC_UF1000,1000_QL80_.jpg"
];
let i = 0;

document.getElementById("ContPag").innerHTML = "Pag " + Math.floor(i / 3+1) + " di " + Math.floor(copertine.length / 3+1);

document.getElementById("img1").src = copertine[0];
document.getElementById("img2").src = copertine[1];
document.getElementById("img3").src = copertine[2];

document.getElementById("bottoneCerca").addEventListener("click", function () {
    let n1 = document.getElementById("inputRicerca").value;
});

document.getElementById("bottoneAvanti").addEventListener("click", function () {
    i = (i + 3) % copertine.length;
    document.getElementById("img1").src = copertine[(i) % copertine.length];
    document.getElementById("img2").src = copertine[(i + 1) % copertine.length];
    document.getElementById("img3").src = copertine[(i + 2) % copertine.length];

    document.getElementById("ContPag").innerHTML = "Pag " + Math.floor(i / 3 + 1) + " di " + Math.floor(copertine.length / 3 + 1);
});

document.getElementById("bottoneIndietro").addEventListener("click", function () {
    i = (i - 3 + copertine.length) % copertine.length;
    document.getElementById("img1").src = copertine[(i) % copertine.length];
    document.getElementById("img2").src = copertine[(i + 1) % copertine.length];
    document.getElementById("img3").src = copertine[(i + 2) % copertine.length];

    document.getElementById("ContPag").innerHTML = "Pag " + Math.floor(i / 3 + 1) + " di " + Math.floor(copertine.length / 3 + 1);
})

