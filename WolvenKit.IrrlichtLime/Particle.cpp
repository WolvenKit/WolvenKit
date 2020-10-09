#include "stdafx.h"
#include "Particle.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

Particle^ Particle::Wrap(scene::SParticle* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew Particle(ref);
}

Particle::Particle(scene::SParticle* ref)
	: Lime::NativeValue<scene::SParticle>(false)
{
	LIME_ASSERT(ref != nullptr);
	m_NativeValue = ref;
}

Particle::Particle()
	: Lime::NativeValue<scene::SParticle>(true)
{
	m_NativeValue = new scene::SParticle();
}

Video::Color^ Particle::Color::get()
{
	return gcnew Video::Color(m_NativeValue->color);
}

void Particle::Color::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_NativeValue->color = *value->m_NativeValue;
}

unsigned int Particle::EndTime::get()
{
	return m_NativeValue->endTime;
}

void Particle::EndTime::set(unsigned int value)
{
	m_NativeValue->endTime = value;
}

Vector3Df^ Particle::Position::get()
{
	return gcnew Vector3Df(m_NativeValue->pos);
}

void Particle::Position::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_NativeValue->pos = *value->m_NativeValue;
}

Dimension2Df^ Particle::Size::get()
{
	return gcnew Dimension2Df(m_NativeValue->size);
}

void Particle::Size::set(Dimension2Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_NativeValue->size = *value->m_NativeValue;
}

Video::Color^ Particle::StartColor::get()
{
	return gcnew Video::Color(m_NativeValue->startColor);
}

void Particle::StartColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_NativeValue->startColor = *value->m_NativeValue;
}

Dimension2Df^ Particle::StartSize::get()
{
	return gcnew Dimension2Df(m_NativeValue->startSize);
}

void Particle::StartSize::set(Dimension2Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_NativeValue->startSize = *value->m_NativeValue;
}

unsigned int Particle::StartTime::get()
{
	return m_NativeValue->startTime;
}

void Particle::StartTime::set(unsigned int value)
{
	m_NativeValue->startTime = value;
}

Vector3Df^ Particle::StartVector::get()
{
	return gcnew Vector3Df(m_NativeValue->startVector);
}

void Particle::StartVector::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_NativeValue->startVector = *value->m_NativeValue;
}

Vector3Df^ Particle::Vector::get()
{
	return gcnew Vector3Df(m_NativeValue->vector);
}

void Particle::Vector::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_NativeValue->vector = *value->m_NativeValue;
}

String^ Particle::ToString()
{
	return String::Format("Particle: Position={0}; Vector={1}", Position, Vector);
}

} // end namespace Scene
} // end namespace IrrlichtLime