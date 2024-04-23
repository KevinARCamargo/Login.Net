@ModelType LoginViewModel
@Code
    ViewBag.Title = "Log in"
End Code

<style>
    /* Adicione seus estilos CSS personalizados aqui */
    .custom-logo {
        
    }

    .custom-form {
        margin-top: 15%;
    }
</style>

<div class="row">
    <div class="col-md-6 custom-logo">
        <img src="../images/logo.png" alt="Logo da Empresa" class="img-responsive" />
    </div>
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
                            <input type="submit" value="Log in" class="btn btn-default" />
                        </div>
                    </div>
                    <p>
                        @Html.ActionLink("Register as a new user", "Register")
                    </p>
                    @* Enable this once you have account confirmation enabled for password reset functionality
                        <p>
                            @Html.ActionLink("Forgot your password?", "ForgotPassword")
                        </p>*@
                </text>
            End Using
        </section>
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
