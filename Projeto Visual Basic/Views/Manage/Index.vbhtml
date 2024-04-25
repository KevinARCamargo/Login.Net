@ModelType IndexViewModel
@Code
    ViewBag.Title = "Manage"
End Code


<h2>Welcome</h2>

<p class="text-success">@ViewBag.StatusMessage</p>
<div>
    
    <dl >
        <dt>Password: @Model.</dt>
        <dd>
            [
            @If Model.HasPassword Then
                @Html.ActionLink("Change your password", "ChangePassword")
            Else
                @Html.ActionLink("Create", "SetPassword")
            End If
            ]
        </dd>
       
        
    </dl>
</div>
