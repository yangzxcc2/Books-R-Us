@model List<LibrarySystem.Models.Book>

@{
    ViewBag.Title = "Search";

    <style>
        table {
            border: 1px solid #ddd;
            padding: 8px;
            width: 100%
        }

        th {
            background: black;
            color: white;
            text-align: center;
            padding-top: 8px;
            padding-bottom: 8px;
        }

        td {
            border: 1px solid #ddd;
            padding-top: 8px;
            padding-bottom: 8px;
        }

        tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        tr:hover {
            background-color: #ddd;
        }
    </style>
}

<h2>Search</h2>

<p>
@using (Html.BeginForm())
{
    @Html.TextBox("query", "")
    <input type="submit" value="Search">
}
</p>

<table>
    <tr>
        <th>Title</th>
        <th>Author</th>
        <th>Publisher</th>
        <th>Options</th>
    </tr>
    @foreach (var item in Model)
    {
        <tr>
            <td>@item.Title</td>
            <td>@item.Author</td>
            <td>@item.Publisher</td>
            <td style="text-align: center">@Html.ActionLink("Details", "Details", "Book", new {  bookID = item.BookID }, null) | @Html.ActionLink("Edit", "Edit", "Book", new { bookID = item.BookID }, null) | @Html.ActionLink("Delete", "Delete", "Book", new {  bookID = item.BookID }, null) | @Html.ActionLink("Borrow", "Borrow", "Library", new { bookID = item.BookID }, null) | @Html.ActionLink("Return", "Return", "Library", new { bookID = item.BookID }, null)</td>
        </tr>
        }
</table>



