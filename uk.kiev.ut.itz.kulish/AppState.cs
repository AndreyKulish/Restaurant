namespace Restaurant.controllers
{
    public class AppState
    {
        public enum CrudMode
        {
            CREATE,
            READ,
            UPDATE,
            DELETE,
            DEFAULT
        }

        public enum SelectedDao
        {
            CLIENT,
            DISH,
            MENU,
            PRODUCT,
            RESTAURANT,
            WORKER,
            STORY,
            DEFAULT
        }

        public static CrudMode crudMode = CrudMode.DEFAULT;
        public static SelectedDao selectedDao = SelectedDao.DEFAULT;
    }
}