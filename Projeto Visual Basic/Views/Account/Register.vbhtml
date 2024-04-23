@ModelType RegisterViewModel
@Code
    ViewBag.Title = "Register"
End Code

<style>

    .custom-form {
        margin-top: 10%;
    }
    .btn-custom{
        margin-left: 21%;
        width: 20%;
    }

</style>

<!-- Inicio do Formulário -->
<div class="row">
    <!-- Imagem -->
    <div class="col-md-6 custom-logo">
        <img src="../images/logo.png" alt="Logo da Empresa" class="img-responsive" />
    </div>
    <!-- Form -->
    <div class="col-md-6 custom-form">
        <h2>@ViewBag.Title.</h2>
        @Using Html.BeginForm("Register", "Account", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
            @Html.AntiForgeryToken()
            @<text>
                <h4>Create a new account.</h4>
                <hr/>
                <!-- Função que recebe e exibe a lista de erros nos campos do formulário -->
                @Html.ValidationSummary("", New With {.class = "text-danger"})
                
                <!-- Campos -->
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.Email, New With {.class = "col-md-2 control-label"})
                    <div class="col-md-10">
                        @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                    </div>
                </div>
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-2 control-label"})
                    <div class="col-md-10">
                        @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                    </div>
                </div>
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "col-md-2 control-label"})
                    <div class="col-md-10">
                        @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
                    </div>
                </div>

                <!-- Botão de Registro -->
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <input type="submit" class="btn btn-success btn-custom" value="Register" />
                    </div>
                </div>
            </text>
        End Using
    </div>
</div>

@section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
