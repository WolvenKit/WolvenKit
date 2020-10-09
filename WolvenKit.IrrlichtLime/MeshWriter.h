#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"
#include "MeshWriterType.h"
#include "MeshWriterFlag.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace IO { ref class WriteFile; }
namespace Scene {

ref class Mesh;


public ref class MeshWriter : ReferenceCounted
{
public:

	bool WriteMesh(IO::WriteFile^ file, Mesh^ mesh, MeshWriterFlag flags);

	property MeshWriterType Type { MeshWriterType get(); }

    void SetTransform(Matrix^ value);
    void SetImageType(System::String^ extension);


internal:

	static MeshWriter^ Wrap(scene::IMeshWriter* ref);
	MeshWriter(scene::IMeshWriter* ref);

	scene::IMeshWriter* m_MeshWriter;
};

} // end namespace Scene
} // end namespace IrrlichtLime