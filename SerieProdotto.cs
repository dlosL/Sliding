using System;
using System.Collections.Generic;
using System.Linq;
public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span > digits.Length || span < 0)
        {
            throw new ArgumentException("Valore di intervallo non valido");
        }
        if (span == 0)
        {
            return 1;
        }
        long largestProduct = 0;
        for (int i = 0; i <= digits.Length - span; i++)
        {
            long product = 1;
            for (int j = 0; j < span; j++)
            {
                if (!char.IsDigit(digits[i+j]))
                {
                    throw new ArgumentException("Carattere non valido nella stringa di cifre");
                }
                product *= (long)char.GetNumericValue(digits[i+j]);
            }
            if (product > largestProduct)
            {
                largestProduct = product;
            }
        }
        return largestProduct;
    }
}