/*!
	Sound Factory.
	provides a sound interface

*/
#ifndef __QUAKE3_SOUND__H_INCLUDED__
#define __QUAKE3_SOUND__H_INCLUDED__

#include <irrlicht.h>

using namespace irr;

void sound_init ( IrrlichtDevice *device );
void sound_shutdown ();
void background_music ( const c8 * file );


#endif // __QUAKE3_SOUND__H_INCLUDED__
