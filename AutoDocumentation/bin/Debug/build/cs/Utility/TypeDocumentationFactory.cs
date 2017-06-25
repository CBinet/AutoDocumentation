using System.Reflection;

namespace AutoDocumentation {

    internal static class TypeDocumentationFactory {

        public static TypeDocumentation Create(TypeInfo typeDocumentation) {
            
            if (typeDocumentation.IsClass) {
                return new ClassDocumentation(typeDocumentation);
            } else if (typeDocumentation.IsInterface) {
                return new InterfaceDocumentation(typeDocumentation);
            } else if (typeDocumentation.IsEnum) {
                return new EnumDocumentation(typeDocumentation);
            } else {
                return new StructDocumentation(typeDocumentation);
            }
            
        }

    }

}