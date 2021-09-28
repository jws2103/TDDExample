using System;
using FreshMvvm;

namespace TDDExample
{
    public class CustomFreshPageModelMapper : IFreshPageModelMapper
    {
        public string GetPageTypeName(Type pageModelType)
        {
            var test = pageModelType.AssemblyQualifiedName
                .Replace("PageViewModel", "Page")
                .Replace("ViewModel", "View");
            return pageModelType.AssemblyQualifiedName
                .Replace("PageViewModel", "Page")
                .Replace("ViewModel", "View");
        }
    }
}
