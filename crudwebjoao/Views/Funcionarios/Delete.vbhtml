@ModelType crudwebjoao.Funcionario
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Funcionario</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nome)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Sexo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Sexo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cargo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cargo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Salario)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Salario)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cidade)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cidade)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
