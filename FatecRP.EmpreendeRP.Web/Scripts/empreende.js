// mascara dos documentos
        $(function ($) {
            $("#cpf").mask("999.999.999-99");
            $("#cnpj").mask("99.999.999/9999-99");
            $("#rg").mask("99.999.999-9");
            $("#cep").mask("99999-999");
            $("#fixo").mask("(99) 9999-9999");
            $("#celular").mask("(99) 99999-9999");
});
// mascara dos documentos

// API do ViaCEP
        var inputsCEP = $('#logradouro, #bairro, #localidade, #uf');
        var validacep = /^[0-9]{8}$/;

        function limpa_formulário_cep(alerta) {
            if (alerta !== undefined) {
                alert(alerta);
            }

            inputsCEP.val('');
        }

        function get(url) {

            $.get(url, function (data) {

                if (!("erro" in data)) {

                    if (Object.prototype.toString.call(data) === '[object Array]') {
                        var data = data[0];
                    }

                    $.each(data, function (nome, info) {
                        $('#' + nome).val(nome === 'cep' ? info.replace(/\D/g, '') : info).attr('info', nome === 'cep' ? info.replace(/\D/g, '') : info);
                    });



                } else {
                    limpa_formulário_cep("CEP não encontrado.");
                }

            });
        }

        // Digitando CEP
        $('#cep').on('blur', function (e) {

            var cep = $('#cep').val().replace(/\D/g, '');

            if (cep !== "" && validacep.test(cep)) {

                inputsCEP.val('...');
                get('https://viacep.com.br/ws/' + cep + '/json/');

            } else {
                limpa_formulário_cep(cep == "" ? undefined : "Formato de CEP inválido.");
            }
        });
 // API do ViaCEP

//desabilitar campo Onde Trabalha? ao escolher não
        $(document).ready(function () {
            // declaração da variável
            var valorEscolhido;

            $("#trabalha").change(function () {
                // obtendo o valor do atributo value da tag option
                valorEscolhido = $("#trabalha option:selected").val();

                if (valorEscolhido == "Não")
                {
                    $('#ondetrab').attr('disabled', true);
                }
                else
                {
                    $('#ondetrab').attr('disabled', false);
                }
                // exibindo uma janela com o valor selecionado
                
            });
        });
//desabilitar campo Onde Trabalha? ao escolher não

//Desabilitando o campo de cnpj caso o cidadão não seja empreendedor

$(document).ready(function () {
    // declaração da variável
    var valorEscolhido;

    $("#ehempreendedor").change(function () {
        // obtendo o valor do atributo value da tag option
        valorEscolhido = $("#ehempreendedor option:selected").val();

        if (valorEscolhido == "Não") {
            $("#cnpj").prop("disabled", true);
        }
        else {
            $("#cnpj").prop("disabled", false);
        }
        // exibindo uma janela com o valor selecionado

    });
});

//Desabilitando o campo de cnpj caso o cidadão não seja empreendedor

//Desabilitando o campo de Necessidades especiais caso o cidadão não tenha uma

$(document).ready(function () {
    // declaração da variável
    var valorEscolhido;

    $("#necessidadeesp").change(function () {
        // obtendo o valor do atributo value da tag option
        valorEscolhido = $("#necessidadeesp option:selected").val();

        if (valorEscolhido == "Não") {
            $("#qualnecessidade").prop("disabled", true);
        }
        else {
            $("#qualnecessidade").prop("disabled", false);
        }
        // exibindo uma janela com o valor selecionado

    });
});
//Desabilitando o campo de Necessidades especiais caso o cidadão não tenha uma