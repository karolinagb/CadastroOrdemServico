$(document).ready(function () {
    $('#cnpj').mask('00.000.000/0000-00', { reverse: true });
    $('#cpf').mask('000.000.000-00', { reverse: true });
    $('#date').mask('00/00/0000');
    $('#money').mask('000.000.000.000.000,00', { reverse: true });
});
