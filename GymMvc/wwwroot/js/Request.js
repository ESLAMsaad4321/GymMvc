$(document).ready(function () {
    $('.js-Request').on('click', function () {


        var btn = $(this);
        const swal = Swal.mixin({
            customClass: {
                confirmButton: 'btn btn-Success',
                cancelButton: 'btn btn-light'
            },
            buttonsStyling: false
        });
        swal.fire({
            title: 'Are you sure to Choose This Coache?',
            text: "You won't be able to revert this!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonText: 'Yes, Send it!',
            cancelButtonText: 'No, cancel!',
            reverseButtons: true
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: `/Request/Request/${btn.data(`id`)}`,
                    method: 'POST',
                    success: function () {
                        swal.fire(
                            'Done!',
                            'Your Request Has Send',
                            'success'
                        );

                    },
                    error: function () {
                        swal.fire(
                            'Oooooops!',
                            'Something Is Wrong',
                            'error'
                        );
                    }
                });

            }
        });
    });
});