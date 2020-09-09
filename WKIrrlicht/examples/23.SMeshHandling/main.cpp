/** Example 023 SMeshBufferHandling

A tutorial by geoff.

In this tutorial we'll learn how to create custom meshes and deal with them
with Irrlicht. We'll create an interesting heightmap with some lighting effects.
With keys 1,2,3 you can choose a different mesh layout, which is put into the
mesh buffers as desired. All positions, normals, etc. are updated accordingly.

Ok, let's start with the headers (I think there's nothing to say about it)
*/

#include <irrlicht.h>
#include "driverChoice.h"

#ifdef _MSC_VER
#pragma comment(lib, "Irrlicht.lib")
#endif

//Namespaces for the engine
using namespace irr;
using namespace video;
using namespace core;
using namespace scene;
using namespace io;
using namespace gui;

/* This is the type of the functions which work out the colour. */
typedef SColor colour_func(f32 x, f32 y, f32 z);

/* Here comes a set of functions which can be used for coloring the nodes while
creating the mesh. */

// Greyscale, based on the height.
SColor grey(f32, f32, f32 z)
{
	u32 n = (u32)(255.f * z);
	return SColor(255, n, n, n);
}

// Interpolation between blue and white, with red added in one
// direction and green in the other.
SColor yellow(f32 x, f32 y, f32)
{
	return SColor(255, 128 + (u32)(127.f * x), 128 + (u32)(127.f * y), 255);
}

// Pure white.
SColor white(f32, f32, f32) { return SColor(255, 255, 255, 255); }

/* The type of the functions which generate the heightmap. x and y
range between -0.5 and 0.5, and s is the scale of the heightmap. */

typedef f32 generate_func(s16 x, s16 y, f32 s);

// An interesting sample function :-)
f32 eggbox(s16 x, s16 y, f32 s)
{
	const f32 r = 4.f*sqrtf((f32)(x*x + y*y))/s;
	const f32 z = expf(-r * 2) * (cosf(0.2f * x) + cosf(0.2f * y));
	return 0.25f+0.25f*z;
}

// A rather dumb sine function :-/
f32 moresine(s16 x, s16 y, f32 s)
{
	const f32 xx=0.3f*(f32)x/s;
	const f32 yy=12*y/s;
	const f32 z = sinf(xx*xx+yy)*sinf(xx+yy*yy);
	return 0.25f + 0.25f * z;
}

// A simple function
f32 justexp(s16 x, s16 y, f32 s)
{
	const f32 xx=6*x/s;
	const f32 yy=6*y/s;
	const f32 z = (xx*xx+yy*yy);
	return 0.3f*z*cosf(xx*yy);
}

/* A simple class for representing heightmaps. Most of this should be obvious. */

class HeightMap
{
private:
	const u16 Width;
	const u16 Height;
	f32 s;
	core::array<f32> data;
public:
	HeightMap(u16 _w, u16 _h) : Width(_w), Height(_h), s(0.f), data(0)
	{
		s = sqrtf((f32)(Width * Width + Height * Height));
		data.set_used(Width * Height);
	}

	// Fill the heightmap with values generated from f.
	void generate(generate_func f)
	{
		u32 i=0;
		for(u16 y = 0; y < Height; ++y)
			for(u16 x = 0; x < Width; ++x)
				set(i++, calc(f, x, y));
	}

	u16 height() const { return Height; }
	u16 width() const { return Width; }

	f32 calc(generate_func f, u16 x, u16 y) const
	{
		const f32 xx = (f32)x - Width*0.5f;
		const f32 yy = (f32)y - Height*0.5f;
		return f((u16)xx, (u16)yy, s);
	}

	// The height at (x, y) is at position y * Width + x.

	void set(u16 x, u16 y, f32 z) { data[y * Width + x] = z; }
	void set(u32 i, f32 z) { data[i] = z; }
	f32 get(u16 x, u16 y) const { return data[y * Width + x]; }

	/* The only difficult part. This considers the normal at (x, y) to
	be the cross product of the vectors between the adjacent points
	in the horizontal and vertical directions.

	s is a scaling factor, which is necessary if the height units are
	different from the coordinate units; for example, if your map has
	heights in meters and the coordinates are in units of a
	kilometer. */

