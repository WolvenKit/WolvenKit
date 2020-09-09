/*!
	Sound Factory.
	provides a sound interface

*/

#include "sound.h"


//#define USE_IRRKLANG

#ifdef USE_IRRKLANG

#include <irrKlang.h>
#ifdef _MSC_VER
	#pragma comment (lib, "irrKlang.lib")
#endif

using namespace irrklang;

struct soundfile: public IFileReader
{
	soundfile ( io::IReadFile* f ): file (f ) {}
	virtual ~soundfile () { file->drop (); }

	virtual ik_s32 read(void* buffer, ik_u32 sizeToRead) { return file->read ( buffer, sizeToRead ); }
	virtual bool seek(ik_s32 finalPos, bool relativeMovement = false) { return file->seek ( finalPos, relativeMovement ); }
	virtual ik_s32 getSize(){ return file->getSize (); }
	virtual ik_s32 getPos()	{return file->getPos (); }
	virtual const ik_c8* getFileName() { return file->getFileName().c_str(); }
	io::IReadFile* file;
};

struct klangFactory : public irrklang::IFileFactory
{
	klangFactory ( IrrlichtDevice *device )	{ Device = device; }

	virtual irrklang::IFileReader* createFileReader(const ik_c8* filename)
	{
		io::IReadFile* file = Device->getFileSystem()->createAndOpenFile(filename);
		if ( 0 == file )
			return 0;

		return new soundfile ( file );
	}

	IrrlichtDevice *Device;
};

ISoundEngine *engine = 0;
ISound *backMusic = 0;

void sound_init ( IrrlichtDevice *device )
{
	engine = createIrrKlangDevice ();
	if ( 0 == engine )
		return;

	klangFactory *f = new klangFactory ( device );
	engine->addFileFactory ( f );
}

void sound_shutdown ()
{
	if ( backMusic )
		backMusic->drop ();

	if ( engine )
		engine->drop ();
}

void background_music ( const c8 * file )
{
	if ( 0 == engine )
		return;

	if ( backMusic )
	{
		backMusic->stop ();
		backMusic->drop ();
	}

	backMusic = engine->play2D ( file, true, false, true );

	if ( backMusic )
	{
		backMusic->setVolume ( 0.5f );
	}
}

#else

void sound_init ( IrrlichtDevice *device ) {}
void sound_shutdown () {}
void background_music ( const c8 * file ) {}

#endif

