@model LibrarySystem.Models.Book

@{
    ViewBag.Title = "Add";
}

<h2>Add</h2>

@using (Html.BeginForm())
{
    <label>Book ID: </label>
    @Html.TextBoxFor(model => model.BookID)<br>
    <label>Title: </label>
    @Html.TextBoxFor(model => model.Title)<br>
    <label>Author: </label>
    @Html.TextBoxFor(model => model.Author)<br>
    <label>Publisher: </label>
    @Html.TextBoxFor(model => model.Publisher)<br>
    <label>Format: </label>
    @Html.TextBoxFor(model => model.Format)<br>
    <label>Page: </label>
    @Html.TextBoxFor(model => model.Page)<br>
    <label>ISBN: </label>
    @Html.TextBoxFor(model => model.ISBN)<br>
    <input type="submit" value="Add">
}

