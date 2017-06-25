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
        protected readonly List<string> ImplementedInterfaces;
        protected List<FieldDocumentation> DeclaredFields;
        protected List<ConstructorDocumentation> DeclaredConstructors;
        protected List<MethodDocumentation> DeclaredMethods;
        protected readonly List<Type> TypeArguments;
        protected string[] Enums;

        #region Base constructor(s)

        protected TypeDocumentation(Type pTypeInfo) {
            Namespace = pTypeInfo.Namespace;
            Name = pTypeInfo.Name;
            IsPublic = pTypeInfo.IsPublic;
            IsAbstract = pTypeInfo.IsAbstract;
            BaseType = pTypeInfo.BaseType?.Name;
            ImplementedInterfaces = pTypeInfo.GetInterfaces().Select(i => i.Name).ToList();
            TypeArguments = pTypeInfo.GetGenericArguments().ToList();
        }

        protected TypeDocumentation(FieldInfo pFieldInfo) {
            Name = pFieldInfo.Name;
            IsPublic = pFieldInfo.IsPublic;
            IsPrivate = pFieldInfo.IsPrivate;
            IsStatic = pFieldInfo.IsStatic;
        }

        protected TypeDocumentation(MethodBase pCtorInfo) {
            Name = pCtorInfo.DeclaringType?.Name;
            IsPublic = pCtorInfo.IsPublic;
            IsPrivate = pCtorInfo.IsPrivate;
            IsStatic = pCtorInfo.IsStatic;
            IsAbstract = pCtorInfo.IsAbstract;
        }

        protected TypeDocumentation(MethodInfo pMethodInfo) {
            Name = pMethodInfo.Name;
            IsPublic = pMethodInfo.IsPublic;
            IsPrivate = pMethodInfo.IsPrivate;
            IsAbstract = pMethodInfo.IsAbstract;
            IsStatic = pMethodInfo.IsStatic;
        }

        #endregion

        public abstract string ToMarkdown();

        public string GetName() {
            return Name;
        }

    }

}