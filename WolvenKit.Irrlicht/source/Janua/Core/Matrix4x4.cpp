#include "StdAfx.h"
#include "Matrix4x4.h"


Matrix4x4::Matrix4x4(void)
{
	//TODO: Clean this up!
	for (int c = 0 ; c < 16;c++)
	{
		vec[c] = 0.0f;
	}

	M11 = M22 = M33 = M44 = 1.0f;
}


Matrix4x4::~Matrix4x4(void)
{
}
