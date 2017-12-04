using System;

namespace Trainers.Api.Infrastructure
{
    public static class Assert
    {
        public static void ArgumentIsNull(object argument, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(argumentName))
            {
                throw new ArgumentException(nameof(argumentName));
            }

            if (argument == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }
    }
}