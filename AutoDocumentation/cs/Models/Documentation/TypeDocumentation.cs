using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AutoDocumentation {

    internal abstract class TypeDocumentation {

        protected readonly string Namespace;
        protected readonly string Name;
        protected string FullName => Namespace + "." + Name;
        protected readonly bool IsPublic;
        protected readonly bool IsPrivate;
        protected readonly bool IsAbstract;
        protected readonly bool IsStatic;
        protected readonly string BaseType;
        protected readonly IList<string> ImplementedInterfaces;
        protected IList<FieldDocumentation> DeclaredFields;
        protected IList<ConstructorDocumentation> DeclaredConstructors;
        protected IList<MethodDocumentation> DeclaredMethods;
        protected string[] Enums;

        #region Base constructor(s)

        protected TypeDocumentation(Type pTypeDocumentation) {
            Namespace = pTypeDocumentation.Namespace;
            Name = pTypeDocumentation.Name;
            IsPublic = pTypeDocumentation.IsPublic;
            IsAbstract = pTypeDocumentation.IsAbstract;
            BaseType = pTypeDocumentation.BaseType?.Name;
            ImplementedInterfaces = pTypeDocumentation.GetInterfaces().Select(i => i.Name).ToList();
        }

        protected TypeDocumentation(FieldInfo pTypeDocumentation) {
            Name = pTypeDocumentation.Name;
            IsPublic = pTypeDocumentation.IsPublic;
            IsPrivate = pTypeDocumentation.IsPrivate;
            IsStatic = pTypeDocumentation.IsStatic;
        }

        protected TypeDocumentation(MethodBase pCtorDocumentation) {
            Name = pCtorDocumentation.DeclaringType?.Name;
            IsPublic = pCtorDocumentation.IsPublic;
            IsPrivate = pCtorDocumentation.IsPrivate;
            IsStatic = pCtorDocumentation.IsStatic;
            IsAbstract = pCtorDocumentation.IsAbstract;
        }

        protected TypeDocumentation(MethodInfo pMethodDocumentation) {
            Name = pMethodDocumentation.Name;
            IsPublic = pMethodDocumentation.IsPublic;
            IsPrivate = pMethodDocumentation.IsPrivate;
            IsAbstract = pMethodDocumentation.IsAbstract;
            IsStatic = pMethodDocumentation.IsStatic;
        }

        #endregion

        public abstract string ToMarkdown();

        public string GetName() {
            return Name;
        }

    }

}