using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BattleShip
{
    //Class to congofure Autofac Container for Dependency Injection
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            //Init the container builder
            var builder = new ContainerBuilder();
            //Register all the classes as their interfaces
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(BattleShip)))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
            //Build the container
            return builder.Build();
        }
    }
}
