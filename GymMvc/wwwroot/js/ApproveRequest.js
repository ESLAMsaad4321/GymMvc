$(document).ready(function () {
    $('.js-ApproveRequest').on('click', function () {


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
            confirmButtonText: 'Yes, Approve Him it!',
            cancelButtonText: 'No, cancel!',
            reverseButtons: true
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: `/Request/ApproveRequest/${btn.data(`id`)}`,
                    method: 'GET',
                    success: function () {
                        swal.fire(
                            'Done!',
                            'This Trainer Become With You',
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