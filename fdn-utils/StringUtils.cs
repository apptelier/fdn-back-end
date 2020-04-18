﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Ardalis.GuardClauses;

namespace fdn_utils
{
    public class StringUtils
    {
        private static readonly Random Random = new Random();

        [SuppressMessage("ReSharper", "StringLiteralTypo")]
        public static string RandomString(int length)
        {
            Guard.Against.OutOfRange(length, nameof(length), 1, 255);

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}