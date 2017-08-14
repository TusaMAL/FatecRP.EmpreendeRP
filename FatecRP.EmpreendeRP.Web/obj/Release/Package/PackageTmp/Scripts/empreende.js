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

////desabilitar campo Onde Trabalha? ao escolher não
//$(document).ready(function () {
//    // declaração da variável
//    var valorEscolhido;

//    $("#trabalha").change(function () {
//        // obtendo o valor do atributo value da tag option
//        valorEscolhido = $("#trabalha option:selected").val();

//        if (valorEscolhido == "Não") {
//            $('#ondetrab').attr('disabled', true);
//        }
//        else {
//            $('#ondetrab').attr('disabled', false);
//        }
//        // exibindo uma janela com o valor selecionado

//    });
//});
////desabilitar campo Onde Trabalha? ao escolher não

//Desabilitando o campo de cnpj caso o cidadão não seja empreendedor

//$(document).ready(function () {
//    // declaração da variável
//    var valorEscolhido;

//    $("#ehempreendedor").change(function () {
//        // obtendo o valor do atributo value da tag option
//        valorEscolhido = $("#ehempreendedor option:selected").val();

//        if (valorEscolhido == "Não") {
//            $("#cnpj").prop("disabled", true);
//        }
//        else {
//            $("#cnpj").prop("disabled", false);
//        }
//        // exibindo uma janela com o valor selecionado

//    });
//});

//Desabilitando o campo de cnpj caso o cidadão não seja empreendedor

//Desabilitando o campo de Necessidades especiais caso o cidadão não tenha uma

//$(document).ready(function () {
//    // declaração da variável
//    var valorEscolhido;

//    $("#necessidadeesp").change(function () {
//        // obtendo o valor do atributo value da tag option
//        valorEscolhido = $("#necessidadeesp option:selected").val();

//        if (valorEscolhido == "Não") {
//            $("#qualnecessidade").prop("disabled", true);
//        }
//        else {
//            $("#qualnecessidade").prop("disabled", false);
//        }
//        // exibindo uma janela com o valor selecionado

//    });
//});
//Desabilitando o campo de Necessidades especiais caso o cidadão não tenha uma

//Campo Extra para digitar como conheceu o evento
$(document).ready(function () {
    // declaração da variável
    var valorEscolhido;

    var enableDiv = function () {
        document.getElementById("outro").style.display = 'block';
        document.getElementById("outropls").disabled = false;
        document.getElementById("outropls").required = true;
    }

    var disableDiv = function () {
        document.getElementById("outro").style.display = 'none';
        document.getElementById("outropls").disabled = true;
        document.getElementById("outropls").required = false;
    }

    $("#sabendoevento").change(function () {
        // obtendo o valor do atributo value da tag option
        valorEscolhido = $("#sabendoevento option:selected").val();

        if (valorEscolhido == "Outro") {
            enableDiv();
        }
        else {
            disableDiv();
        }
        // exibindo uma janela com o valor selecionado

    });
});
// Campo extra pra digitar como conheceu evento


//Libera o campo caso o cidadão trabalhe
$(document).ready(function () {
    // declaração da variável
    var valorEscolhido;

    var enableDivTrab = function () {
        document.getElementById("ondetrabdiv").style.display = 'block';
        document.getElementById("ondetrab").disabled = false;
    }

    var disableDivTrab = function () {
        document.getElementById("ondetrabdiv").style.display = 'none';
        document.getElementById("ondetrab").disabled = true;
    }

    $("#trabalha").change(function () {
        // obtendo o valor do atributo value da tag option
        valorEscolhido = $("#trabalha option:selected").val();

        if (valorEscolhido == "Sim") {
            enableDivTrab();
        }
        else {
            disableDivTrab();
        }
        // exibindo uma janela com o valor selecionado

    });
});
//Libera o campo caso o cidadão trabalhe

//Libera o campo caso o cidadão seja empreendedor
$(document).ready(function () {
    // declaração da variável
    var valorEscolhido;

    var enableDiv = function () {
        document.getElementById("cnpjdiv").style.display = 'block';
        document.getElementById("cnpj").disabled = false;
        document.getElementById("cnpj").required = true;
    }

    var disableDiv = function () {
        document.getElementById("cnpjdiv").style.display = 'none';
        document.getElementById("cnpj").disabled = true;
        document.getElementById("cnpj").required = false;
    }

    $("#ehempreendedor").change(function () {
        // obtendo o valor do atributo value da tag option
        valorEscolhido = $("#ehempreendedor option:selected").val();

        if (valorEscolhido == "Sim") {
            enableDiv();
        }
        else {
            disableDiv();
        }
        // exibindo uma janela com o valor selecionado

    });
});
//Libera o campo caso o cidadão seja empreendedor


$(document).ready(function () {
    // declaração da variável
    var valorEscolhido;

    var enableDiv = function () {
        document.getElementById("necessidadediv").style.display = 'block';
        document.getElementById("qualnecessidade").disabled = false;
        document.getElementById("qualnecessidade").required = true;
    }

    var disableDiv = function () {
        document.getElementById("necessidadediv").style.display = 'none';
        document.getElementById("qualnecessidade").disabled = true;
        document.getElementById("qualnecessidade").required = false;
    }

    $("#necessidadeesp").change(function () {
        // obtendo o valor do atributo value da tag option
        valorEscolhido = $("#necessidadeesp option:selected").val();

        if (valorEscolhido == "Sim") {
            enableDiv();
        }
        else {
            disableDiv();
        }
        // exibindo uma janela com o valor selecionado

    });
});