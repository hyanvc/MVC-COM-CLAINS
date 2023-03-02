base.inicialize = {
    remover: function (id) {
        base.postAjax({
            url: base.urlBase + "RemoverOperador",
            data: { "CD_USUARIO": 33 },
            done: function (data) {
                if (data.sucesso) {
                    bootbox.alert("Excluido com sucesso");
                    base.operadorExterno.atualizar();
                }
                else
                    bootbox.alert(data.mensagem);
            }
        });
    },
};