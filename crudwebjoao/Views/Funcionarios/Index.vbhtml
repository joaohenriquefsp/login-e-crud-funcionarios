

@ModelType IEnumerable(Of crudwebjoao.Funcionario)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Funcionarios: </h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Sexo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cargo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Salario)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cidade)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Email)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Sexo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cargo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Salario)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cidade)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Email)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ID })
        </td>
    </tr>
Next

</table>