	vector3df getnormal(u16 x, u16 y, f32 s) const
	{
		const f32 zc = get(x, y);
		f32 zl, zr, zu, zd;

		if (x == 0)
		{
			zr = get(x + 1, y);
			zl = zc + zc - zr;
		}
		else if (x == Width - 1)
		{
			zl = get(x - 1, y);
			zr = zc + zc - zl;
		}
		else
		{
			zr = get(x + 1, y);
			zl = get(x - 1, y);
		}

		if (y == 0)
		{
			zd = get(x, y + 1);
			zu = zc + zc - zd;
		}
		else if (y == Height - 1)
		{
			zu = get(x, y - 1);
			zd = zc + zc - zu;
		}
		else
		{
			zd = get(x, y + 1);
			zu = get(x, y - 1);
		}

		return vector3df(s * 2 * (zl - zr), 4, s * 2 * (zd - zu)).normalize();
	}
};

/* A class which generates a mesh from a heightmap. */
class TMesh
{
private:
	u16 Width;
	u16 Height;
	f32 Scale;
public:
	SMesh* Mesh;

	TMesh() : Mesh(0), Width(0), Height(0), Scale(1.f)
	{
		Mesh = new SMesh();
	}

	~TMesh()
	{
		Mesh->drop();
	}

	// Unless the heightmap is small, it won't all fit into a single
	// SMeshBuffer. This function chops it into pieces and generates a
	// buffer from each one.

	void init(const HeightMap &hm, f32 scale, colour_func cf, IVideoDriver *driver)
	{
		Scale = scale;

		const u32 mp = driver -> getMaximalPrimitiveCount();
		Width = hm.width();
		Height = hm.height();

		const u32 sw = mp / (6 * Height); // the width of each piece

		u32 i=0;
		for(u32 y0 = 0; y0 < Height; y0 += sw)
		{
			u16 y1 = y0 + sw;
			if (y1 >= Height)
				y1 = Height - 1; // the last one might be narrower
			addstrip(hm, cf, y0, y1, i);
			++i;
		}
		if (i<Mesh->getMeshBufferCount())
		{
			// clear the rest
			for (u32 j=i; j<Mesh->getMeshBufferCount(); ++j)
			{
				Mesh->getMeshBuffer(j)->drop();
			}
			Mesh->MeshBuffers.erase(i,Mesh->getMeshBufferCount()-i);
		}
		// set dirty flag to make sure that hardware copies of this
		// buffer are also updated, see IMesh::setHardwareMappingHint
		Mesh->setDirty();
		Mesh->recalculateBoundingBox();
	}

	// Generate a SMeshBuffer which represents all the vertices and
	// indices for values of y between y0 and y1, and add it to the
	// mesh.

	void addstrip(const HeightMap &hm, colour_func cf, u16 y0, u16 y1, u32 bufNum)
	{
		SMeshBuffer *buf = 0;
		if (bufNum<Mesh->getMeshBufferCount())
		{
			buf = (SMeshBuffer*)Mesh->getMeshBuffer(bufNum);
		}
		else
		{
			// create new buffer
			buf = new SMeshBuffer();
			Mesh->addMeshBuffer(buf);
			// to simplify things we drop here but continue using buf
			buf->drop();
		}
		buf->Vertices.set_used((1 + y1 - y0) * Width);

		u32 i=0;
		for (u16 y = y0; y <= y1; ++y)
		{
			for (u16 x = 0; x < Width; ++x)
			{
				const f32 z = hm.get(x, y);
				const f32 xx = (f32)x/(f32)Width;
				const f32 yy = (f32)y/(f32)Height;

				S3DVertex& v = buf->Vertices[i++];
				v.Pos.set(x, Scale * z, y);
				v.Normal.set(hm.getnormal(x, y, Scale));
				v.Color=cf(xx, yy, z);
				v.TCoords.set(xx, yy);
			}
		}

		buf->Indices.set_used(6 * (Width - 1) * (y1 - y0));
		i=0;
		for(u16 y = y0; y < y1; ++y)
		{
			for(u16 x = 0; x < Width - 1; ++x)
			{
				const u16 n = (y-y0) * Width + x;
				buf->Indices[i]=n;
				buf->Indices[++i]=n + Width;
				buf->Indices[++i]=n + Width + 1;
				buf->Indices[++i]=n + Width + 1;
				buf->Indices[++i]=n + 1;
				buf->Indices[++i]=n;
				++i;
			}
		}

		buf->recalculateBoundingBox();
	}
};

