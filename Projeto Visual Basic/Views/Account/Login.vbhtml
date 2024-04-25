@ModelType LoginViewModel
@Code
    ViewBag.Title = "Log in"
End Code

<style>
    
    .custom-form {
        margin-top: 15%;
    }

    .btn-custom{
        margin-left: 21%;
        width: 20%;
    }

    .p-custom{
        margin-left: 30%;
    }
</style>

<!-- Inicio do Formulário -->
<div class="row">
    <!-- Logo -->
    <div class="col-md-6 custom-logo">
        <img src="../images/logo.png" alt="Logo da Empresa" class="img-responsive" />
    </div>

    <!-- Form -->
    <div class="col-md-6 custom-form">
        <section id="loginForm">
            @Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                @Html.AntiForgeryToken()
                @<text>
                    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                    <div class="form-group">
                        @Html.LabelFor(Function(m) m.Email, New With {.class = "col-md-2 control-label"})
                        <div class="col-md-10">
                            @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-danger"})
                        </div>
                    </div>
                    <div class="form-group">
                        @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-2 control-label"})
                        <div class="col-md-10">
                            @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "text-danger"})
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <div class="checkbox">
                                @Html.CheckBoxFor(Function(m) m.RememberMe)
                                @Html.LabelFor(Function(m) m.RememberMe)
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <input type="submit" value="Login" class="btn btn-success btn-custom" />
                        </div>
                    </div>
                    <p class= "p-custom" >
                        @Html.ActionLink("Register as a new user", "Register", Nothing, New With {.style = "color: #5CB85C;"})
                    </p>
                </text>
            End Using
        </section>
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
