#include "stdafx.h"
#include "Mesh.h"
#include "MeshWriter.h"
//#include "MeshWriterFlag.h"
//#include "MeshWriterType.h"
#include "WriteFile.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

MeshWriter^ MeshWriter::Wrap(scene::IMeshWriter* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew MeshWriter(ref);
}

MeshWriter::MeshWriter(scene::IMeshWriter* ref)	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_MeshWriter = ref;
}

bool MeshWriter::WriteMesh(IO::WriteFile^ file, Mesh^ mesh, MeshWriterFlag fl)
{
	return m_MeshWriter->writeMesh(
		LIME_SAFEREF(file, m_WriteFile),
		LIME_SAFEREF(mesh, m_Mesh),
		(E_MESH_WRITER_FLAGS)fl);
}

MeshWriterType MeshWriter::Type::get()
{
	return (MeshWriterType)m_MeshWriter->getType();
}

void MeshWriter::SetTransform(Matrix^ value)
{
    m_MeshWriter->setTransform(*(value->m_NativeValue));
}

void MeshWriter::SetImageType(System::String^ extension)
{
    core::stringc n = Lime::StringToStringC(extension);
    m_MeshWriter->setImageType(n);
}

} // end namespace Scene
} // end namespace IrrlichtLime