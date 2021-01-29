$(function () {
    $(".chb-filter").on("change", function () {
        filters = [];
        $("input.chb-filter:checked").each(function () { filters.push({ "id": parseInt($(this).attr("data-id")), "filterType": $(this).attr("data-type") }) });

        FilterAjaxRequest(filters);
    })

    $(document).on("click", ".bookmarkBtn", function () {
        var id = $(this).attr("data-id");
        let userSigned = $(".job-list").attr("data-user");
        if (userSigned == "True") {
            $.ajax({
                type: "GET",
                url: "/Job/Bookmark/" + id,
                success: function (data) {
                    body = '<div class="col-12" style="margin-bottom:5px;">' +
                        '<button class="btn btn-info unbookmarkBtn" data-id="' + id + '" style="float: right">' +
                        '<i class="fa fa-bookmark"></i> bookmarked</button></div>' +
                        '<div class="col-12" style="float:right">' +
                        '<button class="btn btn-success" style="float: right">' +
                        '<i class="fas fa-briefcase"></i> Applay For This Job' +
                        '</button></div>'
                    $(".bookmarkBtn[data-id=" + id + "]").closest(".row").html(body);
                },
                error: function () {
                    alert('b');
                }
            })
        } else {
            $("#modal-login").modal("show")
        }
    })
    $(document).on("click", ".unbookmarkBtn", function () {
        var id = $(this).attr("data-id");
        let userSigned = $(".job-list").attr("data-user");
        if (userSigned == "True") {
            $.ajax({
                type: "GET",
                url: "/Job/UnBookmark/" + id,
                success: function (data) {
                    body = '<div class="col-12" style="margin-bottom:5px;">' +
                        '<button class="btn btn-outline-info bookmarkBtn" data-id="' + id + '" style="float: right">' +
                        '<i class="far fa-bookmark"></i> bookmark</button></div>' +
                        '<div class="col-12" style="float:right">' +
                        '<button class="btn btn-success" style="float: right">' +
                        '<i class="fas fa-briefcase"></i> Applay For This Job' +
                        '</button></div>'
                    $(".unbookmarkBtn[data-id=" + id + "]").closest(".row").html(body);
                },
                error: function () {
                    alert('b');
                }
            })
        } else {
            $("#modal-login").modal("show")
        }
    })
    $(document).on("click", ".filteritem", function () {

        $(this).parents(".seachfilter-container").attr("data-id", $(this).attr("data-Id"));
        $(this).parents(".seachfilter-container").find("button").html($(this).html())
    })

    $("#hider-search-bar").on("click", function () {
        filters = [];
        if ($("#categoryfilter-container").attr("data-id")) {
            let category = {
                "filterType": "category",
                "id": parseInt($("#categoryfilter-container").attr("data-id"))
            };
            filters.push(category);
        }
        if ($("#locationfilter-container").attr("data-id")) {
            let location = {
                "filterType": "location",
                "id": parseInt($("#locationfilter-container").attr("data-id"))
            };
            filters.push(location);
        }
        if ($("#title-search-input").val() != "") {
            let title = {
                "filterType": "title",
                "title": $("#title-search-input").val()
            };
            filters.push(title);
        }
        if (filters.length > 0) {
        } else {
            toastr.info('Pleas fill some of search fields')
        }
        FilterAjaxRequest(filters);
        $("#categoryfilter-container").attr("data-id", "");
        $("#categoryfilter-container").find("button").html("Job Category");
        $("#locationfilter-container").attr("data-id", "");
        $("#locationfilter-container").find("button").html("Job Location");
        $("#title-search-input").val("");
        $("input.chb-filter:checked").prop("checked", false);
    })

    $(document).on("click", ".jobrow", function (e) {
        if (!$(e.target).hasClass("bookmarkBtn") && !$(e.target).hasClass("unbookmarkBtn")) {
            let id = $(this).attr("data-id")
            location.href='/Job/details/'+id
        }
    })
})

function FilterAjaxRequest(filters) {
    $.ajax({
        type: "POST",
        contentType: "application/json",
        url: "/Job/FilteredIndex",
        data: JSON.stringify(filters),
        success: function (data) {
            let jobs = JSON.parse(data);
            let body = "";
            if (jobs.length > 0) {
                $.each(jobs, function (index, item) {
                    body += '<div class="card-body border-bottom jobrow" data-id="'+item.Id+'">' +
                        '<div class="post" style="position:relative">' +
                        '<div style="margin-right: 20px; height: 65px;" class="float-left" >'+
                        '<img src = "'+item.Image+'" style = "height:100%" /></div >' +
                        '<h3 class="username">' + item.Title + '</h3>' +
                        '<span class="description mr-2"><i class="fas fa-map-marker-alt mr-1"></i>' + item.Location + '</span>' +
                        '<span class="description"><i class="far fa-clock mr-1"></i>' + item.EmploymentType + '</span>' +
                        '<div class="float-right" style="top: -7px; width: 200px; position: absolute; right: 0;">' +
                        '    <div class="row">'
                    if (item.Bookmarked) {
                        body += '<div class="col-12" style="margin-bottom:5px;">' +
                            '<button class="btn btn-info unbookmarkBtn" data-id="'+item.Id+'" style="float: right">' +
                            '<i class="fa fa-bookmark"></i> bookmarked</button></div>'
                    } else {
                        body += '<div class="col-12" style="margin-bottom:5px;">' +
                            '<a class="btn btn-outline-info bookmarkBtn" data-id="' + item.Id + '" style="float: right">' +
                            '<i class="far fa-bookmark"></i> bookmark</a></div>'
                    }
                    body += '<div class="col-12" style="float:right">' +
                        '<button class="btn btn-success" style="float: right">' +
                        '<i class="fas fa-briefcase"></i> Applay For This Job' +
                        '</button></div></div></div></div></div>'
                })
            } else {
                body += '<div class="card-body border-bottom" style="text-align: center;">Ther are no data </div>'
            }
            $(".job-list").html(body);
        },
        error: function () {
            alert('b');
        }
    })
}