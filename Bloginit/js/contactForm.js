var contactForm = contactForm ||
{
    init: function () {
        this.listener();
    },
    lestener: function () {
        $(document).on('click', '.contact-submit', function (e) {
            e.preventDefault();
            var form = $("#contact-form");
            form.submit();
        })
    },
    showResult: function () {
        $("#contact_form_container").hide('slow');
        $("#contact_form_results").show('slow');
    }
}