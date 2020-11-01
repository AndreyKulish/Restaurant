namespace Restaurant.controllers
{
    public class AppState
    {
        public enum CrudMode
        {
            CREATE,
            READ,
            UPDATE,
            DELETE
        }

        public enum SelectedDao
        {
            CLIENT,
            DISH,
            MENU,
            PRODUCT,
            RESTAURANT,
            WORKER
        }

        public static CrudMode crudMode;
        public static SelectedDao selectedDao;
    }
}