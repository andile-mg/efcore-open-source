// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Microsoft.EntityFrameworkCore.Metadata
{
    internal partial class PrincipalDerivedEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.Internal.CSharpRuntimeModelCodeGeneratorTest+PrincipalDerived<Microsoft.EntityFrameworkCore.Scaffolding.Internal.CSharpRuntimeModelCodeGeneratorTest+DependentBase<byte?>>",
                typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalDerived<CSharpRuntimeModelCodeGeneratorTest.DependentBase<byte?>>),
                baseEntityType,
                discriminatorValue: "PrincipalDerived<DependentBase<byte?>>",
                propertyCount: 0,
                navigationCount: 2,
                skipNavigationCount: 1,
                foreignKeyCount: 1);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("Id"), declaringEntityType.FindProperty("AlternateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id"), principalEntityType.FindProperty("AlternateId") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                unique: true,
                required: true);

            return runtimeForeignKey;
        }

        public static RuntimeSkipNavigation CreateSkipNavigation1(RuntimeEntityType declaringEntityType, RuntimeEntityType targetEntityType, RuntimeEntityType joinEntityType)
        {
            var skipNavigation = declaringEntityType.AddSkipNavigation(
                "Principals",
                targetEntityType,
                joinEntityType.FindForeignKey(
                    new[] { joinEntityType.FindProperty("DerivedsId"), joinEntityType.FindProperty("DerivedsAlternateId") },
                    declaringEntityType.FindKey(new[] { declaringEntityType.FindProperty("Id"), declaringEntityType.FindProperty("AlternateId") }),
                    declaringEntityType),
                true,
                false,
                typeof(ICollection<CSharpRuntimeModelCodeGeneratorTest.PrincipalBase>),
                propertyInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalDerived<CSharpRuntimeModelCodeGeneratorTest.DependentBase<byte?>>).GetProperty("Principals", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CSharpRuntimeModelCodeGeneratorTest.PrincipalDerived<CSharpRuntimeModelCodeGeneratorTest.DependentBase<byte?>>).GetField("<Principals>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                eagerLoaded: true,
                lazyLoadingEnabled: false);

            var inverse = targetEntityType.FindSkipNavigation("Deriveds");
            if (inverse != null)
            {
                skipNavigation.Inverse = inverse;
                inverse.Inverse = skipNavigation;
            }

            return skipNavigation;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PrincipalDerived");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}