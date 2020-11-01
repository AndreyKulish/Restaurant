namespace Restaurant.controllers
{
    public abstract class AbstractCrudDao
    {
       public abstract void Create();
       public abstract void Read();
       public abstract void Update();
       public abstract void Delete();

       public void crudSelector()
       {
           switch (AppState.crudMode)
           {
               case AppState.CrudMode.CREATE:
                   Create();
                   break;
               case AppState.CrudMode.READ:
                   Read();
                   break;
               case AppState.CrudMode.UPDATE:
                   Update();
                   break;
               case AppState.CrudMode.DELETE:
                   Delete();
                   break;
           }
       }
    }
}