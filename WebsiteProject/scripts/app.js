$(function () {

    $('[data-ajax=true]').each(function () {
        var $this = $(this);
        var $form = $(this).closest('form');
        $form.submit(function (e) {
            e.preventDefault();
            $.ajax({
                type: "POST",
                url: window.location,
                data: $form.serialize(),

                success: function (response) {
                    $($this.data('ajax-update')).html(response);
                }
            })
        });
    })

})