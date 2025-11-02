$(document).ready(function() {
  'use strict';

  $('#buttons_datatable').DataTable({
    responsive: true,
    dom:"<'row'<'col-sm-6 text-left'f><'col-sm-6 text-right'B>>\n\t\t\t<'row'<'col-sm-12'tr>>\n\t\\t<'row'<'col-sm-12 col-md-5'i><'col-sm-12 col-md-7 dataTables_pager'lp>>",
    buttons: {
      buttons: [
          {
            extend: 'print',
            className: 'btn-primary',
            init: function(api, node, config) {
              $(node).removeClass('btn-secondary')
            }
          },
          {
            extend: 'excelHtml5',
            className: 'btn-primary',
            init: function(api, node, config) {
              $(node).removeClass('btn-secondary')
            }
          },
          {
            extend: 'csvHtml5',
            className: 'btn-primary',
            init: function(api, node, config) {
              $(node).removeClass('btn-secondary')
            }
          },
          {
            extend: 'pdfHtml5',
            className: 'btn-primary',
            init: function(api, node, config) {
              $(node).removeClass('btn-secondary')
            }
          }
      ]
    },
    columnDefs: [
      {
        targets: [6],
        width:"30px",
        render: function (data, type, row) {
          return '<div class="dropleft d-inline-block"><a href="#" class="btn btn-icon btn-sm" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><i class="lni-more-alt"></i></a><div class="dropdown-menu">'+
                  '<a class="dropdown-item media align-items-center" href="#"><i class="lni-enter"></i><div class="media-body"><h6>View</h6><p class="text-muted fs-12">View item details</p></div></a>'+
                  '<a class="dropdown-item media align-items-center" href="#"><i class="lni-pencil"></i><div class="media-body"><h6>Edit</h6><p class="text-muted fs-12">Edit item</p></div></a>'+
                  '<div class="dropdown-divider"></div>'+
                  '<a class="dropdown-item media align-items-center text-danger" href="#"><i class="lni-trash"></i><div class="media-body"><h6>Delete</h6><p class="text-muted fs-12">Delete item</p></div></a>'
        }
      },
    ]
  });


    //
    $('#piece_client').DataTable({
        responsive: true,
        language: {
            "lengthMenu": "Affiche _MENU_ enregistrements ",
            "zeroRecords": "Aucun enregistrement trouvé",
            "info": "Affiche _PAGE_ enregistrements sur _PAGES_",
            "infoEmpty": "",
            "infoFiltered": "(recherche sur _MAX_ enregistrements)",
            "search": "Rechercher",
            "paginate": {
                "first": "First",
                "last": "Last",
                "next": "Suivant",
                "previous": "Precedent"
            },

        },
        dom: "<'row'<'col-sm-6 text-left'f><'col-sm-6 text-right'B>>\n\t\t\t<'row'<'col-sm-12'tr>>\n\t\\t<'row'<'col-sm-12 col-md-5'i><'col-sm-12 col-md-7 dataTables_pager'lp>>",
        buttons: {
            buttons: [
                {
                    extend: 'print',
                    text:'Imprimer',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                },
                {
                    extend: 'excelHtml5',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                },
                {
                    extend: 'csvHtml5',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                },
                {
                    extend: 'pdfHtml5',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                }
            ]
        },
        columnDefs: [
            {
                targets: [7],
                width: "30px",
                render: function (data, type, row) {
                    var dat = row[3];
                    console.log(dat);

                    return '<div class="dropleft d-inline-block"><a href="#" class="btn btn-icon btn-sm" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><i class="lni-more-alt"></i></a><div class="dropdown-menu">' +
                        '<a class="dropdown-item media align-items-center" onclick="return detailsVente(\'' + dat +'\')" href="#"><i class="lni-enter"></i><div class="media-body"><h6>Details</h6><p class="text-muted fs-12">Details vente</p></div></a>' +
                        '<a class="dropdown-item media align-items-center text-danger" onclick="return deleteVente(\''+dat+'\')" href="#"><i class="lni-trash"></i><div class="media-body"><h6>Supprimer</h6><p class="text-muted fs-12">Supprimer</p></div></a>'
                }
            },
        ]
    });

    //
    $('#commission_client').DataTable({
        responsive: true,
        language: {
            "lengthMenu": "Affiche _MENU_ enregistrements ",
            "zeroRecords": "Aucun enregistrement trouvé",
            "info": "Affiche _PAGE_ enregistrements sur _PAGES_",
            "infoEmpty": "",
            "infoFiltered": "(recherche sur _MAX_ enregistrements)",
            "search": "Rechercher",
            "paginate": {
                "first": "First",
                "last": "Last",
                "next": "Suivant",
                "previous": "Precedent"
            },

        },
        dom: "<'row'<'col-sm-6 text-left'f><'col-sm-6 text-right'B>>\n\t\t\t<'row'<'col-sm-12'tr>>\n\t\\t<'row'<'col-sm-12 col-md-5'i><'col-sm-12 col-md-7 dataTables_pager'lp>>",
        buttons: {
            buttons: [
                {
                    extend: 'print',
                    text: 'Imprimer',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                },
                {
                    extend: 'excelHtml5',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                },
                {
                    extend: 'csvHtml5',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                },
                {
                    extend: 'pdfHtml5',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                }
            ]
        },
        columnDefs: [
            {
                targets: [8],
                width: "30px",
                render: function (data, type, row) {
                    var dat = row[2];
                    console.log("dat"+dat);

                    return '<div class="dropleft d-inline-block"><a href="#" class="btn btn-icon btn-sm" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><i class="lni-more-alt"></i></a><div class="dropdown-menu">' +
                        '<a class="dropdown-item media align-items-center" onclick="return detailsCommission(\'' + dat + '\')" href="#"><i class="lni-enter"></i><div class="media-body"><h6>Details</h6><p class="text-muted fs-12">Details toutes commissions</p></div></a>' +
                        '<a class="dropdown-item media align-items-center text-danger" onclick="return detailsCommission2(\'' + dat + '\')" href="#"><i class="lni-enter"></i><div class="media-body"><h6>Details</h6><p class="text-muted fs-12">Details des non encaisses</p></div></a>' +
                        '<a class="dropdown-item media align-items-center text-danger" onclick="return payerclient(\'' + dat + '\')" href="#"><i class="lni-money-protection"></i><div class="media-body"><h6>Payer</h6><p class="text-muted fs-12">Regler client</p></div></a>'
                }
            },
        ]
    });
    $('#details_commission').DataTable({
        responsive: true,
        language: {
            "lengthMenu": "Affiche _MENU_ enregistrements ",
            "zeroRecords": "Aucun enregistrement trouvé",
            "info": "Affiche _PAGE_ enregistrements sur _PAGES_",
            "infoEmpty": "",
            "infoFiltered": "(recherche sur _MAX_ enregistrements)",
            "search": "Rechercher",
            "paginate": {
                "first": "First",
                "last": "Last",
                "next": "Suivant",
                "previous": "Precedent"
            },

        },
        dom: "<'row'<'col-sm-6 text-left'f><'col-sm-6 text-right'B>>\n\t\t\t<'row'<'col-sm-12'tr>>\n\t\\t<'row'<'col-sm-12 col-md-5'i><'col-sm-12 col-md-7 dataTables_pager'lp>>",
        buttons: {
            buttons: [
                {
                    extend: 'print',
                    text: 'Imprimer',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                },
                {
                    extend: 'excelHtml5',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                },
                {
                    extend: 'csvHtml5',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                },
                {
                    extend: 'pdfHtml5',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                }
            ]
        },
        columnDefs: [
            {
                targets: [8],
                width: "30px",
                render: function (data, type, row) {
                    var dat = row[2];
                    console.log(dat);

                    return '<div class="dropleft d-inline-block"><a href="#" class="btn btn-icon btn-sm" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><i class="lni-more-alt"></i></a><div class="dropdown-menu">' +
                        '<a class="dropdown-item media align-items-center" onclick="return detailsCommission(\'' + dat + '\')" href="#"><i class="lni-enter"></i><div class="media-body"><h6>Details</h6><p class="text-muted fs-12">Details toutes commissions</p></div></a>' +
                        '<a class="dropdown-item media align-items-center text-danger" onclick="return detailsCommission2(\'' + dat + '\')" href="#"><i class="lni-enter"></i><div class="media-body"><h6>Details</h6><p class="text-muted fs-12">Details des non encaisses</p></div></a>'
                }
            },
        ]
    });
    $('#details_commission2').DataTable({
        responsive: true,
        language: {
            "lengthMenu": "Affiche _MENU_ enregistrements ",
            "zeroRecords": "Aucun enregistrement trouvé",
            "info": "Affiche _PAGE_ enregistrements sur _PAGES_",
            "infoEmpty": "",
            "infoFiltered": "(recherche sur _MAX_ enregistrements)",
            "search": "Rechercher",
            "paginate": {
                "first": "First",
                "last": "Last",
                "next": "Suivant",
                "previous": "Precedent"
            },

        },
        dom: "<'row'<'col-sm-6 text-left'f><'col-sm-6 text-right'B>>\n\t\t\t<'row'<'col-sm-12'tr>>\n\t\\t<'row'<'col-sm-12 col-md-5'i><'col-sm-12 col-md-7 dataTables_pager'lp>>",
        buttons: {
            buttons: [
                {
                    extend: 'print',
                    text: 'Imprimer',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                },
                {
                    extend: 'excelHtml5',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                },
                {
                    extend: 'csvHtml5',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                },
                {
                    extend: 'pdfHtml5',
                    className: 'btn-primary',
                    init: function (api, node, config) {
                        $(node).removeClass('btn-secondary')
                    }
                }
            ]
        },
        columnDefs: [
            {
                targets: [8],
                width: "30px",
                render: function (data, type, row) {
                    var dat = row[2];
                    console.log(dat);

                    return '<div class="dropleft d-inline-block"><a href="#" class="btn btn-icon btn-sm" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><i class="lni-more-alt"></i></a><div class="dropdown-menu">' +
                        '<a class="dropdown-item media align-items-center" onclick="return detailsCommission(\'' + dat + '\')" href="#"><i class="lni-enter"></i><div class="media-body"><h6>Details</h6><p class="text-muted fs-12">Details toutes commissions</p></div></a>' +
                        '<a class="dropdown-item media align-items-center text-danger" onclick="return detailsCommission2(\'' + dat + '\')" href="#"><i class="lni-enter"></i><div class="media-body"><h6>Details</h6><p class="text-muted fs-12">Details des non encaisses</p></div></a>'
                }
            },
        ]
    });
});