/*
Our event receiver implementation, taken from tutorial 4.
*/
class MyEventReceiver : public IEventReceiver
{
public:
	// This is the one method that we have to implement
	virtual bool OnEvent(const SEvent& event)
	{
		// Remember whether each key is down or up
		if (event.EventType == irr::EET_KEY_INPUT_EVENT)
			KeyIsDown[event.KeyInput.Key] = event.KeyInput.PressedDown;

		return false;
	}

	// This is used to check whether a key is being held down
	virtual bool IsKeyDown(EKEY_CODE keyCode) const
	{
		return KeyIsDown[keyCode];
	}

	MyEventReceiver()
	{
		for (u32 i=0; i<KEY_KEY_CODES_COUNT; ++i)
			KeyIsDown[i] = false;
	}

private:
	// We use this array to store the current state of each key
	bool KeyIsDown[KEY_KEY_CODES_COUNT];
};

/*
Much of this is code taken from some of the examples. We merely set
up a mesh from a heightmap, light it with a moving light, and allow
the user to navigate around it.
*/

int main(int argc, char* argv[])
{
	// ask user for driver
	video::E_DRIVER_TYPE driverType=driverChoiceConsole();
	if (driverType==video::EDT_COUNT)
		return 1;

	MyEventReceiver receiver;
	IrrlichtDevice* device = createDevice(driverType,
			core::dimension2du(800, 600), 32, false, false, false,
			&receiver);

	if(device == 0)
		return 1;

	IVideoDriver *driver = device->getVideoDriver();
	ISceneManager *smgr = device->getSceneManager();
	device->setWindowCaption(L"Irrlicht Example for SMesh usage.");

	/*
	Create the custom mesh and initialize with a heightmap
	*/
	TMesh mesh;
	HeightMap hm = HeightMap(255, 255);
	hm.generate(eggbox);
	mesh.init(hm, 50.f, grey, driver);

	// Add the mesh to the scene graph
	IMeshSceneNode* meshnode = smgr -> addMeshSceneNode(mesh.Mesh);
	meshnode->setMaterialFlag(video::EMF_BACK_FACE_CULLING, false);

	// light is just for nice effects
	ILightSceneNode *node = smgr->addLightSceneNode(0, vector3df(0,100,0),
		SColorf(1.0f, 0.6f, 0.7f, 1.0f), 500.0f);
	if (node)
	{
		node->getLightData().Attenuation.set(0.f, 1.f/500.f, 0.f);
		ISceneNodeAnimator* anim = smgr->createFlyCircleAnimator(vector3df(0,150,0),250.0f);
		if (anim)
		{
			node->addAnimator(anim);
			anim->drop();
		}
	}

	ICameraSceneNode* camera = smgr->addCameraSceneNodeFPS();
	if (camera)
	{
		camera->setPosition(vector3df(-20.f, 150.f, -20.f));
		camera->setTarget(vector3df(200.f, -80.f, 150.f));
		camera->setFarValue(20000.0f);
	}

	/*
	Just a usual render loop with event handling. The custom mesh is
	a usual part of the scene graph which gets rendered by drawAll.
	*/
	while(device->run())
	{
		if(!device->isWindowActive())
		{
			device->sleep(100);
			continue;
		}

		if(receiver.IsKeyDown(irr::KEY_KEY_W))
		{
			meshnode->setMaterialFlag(video::EMF_WIREFRAME, !meshnode->getMaterial(0).Wireframe);
		}
		else if(receiver.IsKeyDown(irr::KEY_KEY_1))
		{
			hm.generate(eggbox);
			mesh.init(hm, 50.f, grey, driver);
		}
		else if(receiver.IsKeyDown(irr::KEY_KEY_2))
		{
			hm.generate(moresine);
			mesh.init(hm, 50.f, yellow, driver);
		}
		else if(receiver.IsKeyDown(irr::KEY_KEY_3))
		{
			hm.generate(justexp);
			mesh.init(hm, 50.f, yellow, driver);
		}

		driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, SColor(0xff000000));
		smgr->drawAll();
		driver->endScene();
	}

	device->drop();

	return 0;
}

/*
That's it! Just compile and play around with the program.
**/
