var TableManaged = function () {

    var nestList = function () {

        var table = $('#nestList');

        // begin first table
        table.dataTable({

            "language": {
                "aria": {
                    "sortAscending": ": A-Z Sýrala",
                    "sortDescending": ": Z-A Sýrala"
                },
                "emptyTable": "Hiç veri bulumamadý.",
                "info": "_START_ - _END_ arasý gösteriliyor. Toplam _TOTAL_ kayýt bulundu.",
                "infoEmpty": "Kayýt bulunamadý.",
                "infoFiltered": "(filtered1 from _MAX_ total entries)",
                "lengthMenu": "Show _MENU_ entries",
                "search": "Ara:",
                "zeroRecords": "Sonuç bulunamadý."
            },

            "bStateSave": true,

            "columns": [{ "orderable": false }, {
                "orderable": true
            }, {
                "orderable": false
            }, {
                "orderable": false
            }, {
                "orderable": true
            }, {
                "orderable": false
            }, {
                "orderable": false
            }, {
                "orderable": false
            }],
            "lengthMenu": [
                [5, 15, 20, -1],
                [5, 15, 20, "Hepsi"] // change per page values here
            ],
            // set the initial value
            "pageLength": 5,
            "pagingType": "bootstrap_full_number",
            "language": {
                "search": "My search: ",
                "lengthMenu": "  _MENU_ records",
                "paginate": {
                    "previous": "Prev",
                    "next": "Next",
                    "last": "Last",
                    "first": "First"
                }
            },
            "columnDefs": [{  // set default column settings
                'orderable': false,
                'targets': [0]
            }, {
                "searchable": false,
                "targets": [0]
            }],
            "order": [
                [1, "asc"]
            ] // set first column as a default sort by asc
        });

        var tableWrapper = jQuery('#nestListWrapper');

        table.find('.group-checkable').change(function () {
            var set = jQuery(this).attr("data-set");
            var checked = jQuery(this).is(":checked");
            jQuery(set).each(function () {
                if (checked) {
                    $(this).attr("checked", true);
                    $(this).parents('tr').addClass("active");
                } else {
                    $(this).attr("checked", false);
                    $(this).parents('tr').removeClass("active");
                }
            });
            jQuery.uniform.update(set);
        });
        tableWrapper.find('.dataTables_length select').addClass("form-control input-xsmall input-inline");
    };

    var PoultryList = function () {

        var table = $('#poultryList');

        // begin first table
        table.dataTable({

            "language": {
                "aria": {
                    "sortAscending": ": A-Z Sýrala",
                    "sortDescending": ": Z-A Sýrala"
                },
                "emptyTable": "Hiç veri bulumamadý.",
                "info": "_START_ - _END_ arasý gösteriliyor. Toplam _TOTAL_ kayýt bulundu.",
                "infoEmpty": "Kayýt bulunamadý.",
                "infoFiltered": "(filtered1 from _MAX_ total entries)",
                "lengthMenu": "Show _MENU_ entries",
                "search": "Ara:",
                "zeroRecords": "Sonuç bulunamadý."
            },

            "bStateSave": true,

            "columns": [{ "orderable": false }, {
                "orderable": true
            }, {
                "orderable": false
            }, {
                "orderable": false
            }, {
                "orderable": true
            }, {
                "orderable": true
            }, {
                "orderable": false
            }, {
                "orderable": false
            }, {
                "orderable": false
            }],
            "lengthMenu": [
                [5, 15, 20, -1],
                [5, 15, 20, "Hepsi"] // change per page values here
            ],
            // set the initial value
            "pageLength": 5,
            "pagingType": "bootstrap_full_number",
            "language": {
                "search": "My search: ",
                "lengthMenu": "  _MENU_ records",
                "paginate": {
                    "previous": "Prev",
                    "next": "Next",
                    "last": "Last",
                    "first": "First"
                }
            },
            "columnDefs": [{  // set default column settings
                'orderable': false,
                'targets': [0]
            }, {
                "searchable": false,
                "targets": [0]
            }],
            "order": [
                [1, "asc"]
            ] // set first column as a default sort by asc
        });

        var tableWrapper = jQuery('#nestListWrapper');

        table.find('.group-checkable').change(function () {
            var set = jQuery(this).attr("data-set");
            var checked = jQuery(this).is(":checked");
            jQuery(set).each(function () {
                if (checked) {
                    $(this).attr("checked", true);
                    $(this).parents('tr').addClass("active");
                } else {
                    $(this).attr("checked", false);
                    $(this).parents('tr').removeClass("active");
                }
            });
            jQuery.uniform.update(set);
        });
        tableWrapper.find('.dataTables_length select').addClass("form-control input-xsmall input-inline");
    };

    var coopList = function () {

        var table = $('#coopList');

        // begin first table
        table.dataTable({

            "language": {
                "aria": {
                    "sortAscending": ": A-Z Sýrala",
                    "sortDescending": ": Z-A Sýrala"
                },
                "emptyTable": "Hiç veri bulumamadý.",
                "info": "_START_ - _END_ arasý gösteriliyor. Toplam _TOTAL_ kayýt bulundu.",
                "infoEmpty": "Kayýt bulunamadý.",
                "infoFiltered": "(filtered1 from _MAX_ total entries)",
                "lengthMenu": "Show _MENU_ entries",
                "search": "Ara:",
                "zeroRecords": "Sonuç bulunamadý."
            },

            "bStateSave": true,

            "columns": [{ "orderable": false }, {
                "orderable": true
            }, {
                "orderable": false
            }, {
                "orderable": false
            }, {
                "orderable": false
            }],
            "lengthMenu": [
                [5, 15, 20, -1],
                [5, 15, 20, "Hepsi"] // change per page values here
            ],
            // set the initial value
            "pageLength": 5,
            "pagingType": "bootstrap_full_number",
            "language": {
                "search": "My search: ",
                "lengthMenu": "  _MENU_ records",
                "paginate": {
                    "previous": "Prev",
                    "next": "Next",
                    "last": "Last",
                    "first": "First"
                }
            },
            "columnDefs": [{  // set default column settings
                'orderable': false,
                'targets': [0]
            }, {
                "searchable": false,
                "targets": [0]
            }],
            "order": [
                [1, "asc"]
            ] // set first column as a default sort by asc
        });

        var tableWrapper = jQuery('#nestListWrapper');

        table.find('.group-checkable').change(function () {
            var set = jQuery(this).attr("data-set");
            var checked = jQuery(this).is(":checked");
            jQuery(set).each(function () {
                if (checked) {
                    $(this).attr("checked", true);
                    $(this).parents('tr').addClass("active");
                } else {
                    $(this).attr("checked", false);
                    $(this).parents('tr').removeClass("active");
                }
            });
            jQuery.uniform.update(set);
        });
        tableWrapper.find('.dataTables_length select').addClass("form-control input-xsmall input-inline");
    };

    var medicamentList = function () {

        var table = $('#medicamentList');

        // begin first table
        table.dataTable({

            "language": {
                "aria": {
                    "sortAscending": ": A-Z Sýrala",
                    "sortDescending": ": Z-A Sýrala"
                },
                "emptyTable": "Hiç veri bulumamadý.",
                "info": "_START_ - _END_ arasý gösteriliyor. Toplam _TOTAL_ kayýt bulundu.",
                "infoEmpty": "Kayýt bulunamadý.",
                "infoFiltered": "(filtered1 from _MAX_ total entries)",
                "lengthMenu": "Show _MENU_ entries",
                "search": "Ara:",
                "zeroRecords": "Sonuç bulunamadý."
            },

            "bStateSave": true,

            "columns": [{ "orderable": false }, {
                "orderable": true
            }, {
                "orderable": false
            }],
            "lengthMenu": [
                [5, 15, 20, -1],
                [5, 15, 20, "Hepsi"] // change per page values here
            ],
            // set the initial value
            "pageLength": 5,
            "pagingType": "bootstrap_full_number",
            "language": {
                "search": "My search: ",
                "lengthMenu": "  _MENU_ records",
                "paginate": {
                    "previous": "Prev",
                    "next": "Next",
                    "last": "Last",
                    "first": "First"
                }
            },
            "columnDefs": [{  // set default column settings
                'orderable': false,
                'targets': [0]
            }, {
                "searchable": false,
                "targets": [0]
            }],
            "order": [
                [1, "asc"]
            ] // set first column as a default sort by asc
        });

        var tableWrapper = jQuery('#nestListWrapper');

        table.find('.group-checkable').change(function () {
            var set = jQuery(this).attr("data-set");
            var checked = jQuery(this).is(":checked");
            jQuery(set).each(function () {
                if (checked) {
                    $(this).attr("checked", true);
                    $(this).parents('tr').addClass("active");
                } else {
                    $(this).attr("checked", false);
                    $(this).parents('tr').removeClass("active");
                }
            });
            jQuery.uniform.update(set);
        });
        tableWrapper.find('.dataTables_length select').addClass("form-control input-xsmall input-inline");
    };

    return {

        init: function () {
            if (!jQuery().dataTable) {
                return;
            }
            nestList();
            PoultryList();
            coopList();
            medicamentList();
        }

    };

}();