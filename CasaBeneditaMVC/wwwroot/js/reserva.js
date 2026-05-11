document.addEventListener("DOMContentLoaded", function () {


    const campoTelefone = document.getElementById('campoTelefone');
    const campoNome = document.getElementById('campoNome');







    campoTelefone?.addEventListener('input', (e) => {
        let v = e.target.value.replace(/\D/g, '');







        if (v.length === 0) {
            e.target.value = "";
            return;
        }







        if (v.length > 11) v = v.slice(0, 11);
        if (v.length > 10) {
            e.target.value = `(${v.substring(0, 2)}) ${v.substring(2, 7)}-${v.substring(7, 11)}`;
        } else if (v.length > 6) {
            e.target.value = `(${v.substring(0, 2)}) ${v.substring(2, 6)}-${v.substring(6, 10)}`;
        } else if (v.length > 2) {
            e.target.value = `(${v.substring(0, 2)}) ${v.substring(2)}`;
        } else {
            e.target.value = `(${v}`;
        }
    });







    campoNome?.addEventListener('input', (e) => {
        e.target.value = e.target.value.replace(/[0-9]/g, '');
    });







});







function confirmarReserva() {
    const inputData = document.getElementById('campoData');
    const inputHora = document.getElementById('campoHorario');
    const inputNome = document.getElementById('campoNome');
    const inputEmail = document.getElementById('campoEmail');
    const inputTel = document.getElementById('campoTelefone');







    const dados = {
        data: inputData?.value,
        horario: inputHora?.value,
        nome: inputNome?.value.trim(),
        email: inputEmail?.value.trim(),
        telefone: inputTel?.value.trim()


    };


    if (!dados.data) return aviso('Data', 'Selecione o dia da reserva.');
    if (!dados.horario) return aviso('Horário', 'Escolha um horário.');
    if (dados.nome.length < 3) return aviso('Nome', 'Digite seu nome completo.');
    if (!dados.email.includes('@')) return aviso('E-mail', 'Insira um e-mail válido.');
    if (dados.telefone.length < 14) return aviso('Telefone', 'O telefone está incompleto.');

    Swal.fire({
        title: 'Confirmar Reserva?',
        text: `Reserva para ${dados.nome} as ${dados.horario}`,
        icon: 'question',
        showCancelButton: true,
        confirmButtonColor: '#c5a059',
        confirmButtonText: 'Sim, reservar!',
        cancelButtonText: 'Cancelar'


    }).then((result) => {
        if (result.isConfirmed) {
            Swal.fire({
                title: 'Sucesso!',
                text: 'Sua reserva foi confirmada.',
                icon: 'success',
                confirmButtonColor: '#c5a059',
                timer: 2000,
                showConfirmButton: false
            }).then(() => {
                document.getElementById('formReserva').submit();
            });
        }
    });
}


function aviso(titulo, texto) {



    Swal.fire({
        icon: 'warning',
        title: titulo,
        text: texto,
        confirmButtonColor: '#c5a059'
    });
}

