#ifndef UTILS_HALFFLOAT
#define UTILS_HALFFLOAT

#include <iostream>

// Code from http://download.autodesk.com/us/maya/2009help/API/dds_float_reader_8cpp-example.html
/*
const double two_pow_neg14 = pow(2.0, -14.0);
inline float halfToFloat(unsigned short val)
{
        float outValue = 0.0f;


#if defined(OSMac_)
        // Need to swap bytes on Power PC (Mac)
        swap_endian_half( &val );
#endif

        // Convert 16-value into a float...
        double h_mantissa = (float) (val & 1023); // Mantissa = low order 10  bits
        double h_exponent = (float)  ((val >> 10) & 31); // Exponent = next 5 bits
        unsigned int i_sign = (val >> 15) & 1;  ; // Sign is the highest bit
        double h_sign = (i_sign == 0) ? 1.0 : -1.0;

        if (h_exponent != 30.0)
        {
                outValue = (float) (h_sign * pow(2.0, h_exponent-15.0) * ( 1.0 + ( h_mantissa / 1024.0 )));
        }
        else
        {
                outValue = (float) ( h_sign * pow(2.0, two_pow_neg14) * ( h_mantissa / 1024.0 ) );
        }
        //printf("[%d][%d] = inValue=%d, isign =%d, sign=%g, exp=%g, mant=%g, value=%g\n", y,x, *inPtr, i_sign, h_sign, h_exponent, h_mantissa, outValue);
        return outValue;
}
*/

union Float
{
    unsigned __int32 u32;
    float f32;
    struct // single precision floating point (binary32) format IEEE 754-2008
    {
        unsigned __int32 frac:23;
        unsigned __int32 exp:8;
        unsigned __int32 sign:1;
    };
};

union Half
{
    unsigned short u16;
    struct // half (binary16) format IEEE 754-2008
    {
        unsigned short frac:10;
        unsigned short exp:5;
        unsigned short sign:1;
    };
    Float toFloat()
    {
        Float f;
        f.sign=sign;
        switch(exp)
        {
            case 0: // subnormal : (-1)^sign * 2^-14 * 0.frac
            if(frac) // subnormals but non-zeros -> normals in float32
            {
                f.exp=-15+127;
                unsigned __int32 _frac(frac);
                while(!(_frac & 0x200)) { _frac<<=1; f.exp--; }
                f.frac=(_frac & 0x1FF)<<14;
            }
            else { f.frac=0; f.exp=0; } // ± 0 -> ± 0
            break;
            case 31: // infinity or NaNs : frac ? NaN : (-1)^sign * infinity
                f.exp=255;
                f.frac= frac ? 0x200000 : 0; // signaling Nan or zero
                break;
            default: // normal : (-1)^sign * 2^(exp-15) * 1.frac
                f.exp=exp-15+127;
                f.frac=((unsigned __int32)frac)<<13;
        }
        return f;
    }
};

inline float halfToFloat(unsigned short val)
{
    Half h;
    h.u16 = val;

    return h.toFloat().f32;
}

#endif // UTILS_HALFFLOAT

