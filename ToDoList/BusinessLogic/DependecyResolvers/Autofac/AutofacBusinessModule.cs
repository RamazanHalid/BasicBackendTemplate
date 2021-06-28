using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using ToDoList.BusinessLogic.Abstract;
using ToDoList.BusinessLogic.Concrete;
using ToDoList.BusinessLogic.DependecyResolvers.Interceptors;
using ToDoList.DataAccess;
using ToDoList.DataAccess.EntityFramework;


namespace ToDoList.BusinessLogic.DependecyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoManager>().As<IToDoService>().SingleInstance();
            builder.RegisterType<ToDoDal>().As<IToDoDal>().SingleInstance();

            builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            
            builder.RegisterType<AuthManager>().As<IAuthService>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
        
    }
}