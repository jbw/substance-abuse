using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

public static class SubstanceParametersExtensions
{
    public static IEnumerable<SubstanceProperty> GetProperties(this SubstanceParameters source)
    {
        var properties = source.GetType().GetFields().ToList();

        return properties.Select(x =>
        {
            var values = x.GetCustomAttributes(typeof(InputParameterAttribute), false).Cast<InputParameterAttribute>();
            var name = values.FirstOrDefault();

            var value = source.GetType().GetField(x.Name).GetValue(source);

            var property = new SubstanceProperty(name.ToString(), (float)value);
            return property;

        });
    }

    private static class MemberInfoGetting
    {
        public static string GetMemberName<T>(Expression<Func<T>> memberExpression)
        {
            MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }
    }
}

