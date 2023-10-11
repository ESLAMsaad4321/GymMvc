$(document).ready(function () {
    $('.js-delete').on('click', function () {
        var btn = $(this);
        const swal = Swal.mixin({
            customClass: {
                confirmButton: 'btn btn-danger',
                cancelButton: 'btn btn-light'
            },
            buttonsStyling: false
        });
        swal.fire({
            title: 'Are you sure to delete account?',
            text: "You won't be able to revert this!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonText: 'Yes, delete it!',
            cancelButtonText: 'No, cancel!',
            reverseButtons: true
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: `/Information/Delete/${btn.data(`id`)}`,
                    method: 'DELETE',
                    success: function () {
                        swal.fire(
                            'Deleted!',
                            'Your Account Has Deleted',
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