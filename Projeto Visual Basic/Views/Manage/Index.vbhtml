@ModelType IndexViewModel
@Code
    ViewBag.Title = "Manage"
End Code


<h2>We are working on it :(</h2>

<p class="text-success">@ViewBag.StatusMessage</p>
<div>
    <p>I'm sorry, this page is still in production there hasn't been much here but you can change your password:</p>
    @If Model.HasPassword Then
        @Html.ActionLink("Change your password", "ChangePassword")
    Else
        @Html.ActionLink("Create", "SetPassword")
    End If
</div>
