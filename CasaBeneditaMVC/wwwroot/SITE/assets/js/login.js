const campoNome = document.getElementById('name');
const campoEmail = document.getElementById('email');
const campoTelefone = document.getElementById('phone');
const campoData = document.getElementById('date');
const campoTempo = document.getElementById('time');
const campoPessoas = document.getElementById('people');
const campoMensagem = document.getElementById('message');
const formulario = document.querySelector('.php-email-form');

formulario.addEventListener('submit', function(event) {
    event.preventDefault();
    document.querySelector('.loading').classList.add('d-block');

    const Cliente = campoNome.value;
    const Email = campoEmail.value;
    const Data = campoData.value;
    const Tempo = campoTempo.value;
    const Pessoas = campoPessoas.value;
    const Menssagem = campoMensagem.value;
    const NovaReserva = {
        nome : Cliente,
        email : Email,
        data : Data,
        tempo : Tempo,
        pessoas : Pessoas,
        messagem : Menssagem

    }
console.log("Reserva feita com sucesso ", NovaReserva);

document.querySelector('.loading').classList.remove('d-block');
document.querySelector('.sent-message').classList.add('d-block');

formulario.reset();
})