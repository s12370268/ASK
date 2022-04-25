$(function () {

    $('#page_selector').change(function () {
        var url = $(this).val();
        if (url) {
        $('#main').html('');
            $.get(url, function (data) { $('#main').html(data) });
        }
    });
});

function LoginSuccess(data) {
    
    if (data.status) {
        Swal.fire({
            title: '恭喜你登入成功~.',
            width: 600,
            padding: '3em',
            color: '#716add',
            background: '#fff url(/images/trees.png)',
            backdrop: `
    rgba(0,0,123,0.4)
    url("/images/nyan-cat.gif")
    left top
    no-repeat
  `
        }).then(() => { window.location = "/"; }
        );
    }
};


function Flyout(data) {
    if (data.status) {
        Swal.fire({
            title: '飛出去啦~' + data.title,
            width: 600,
            padding: '3em',
            color: '#716add',
            background: '#fff url(/images/trees.png)',
            backdrop: `
    rgba(0,0,123,0.4)
    url("/images/nyan-cat.gif")
    left top
    no-repeat
  `
        });
    }

}