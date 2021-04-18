using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using ToDoList.BusinessLogic.DependecyResolvers.Interceptors;
using ToDoList.DataAccess;



namespace ToDoList.BusinessLogic.DependecyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoManager>().As<IToDoService>().SingleInstance();
            builder.RegisterType<ToDoDal>().As<IToDoDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
        
    }
}