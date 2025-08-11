using DataAccessLibrary;


namespace BusinessLogicLayerLibrary
{
    public class CategoryBAL
    {
        public int CategoryID { get; set; }

        string _catname;
        public string CategoryName
        {
            get { return _catname; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _catname = value;
                }
                else
                {
                    throw new InvalidDataException("Category name cannot be empty.");
                }
            }
        }
        string _catdesc;
        public string CategoryDescription
        {
            get
            {
                return _catdesc;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _catdesc = value;
                }
                else
                {
                    throw new InvalidDataException("Category description cannot be empty.");
                }
            }
        }
        CategoriesOperations operations = new CategoriesOperations();
        public List<CategoryBAL> CategoryList()
        {

            List<Category> Categorieslist = operations.ShowAll();
            List<CategoryBAL> categoryBALs = new List<CategoryBAL>();
            foreach (var item in Categorieslist)
            {
                //CategoryBAL bal = new CategoryBAL();
                //bal.CategoryID = item.CatID;
                //bal.CategoryName = item.Name;
                //bal.CategoryDescription = item.Description;
                //categoryBALs.Add(bal);

                categoryBALs.Add(new CategoryBAL
                {
                    CategoryID = item.CatID,
                    CategoryName = item.Name,
                    CategoryDescription = item.Description
                });

            }
            return categoryBALs;

        }
        public void AddProduct(CategoryBAL category)
        {
            //DataAccessLibrary.CategoriesOperations categoriesOperations = new DataAccessLibrary.CategoriesOperations();
            //categoriesOperations.NewCategory(category);
        }
        public void RemoveProduct(int Categoryid)
        {
            //DataAccessLibrary.CategoriesOperations categoriesOperations = new DataAccessLibrary.CategoriesOperations();
            //categoriesOperations.DeleteCategory(id);
        }
        public void EditProduct(int Categoryid, CategoryBAL category)
        {
            //DataAccessLibrary.CategoriesOperations categoriesOperations = new DataAccessLibrary.CategoriesOperations();
            //categoriesOperations.UpdateCategory(id, newDetails);
        }
        //public CategoryBAL FindCategoryByID(int categoryid)
        //{             //DataAccessLibrary.CategoriesOperations categoriesOperations = new DataAccessLibrary.CategoriesOperations();
        //    //return categoriesOperations.SearchCategory(id);
        //}
        //public CategoryBAL FindCategoryByName(string name)
        //{
        //    //DataAccessLibrary.CategoriesOperations categoriesOperations = new DataAccessLibrary.CategoriesOperations();
        //    //return categoriesOperations.SearchCategory(name);
        //}
    }

}