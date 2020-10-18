#include "StdAfx.h"
#include "Vector3f.h"
#include <cmath>
#include "Matrix4x4.h"


const Vector3f Vector3f::UnitX(1.f, 0.f, 0.f);
const Vector3f Vector3f::UnitY(0.f, 1.f, 0.f);
const Vector3f Vector3f::UnitZ(0.f, 0.f, 1.f);
const Vector3f Vector3f::Zero(0.0f, 0.0f, 0.0f);

Vector3f::Vector3f(void)
{
	vec[0] = vec[1] = vec[2] = 0.0f;
}

Vector3f::Vector3f(const float pX, const float pY, const float pZ)
{
	vec[0] = pX;
	vec[1] = pY;
	vec[2] = pZ;
}

Vector3f::Vector3f(const float value)
{
	vec[0] = value;
	vec[1] = value;
	vec[2] = value;
}

Vector3f::~Vector3f(void)
{
}

Vector3f& Vector3f::operator = (const Vector3f& otherVec)
{
	vec[0] = otherVec.vec[0];
	vec[1] = otherVec.vec[1];
	vec[2] = otherVec.vec[2];
	return *this;
}


Vector3f& Vector3f::operator += (const Vector3f& otherVec)
{
	vec[0] += otherVec.vec[0];
	vec[1] += otherVec.vec[1];
	vec[2] += otherVec.vec[2];
	return *this;
}


Vector3f& Vector3f::operator -= (const Vector3f& otherVec)
{
	vec[0] -= otherVec.vec[0];
	vec[1] -= otherVec.vec[1];
	vec[2] -= otherVec.vec[2];
	return *this;
}

Vector3f& Vector3f::operator *= (const Vector3f& otherVec)
{
	vec[0] *= otherVec.vec[0];
	vec[1] *= otherVec.vec[1];
	vec[2] *= otherVec.vec[2];
	return *this;
}

Vector3f& Vector3f::operator /= (const float k)
{
	vec[0] /= k;
	vec[1] /= k;
	vec[2] /= k;
	return *this;
}

Vector3f Vector3f::operator -(void) const
{
	return (Vector3f(-x, -y, -z));
}

Vector3f Vector3f::operator + (const Vector3f& otherVec)
{
	 return (Vector3f(x + otherVec.x, y + otherVec.y, z + otherVec.z));
}

Vector3f Vector3f::operator - (const Vector3f& otherVec)
{
	 return (Vector3f(x - otherVec.x, y - otherVec.y, z - otherVec.z));
}

Vector3f Vector3f::operator * (const float k)
{
	return (Vector3f(x*k, y*k, z*k));
}

Vector3f operator * (const float k, const Vector3f& rhs)
{
	return (Vector3f(rhs.x*k, rhs.y*k, rhs.z*k));
}

Vector3f Vector3f::operator / (const float k)
{
	const float f = 1.0f / k;
	return (Vector3f(x*f, y*f, z*f));
}

Vector3f operator + (const Vector3f& lhs, const Vector3f& rhs)
{
	return Vector3f( lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
}

Vector3f operator - (const Vector3f& lhs, const Vector3f& rhs)
{
	return Vector3f( lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
}

void Vector3f::Normalize(void)
{
	const float invModule = 1.0f / sqrtf(x*x + y*y + z*z);
	x = invModule * x;
	y = invModule * y;
	z = invModule * z;
}

float Vector3f::Length( void ) const
{
	return sqrtf(x*x + y*y + z*z);
}

bool Vector3f::operator==( const Vector3f& otherVec )
{
	return (x == otherVec.x && y == otherVec.y && z == otherVec.z);
}

bool Vector3f::operator!=( const Vector3f& otherVec )
{
	return (x != otherVec.x || y != otherVec.y || z != otherVec.z);
}

float Vector3f::Dot( const Vector3f& otherVec ) const
{
	return x*otherVec.x + y*otherVec.y + z*otherVec.z;
}

float Vector3f::Dot( const Vector3f& leftVector, const Vector3f& rightVector )
{
	return leftVector.x*rightVector.x + leftVector.y*rightVector.y + leftVector.z*rightVector.z;
}

Vector3f Vector3f::Cross( const Vector3f& otherVec )
{
	return Vector3f( (y * otherVec.z) - (z * otherVec.y), (z * otherVec.x) - (x * otherVec.z), (x * otherVec.y) - (y * otherVec.x) );
}

Vector3f Vector3f::Cross( const Vector3f& leftVector, const Vector3f& rightVector )
{
	return Vector3f( (leftVector.y * rightVector.z) - (leftVector.z * rightVector.y), 
					 (leftVector.z * rightVector.x) - (leftVector.x * rightVector.z), 
					 (leftVector.x * rightVector.y) - (leftVector.y * rightVector.x) );
}

Vector3f Vector3f::Transform( Vector3f originalVector, Matrix4x4 transformMatrix )
{
	Vector3f transformedVector;

	//TODO: optimize.
	transformedVector.x = originalVector.x * transformMatrix.M11 + originalVector.y * transformMatrix.M21 + originalVector.z * transformMatrix.M31 + transformMatrix.M41; 
	transformedVector.y = originalVector.x * transformMatrix.M12 + originalVector.y * transformMatrix.M22 + originalVector.z * transformMatrix.M32 + transformMatrix.M42; 
	transformedVector.z = originalVector.x * transformMatrix.M13 + originalVector.y * transformMatrix.M23 + originalVector.z * transformMatrix.M33 + transformMatrix.M43; 

	return transformedVector;
}


