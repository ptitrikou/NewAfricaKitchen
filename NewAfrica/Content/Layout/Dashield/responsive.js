$(document).ready(function() {
  'use strict';

  $('#responsive_datatable').DataTable({
    responsive: true,
    columnDefs: [
      {
        targets: [7],
        width:"30px",
            render: function (data, type, row) {
                var iditem = row[7];
          return '<div class="dropleft d-inline-block"><a href="#" class="btn btn-icon btn-sm" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><i class="lni-more-alt"></i></a><div class="dropdown-menu">'+
                  '<a class="dropdown-item media align-items-center" href="#"><i class="lni-enter"></i><div class="media-body"><h6>View</h6><p class="text-muted fs-12">View item details</p></div></a>'+
              '<a class="dropdown-item media align-items-center" onclick="return UpdateImg()" href="#"><i class="lni-pencil"></i><div class="media-body"><h6>Modifier n</h6><p class="text-muted fs-12">Modifier limage</p></div></a>' +
                  '<div class="dropdown-divider"></div>'+
                  '<a class="dropdown-item media align-items-center text-danger" href="#"><i class="lni-trash"></i><div class="media-body"><h6>Delete</h6><p class="text-muted fs-12">Delete item</p></div></a>'
        }
      },
    ]
  });

});

$('#list_items').DataTable({
    responsive: true,
    columnDefs: [
        {
        },
    ]
});
