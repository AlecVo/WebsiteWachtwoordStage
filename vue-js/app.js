
// als er op het id#search geklikt word dan word de functie getPokemon uitgevoerd
document.querySelector("#search").addEventListener("click", getPokemon);

function lowerCaseName(string) {
    return string.toLowerCase();
}
function upperCaseFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1); //zorgt ervoor dat enkel de eerste letter een hoofdletter word
}

// Dit is er om pokemons op te halen, fetch gaat de api gegevens halen, als er iets terug gekomen word weergeef de data. anders error
function getPokemon(e) {
    const name = document.querySelector("#pokemonName").value;
    const pokemonName = lowerCaseName(name);
    const pokemonLetter = upperCaseFirstLetter(pokemonName)

    fetch(`https://pokeapi.co/api/v2/pokemon/${pokemonName}`)
    .then((response) => response.json())
    .then((data) => {
        //official artwork zorgt ervoor dat de underscore herkent word
        document.querySelector(".pokemonBox").innerHTML = `
        <div>
            <img src="${data.sprites.other["official-artwork"].front_default}" 
            alt="${pokemonLetter}"/>
        </div>
        <div class="pokemonInfo">
            <h1>${pokemonLetter}</h1>
            <p>Weight: ${data.Weight}</p>
        </div>
        `;
    })
    .catch((err)  => {
        console.log('pokemon not found',err)
    })
    e.preventDefault();
}