using System;
using System.Collections.Generic;
using System.Reflection;
using FluentNHibernate.MappingModel.Collections;

namespace FluentNHibernate.MappingModel.ClassBased
{
    public interface IComponentMapping
    {
        void AcceptVisitor(IMappingModelVisitor visitor);
        ParentMapping Parent { get; set; }
        bool Insert { get; set; }
        bool Update { get; set; }
        string Access { get; set; }
        Type ContainingEntityType { get; }
        string Name { get; }
        PropertyInfo PropertyInfo { get; }
        Type Type { get; }
        IEnumerable<ManyToOneMapping> References { get; }
        IEnumerable<ICollectionMapping> Collections { get; }
        IEnumerable<PropertyMapping> Properties { get; }
        IEnumerable<ComponentMappingBase> Components { get; }
        IEnumerable<OneToOneMapping> OneToOnes { get; }
        IEnumerable<AnyMapping> Anys { get; }
    }
}