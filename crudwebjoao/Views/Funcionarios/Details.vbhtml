@ModelType crudwebjoao.Funcionario
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
