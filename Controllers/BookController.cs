namespace BookMan.Controllers
{
    using Models;
    using Views;
    /// <summary>
    /// Lop dieu khien, giup ket noi 1 cuon sach voi giao dien hien thi cuon sach
    /// </summary>
    
    public class BookController
    {
        ///<summary>
        /// ghep noi mot du lieu 1 cuon sach voi giao dien hien thi 1 cuon sach
        /// </summary>
        ///<param name="id">ma dinh danh cuon sach</param>
        public void  Single(int id){
            Book model = new Book();
            //khoi tao view
            BookSingleView view = new BookSingleView(model);
            //Goi phuong thuc Render de hien thi ra man hinh
            view.Render();
        }
        /// <summary>
        /// Kich hoat chuc nang nhap du lieu cho mot cuon sach
        /// </summary>
        public void Create(){
            BookCreateView view = new BookCreateView();
            view.Render();
        }

        public void Update(int id){
            var model = new Book();
            var view  =  new BookUpdateView(model);
            view.Render();
        }
    }
}