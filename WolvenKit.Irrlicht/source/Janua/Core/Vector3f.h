/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once
#include "Matrix4x4.h"
#pragma warning(disable: 4201)

class Vector3f
{
public:

	union 
	{
		float vec[3];
		struct
		{
			 float x;
			 float y;
			 float z;
		};
	};


	//Constructors;
	Vector3f(void); //Initialized with zero.

	Vector3f(const float x, const float y, const float z);
	Vector3f(const float value);
	
	~Vector3f(void);

	Vector3f& Vector3f::operator = (const Vector3f& otherVec);
	Vector3f& Vector3f::operator += (const Vector3f& otherVec);
	Vector3f& Vector3f::operator -= (const Vector3f& otherVec);
	Vector3f& Vector3f::operator *= (const Vector3f& otherVec);
	Vector3f& Vector3f::operator /= (const float k);

	Vector3f Vector3f::operator + (const Vector3f& otherVec);
	Vector3f Vector3f::operator - (const Vector3f& otherVec);
	Vector3f Vector3f::operator * (const float k); //Scalar multiply
	Vector3f Vector3f::operator / (const float k);


	friend Vector3f operator + (const Vector3f& lhs, const Vector3f& rhs);
	friend Vector3f operator - (const Vector3f& lhs, const Vector3f& rhs);

	friend Vector3f operator * (const float k, const Vector3f& rhs );

	Vector3f Vector3f::operator - (void) const; //Negate vector

	bool Vector3f::operator == (const Vector3f& otherVec);
	bool Vector3f::operator != ( const Vector3f& otherVec );


	float& operator [](int i){ return (vec[i]);}
	const float& operator [](int i)const{ return (vec[i]); }

	void Vector3f::Normalize(void);

	float Dot( const Vector3f& otherVec) const;
	Vector3f Cross( const Vector3f& otherVec);

	static Vector3f Cross( const Vector3f& leftVector,  const Vector3f& rightVector );
	static float Dot( const Vector3f& leftVector,  const Vector3f& rightVector );

	float Length(void) const;

	static Vector3f Transform( Vector3f originalVector, Matrix4x4 transformMatrix );

	//Constants
	static const Vector3f UnitX;
	static const Vector3f UnitY;
	static const Vector3f UnitZ;
	static const Vector3f Zero;
						
private:
	

};

