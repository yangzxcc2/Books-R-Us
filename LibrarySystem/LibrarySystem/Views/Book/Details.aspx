@model LibrarySystem.Models.Book

@{
    ViewBag.Title = "Details";

    <style>
        table {
            border: 1px solid;
            padding: 8px 8px 8px 8px;
        }
        th {
            background-color: black;
            color: white;
            padding: 8px 8px 8px 8px;
        }
        td {
            border: 1px solid;
            padding: 8px 8px 8px 8px
        }
    </style>
}

<h2>Details</h2>

<p>
    <table>
        <tr>
            <th>Book ID</th>
            <td>@Model.BookID</td>
        </tr>
        <tr>
            <th>Title</th>
            <td>@Model.Title</td>
        </tr>
        <tr>
            <th>Author</th>
            <td>@Model.Author</td>
        </tr>
        <tr>
            <th>Publisher</th>
            <td>@Model.Publisher</td>
        </tr>
        <tr>
            <th>Format</th>
            <td>@Model.Format</td>
        </tr>
        <tr>
            <th>Page</th>
            <td>@Model.Page</td>
        </tr>
        <tr>
            <th>ISBN</th>
            <td>@Model.ISBN</td>
        </tr>
    </table>
</p>


