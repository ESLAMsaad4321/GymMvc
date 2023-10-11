$(document).ready(function () {
    $('.js-RejectRequest').on('click', function () {


        var btn = $(this);
        const swal = Swal.mixin({
            customClass: {
                confirmButton: 'btn btn-Success',
                cancelButton: 'btn btn-light'
            },
            buttonsStyling: false
        });
        swal.fire({
            title: 'Are you sure to Approve This Trainer?',
            text: "You won't be able to revert this!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonText: 'Yes, Reject Him it!',
            cancelButtonText: 'No, cancel!',
            reverseButtons: true
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: `/Request/RejectRequest/${btn.data(`id`)}`,
                    method: 'GET',
                    success: function () {
                        swal.fire(
                            'Done!',
                            'You Reject This Trainer',
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