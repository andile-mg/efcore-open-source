// <auto-generated />
using System;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Scaffolding;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    public static class LazyPropertyDelegateEntityUnsafeAccessors
    {
        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Id>k__BackingField")]
        public static extern ref int Id(CompiledModelInMemoryTest.LazyPropertyDelegateEntity @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<LazyConstructorEntityId>k__BackingField")]
        public static extern ref int LazyConstructorEntityId(CompiledModelInMemoryTest.LazyPropertyDelegateEntity @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<LazyConstructorEntity>k__BackingField")]
        public static extern ref CompiledModelInMemoryTest.LazyConstructorEntity LazyConstructorEntity(CompiledModelInMemoryTest.LazyPropertyDelegateEntity @this);
    }
}
