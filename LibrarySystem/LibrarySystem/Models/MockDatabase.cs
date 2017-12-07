using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibrarySystem.Models{
    

    public class MockDatabase
    {
        private static MockDatabase Instance = new MockDatabase();
        private List<Book> BookList = new List<Book>();
        private List<Student> StudentList = new List<Student>();

        private MockDatabase()
        {

            BookList.Add(new Book()
            {
                BookId = "1",
                BookName = "The Fault in Our Stars",
                BookAuthor = "John Green",
                BookQuantity = "2"    
            });
            BookList.Add(new Book()
            {
                BookId = "2",
                BookName = "Divergent (Divergent, #1)",
                BookAuthor = "Veronica Roth",
                BookQuantity = "2"
            });
            BookList.Add(new Book()
            {
                BookId = "3",
                BookName = "Mockingjay (The Hunger Games, #3) ",
                BookAuthor = "Suzanne Collins",
                BookQuantity = "5"
            });
            BookList.Add(new Book()
            {
                BookId = "4",
                BookName = "GoneGirl",
                BookAuthor = "Gillian Flynn",
                BookQuantity = "2"
            });
            BookList.Add(new Book()
            {
                BookId = "5",
                BookName = "The Martian ",
                BookAuthor = "Andy Weir",
                BookQuantity = "6"
            });

        }
        public static MockDatabase GetInstance()
        {
            return Instance;
        }

        public List<Book> GetBookList()
        {
            return BookList;
        }
        public List<Student> GetStudentList()
        {
            return StudentList;
        }
        public List<Book> GetBookSubList(string Query)
        {
            List<Book> BookSubList = new List<Book>();
            foreach (var item in BookList)
            {
                if (item.BookName.ToLower().Contains(Query.ToLower()))
                {
                    BookSubList.Add(item);
                }
                else if (item.BookAuthor.ToLower().Contains(Query.ToLower()))
                {
                    BookSubList.Add(item);
                }
                else if (item.BookQuantity.ToLower().Contains(Query.ToLower()))
                {
                    BookSubList.Add(item);
                }
                else if (item.BookId.ToLower().Equals(Query.ToLower()))
                {
                    BookSubList.Add(item);
                }
            }
            return BookSubList;
        }
        public List<Student> GetStudentSubList(string Query)
        {
            List<Student> StudentSubList = new List<Student>();
            foreach (var item in StudentList)
            {
                if (item.StudentId.Equals(Query))
                {
                    StudentSubList.Add(item);
                }
                else if (item.StudentFirstName.ToLower().Contains(Query.ToLower()))
                {
                    StudentSubList.Add(item);
                }
                else if (item.StudentLastName.ToLower().Contains(Query.ToLower()))
                {
                    StudentSubList.Add(item);
                }
                else if (item.StudentFaculty.ToLower().Contains(Query.ToLower()))
                {
                    StudentSubList.Add(item);
                }
            }
            return StudentSubList;
        }
        public Book GetBookByID(string ID)
        {
            foreach (var item in BookList)
            {
                if (item.BookId.Equals(ID))
                {
                    return item;
                }
            }
            return null;
        }

        public Student GetPatronByID(string ID)
        {
            foreach (var item in StudentList)
            {
                if (item.StudentId.Equals(ID))
                {
                    return item;
                }
            }
            return null;
        }
    }
}

