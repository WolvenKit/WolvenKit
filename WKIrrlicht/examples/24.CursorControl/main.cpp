/** Example 024 CursorControl

Show how to modify cursors and offer some useful tool-functions for creating cursors.
It can also be used for experiments with the mouse in general.
*/

#include <irrlicht.h>
#include "driverChoice.h"
#include "exampleHelper.h"

using namespace irr;
using namespace core;
using namespace scene;
using namespace video;
using namespace io;
using namespace gui;

#ifdef _MSC_VER
#pragma comment(lib, "Irrlicht.lib")
#endif

const int DELAY_TIME = 3000;

enum ETimerAction
{
	ETA_MOUSE_VISIBLE,
	ETA_MOUSE_INVISIBLE,
};

/*
	Structure to allow delayed execution of some actions.
*/
struct TimerAction
{
	u32 TargetTime;
	ETimerAction Action;
};

/*
*/
struct SAppContext
{
	SAppContext()
	: Device(0), InfoStatic(0), EventBox(0), CursorBox(0), SpriteBox(0)
	, ButtonSetVisible(0), ButtonSetInvisible(0), ButtonSimulateBadFps(0)
	, ButtonChangeIcon(0)
	, SimulateBadFps(false)
	{
	}

	void update()
	{
		if (!Device)
			return;
		u32 timeNow = Device->getTimer()->getTime();
		for ( u32 i=0; i < TimerActions.size(); ++i )
		{
			if ( timeNow >= TimerActions[i].TargetTime )
			{
				runTimerAction(TimerActions[i]);
				TimerActions.erase(i);
			}
			else
			{
				++i;
			}
		}
	}

	void runTimerAction(const TimerAction& action)
	{
		if (ETA_MOUSE_VISIBLE == action.Action)
		{
			Device->getCursorControl()->setVisible(true);
			ButtonSetVisible->setEnabled(true);
		}
		else if ( ETA_MOUSE_INVISIBLE == action.Action)
		{
			Device->getCursorControl()->setVisible(false);
			ButtonSetInvisible->setEnabled(true);
		}
	}

	/*
		Add another icon which the user can click and select as cursor later on.
	*/
	void addIcon(const stringw& name, const SCursorSprite &sprite, bool addCursor=true)
	{
		// Sprites are just icons - not yet cursors. They can be displayed by Irrlicht sprite functions and be used to create cursors.
		SpriteBox->addItem(name.c_str(), sprite.SpriteId);
		Sprites.push_back(sprite);

		// create the cursor together with the icon?
		if ( addCursor )
		{
			/* Here we create a hardware cursor from a sprite */
			Device->getCursorControl()->addIcon(sprite);

			// ... and add it to the cursors selection listbox to the other system cursors.
			CursorBox->addItem(name.c_str());
		}
	}

	IrrlichtDevice * Device;
	gui::IGUIStaticText * InfoStatic;
	gui::IGUIListBox * EventBox;
	gui::IGUIListBox * CursorBox;
	gui::IGUIListBox * SpriteBox;
	gui::IGUIButton * ButtonSetVisible;
	gui::IGUIButton * ButtonSetInvisible;
	gui::IGUIButton * ButtonSimulateBadFps;
	gui::IGUIButton * ButtonChangeIcon;
	array<TimerAction> TimerActions;
	bool SimulateBadFps;
	array<SCursorSprite> Sprites;
};

/*
	Helper function to print mouse event names into a stringw
*/
void PrintMouseEventName(const SEvent& event, stringw &result)
{
	switch ( event.MouseInput.Event )
	{
		case EMIE_LMOUSE_PRESSED_DOWN: 	result += stringw(L"EMIE_LMOUSE_PRESSED_DOWN"); break;
		case EMIE_RMOUSE_PRESSED_DOWN: 	result += stringw(L"EMIE_RMOUSE_PRESSED_DOWN"); break;
		case EMIE_MMOUSE_PRESSED_DOWN: 	result += stringw(L"EMIE_MMOUSE_PRESSED_DOWN"); break;
		case EMIE_LMOUSE_LEFT_UP: 		result += stringw(L"EMIE_LMOUSE_LEFT_UP"); break;
		case EMIE_RMOUSE_LEFT_UP: 		result += stringw(L"EMIE_RMOUSE_LEFT_UP"); break;
		case EMIE_MMOUSE_LEFT_UP: 		result += stringw(L"EMIE_MMOUSE_LEFT_UP"); break;
		case EMIE_MOUSE_MOVED: 			result += stringw(L"EMIE_MOUSE_MOVED"); break;
		case EMIE_MOUSE_WHEEL: 			result += stringw(L"EMIE_MOUSE_WHEEL"); break;
		case EMIE_LMOUSE_DOUBLE_CLICK: 	result += stringw(L"EMIE_LMOUSE_DOUBLE_CLICK"); break;
		case EMIE_RMOUSE_DOUBLE_CLICK: 	result += stringw(L"EMIE_RMOUSE_DOUBLE_CLICK"); break;
		case EMIE_MMOUSE_DOUBLE_CLICK: 	result += stringw(L"EMIE_MMOUSE_DOUBLE_CLICK"); break;
		case EMIE_LMOUSE_TRIPLE_CLICK: 	result += stringw(L"EMIE_LMOUSE_TRIPLE_CLICK"); break;
		case EMIE_RMOUSE_TRIPLE_CLICK: 	result += stringw(L"EMIE_RMOUSE_TRIPLE_CLICK"); break;
		case EMIE_MMOUSE_TRIPLE_CLICK: 	result += stringw(L"EMIE_MMOUSE_TRIPLE_CLICK"); break;
		default:
		break;
	}
}

/*
	Helper function to print all the state information which get from a mouse-event into a stringw
*/
void PrintMouseState(const SEvent& event, stringw &result)
{
	result += stringw(L"X: ");
	result += stringw(event.MouseInput.X);
	result += stringw(L"\n");

	result += stringw(L"Y: ");
	result += stringw(event.MouseInput.Y);
	result += stringw(L"\n");


	result += stringw(L"Wheel: ");
	result += stringw(event.MouseInput.Wheel);
	result += stringw(L"\n");

	result += stringw(L"Shift: ");
	if ( event.MouseInput.Shift )
		result += stringw(L"true\n");
	else
		result += stringw(L"false\n");

	result += stringw(L"Control: ");
	if ( event.MouseInput.Control )
		result += stringw(L"true\n");
	else
		result += stringw(L"false\n");

	result += stringw(L"ButtonStates: ");
	result += stringw(event.MouseInput.ButtonStates);
	result += stringw(L"\n");

	result += stringw(L"isLeftPressed: ");
	if ( event.MouseInput.isLeftPressed() )
		result += stringw(L"true\n");
	else
		result += stringw(L"false\n");

	result += stringw(L"isRightPressed: ");
	if ( event.MouseInput.isRightPressed() )
		result += stringw(L"true\n");
	else
		result += stringw(L"false\n");

	result += stringw(L"isMiddlePressed: ");
	if ( event.MouseInput.isMiddlePressed() )
		result += stringw(L"true\n");
	else
		result += stringw(L"false\n");

	result += stringw(L"Event: ");

	PrintMouseEventName(event, result);

	result += stringw(L"\n");
}

/*
	A typical event receiver.
*/
class MyEventReceiver : public IEventReceiver
{
public:
	MyEventReceiver(SAppContext & context) : Context(context) { }

	virtual bool OnEvent(const SEvent& event)
	{
		if (event.EventType == EET_GUI_EVENT )
		{
			switch ( event.GUIEvent.EventType )
			{
				case EGET_BUTTON_CLICKED:
				{
					u32 timeNow = Context.Device->getTimer()->getTime();
					TimerAction action;
					action.TargetTime = timeNow + DELAY_TIME;
					if ( event.GUIEvent.Caller == Context.ButtonSetVisible )
					{
						action.Action = ETA_MOUSE_VISIBLE;
						Context.TimerActions.push_back(action);
						Context.ButtonSetVisible->setEnabled(false);
					}
					else if ( event.GUIEvent.Caller == Context.ButtonSetInvisible )
					{
						action.Action = ETA_MOUSE_INVISIBLE;
						Context.TimerActions.push_back(action);
						Context.ButtonSetInvisible->setEnabled(false);
					}
					else if ( event.GUIEvent.Caller == Context.ButtonSimulateBadFps )
					{
						Context.SimulateBadFps = Context.ButtonSimulateBadFps->isPressed();
					}
					else if ( event.GUIEvent.Caller == Context.ButtonChangeIcon )
					{
						/*
							Replace an existing cursor icon by another icon.
							The user has to select both - the icon which should be replaced and the icon which will replace it.
						*/
						s32 selectedCursor = Context.CursorBox->getSelected();
						s32 selectedSprite = Context.SpriteBox->getSelected();
						if ( selectedCursor >= 0 && selectedSprite >= 0 )
						{
							/*
								This does replace the icon.
							*/
							Context.Device->getCursorControl()->changeIcon((ECURSOR_ICON)selectedCursor, Context.Sprites[selectedSprite] );

							/*
								Do also show the new icon.
							*/
							Context.Device->getCursorControl()->setActiveIcon( ECURSOR_ICON(selectedCursor) );
						}
					}
				}
				break;
				case EGET_LISTBOX_CHANGED:
				case EGET_LISTBOX_SELECTED_AGAIN:
				{
					if ( event.GUIEvent.Caller == Context.CursorBox )
					{
						/*
							Find out which cursor the user selected
						*/
						s32 selected = Context.CursorBox->getSelected();
						if ( selected >= 0 )
						{
							/*
								Here we set the new cursor icon which will now be used within our window.
							*/
							Context.Device->getCursorControl()->setActiveIcon( ECURSOR_ICON(selected) );
						}
					}
				}
				break;
				default:
				break;
			}
		}

		if (event.EventType == EET_MOUSE_INPUT_EVENT)
		{
			stringw infoText;
			PrintMouseState(event, infoText);
			Context.InfoStatic->setText(infoText.c_str());
			if ( event.MouseInput.Event != EMIE_MOUSE_MOVED && event.MouseInput.Event != EMIE_MOUSE_WHEEL ) // no spam
			{
				infoText = L"";
				PrintMouseEventName(event, infoText);
				Context.EventBox->insertItem(0, infoText.c_str(), -1);
			}
		}

		return false;
	}

private:
	SAppContext & Context;
};

/*
	Use several imagefiles as animation frames for a sprite which can be used as cursor icon.
	The images in those files all need to have the same size.
	Return sprite index on success or -1 on failure
*/
s32 AddAnimatedIconToSpriteBank( gui::IGUISpriteBank * spriteBank, video::IVideoDriver* driver,  const array< io::path >& files, u32 frameTime )
{
	if ( !spriteBank || !driver || !files.size() )
		return -1;

	video::ITexture * tex = driver->getTexture( files[0] );
	if ( tex )
	{
		array< rect<s32> >& spritePositions = spriteBank->getPositions();
		u32 idxRect = spritePositions.size();
		spritePositions.push_back( rect<s32>(0,0, tex->getSize().Width, tex->getSize().Height) );

		SGUISprite sprite;
		sprite.frameTime = frameTime;

		array< SGUISprite >& sprites = spriteBank->getSprites();
		u32 startIdx = spriteBank->getTextureCount();
		for ( u32 f=0; f < files.size(); ++f )
		{
			tex = driver->getTexture( files[f] );
			if ( tex )
			{
				spriteBank->addTexture( driver->getTexture(files[f]) );
				gui::SGUISpriteFrame frame;
				frame.rectNumber = idxRect;
				frame.textureNumber = startIdx+f;
				sprite.Frames.push_back( frame );
			}
		}

		sprites.push_back( sprite );
		return sprites.size()-1;
	}

	return -1;
}

/*
	Use several images within one imagefile as animation frames for a sprite which can be used as cursor icon
	The sizes of the icons within that file all need to have the same size
	Return sprite index on success or -1 on failure
*/
s32 AddAnimatedIconToSpriteBank( gui::IGUISpriteBank * spriteBank, video::IVideoDriver* driver,  const io::path& file, const array< rect<s32> >& rects, u32 frameTime )
{
	if ( !spriteBank || !driver || !rects.size() )
		return -1;

	video::ITexture * tex = driver->getTexture( file );
	if ( tex )
	{
		array< rect<s32> >& spritePositions = spriteBank->getPositions();
		u32 idxRect = spritePositions.size();
		u32 idxTex = spriteBank->getTextureCount();
		spriteBank->addTexture( tex );

		SGUISprite sprite;
		sprite.frameTime = frameTime;

		array< SGUISprite >& sprites = spriteBank->getSprites();
		for ( u32 i=0; i < rects.size(); ++i )
		{
			spritePositions.push_back( rects[i] );

			gui::SGUISpriteFrame frame;
			frame.rectNumber = idxRect+i;
			frame.textureNumber = idxTex;
			sprite.Frames.push_back( frame );
		}

		sprites.push_back( sprite );
		return sprites.size()-1;
	}

	return -1;
}

/*
	Create a non-animated icon from the given file and position and put it into the spritebank.
	We can use this icon later on in a cursor.
*/
s32 AddIconToSpriteBank( gui::IGUISpriteBank * spriteBank, video::IVideoDriver* driver,  const io::path& file, const core::rect<s32>& rect )
{
	if ( !spriteBank || !driver )
		return -1;

	video::ITexture * tex = driver->getTexture( file );
	if ( tex )
	{
		core::array< core::rect<irr::s32> >& spritePositions = spriteBank->getPositions();
		spritePositions.push_back( rect );
		array< SGUISprite >& sprites = spriteBank->getSprites();
		spriteBank->addTexture( tex );

		gui::SGUISpriteFrame frame;
		frame.rectNumber = spritePositions.size()-1;
		frame.textureNumber = spriteBank->getTextureCount()-1;

		SGUISprite sprite;
		sprite.frameTime = 0;
		sprite.Frames.push_back( frame );

		sprites.push_back( sprite );

		return sprites.size()-1;
	}

	return -1;
}

int main()
{
	video::E_DRIVER_TYPE driverType = driverChoiceConsole();
	if (driverType==video::EDT_COUNT)
		return 1;

	IrrlichtDevice * device = createDevice(driverType, dimension2d<u32>(640, 480));
	if (device == 0)
		return 1; // could not create selected driver.

	// It's sometimes of interest to know how the mouse behaves after a resize
	device->setResizable(true);

	device->setWindowCaption(L"Cursor control - Irrlicht engine tutorial");
	video::IVideoDriver* driver = device->getVideoDriver();
	IGUIEnvironment* env = device->getGUIEnvironment();

	gui::IGUISpriteBank * SpriteBankIcons;

	SAppContext context;
	context.Device = device;

	rect< s32 > rectInfoStatic(10,10, 200, 200);
	env->addStaticText (L"Cursor state information", rectInfoStatic, true, true);
	rectInfoStatic.UpperLeftCorner += dimension2di(0, 15);
	context.InfoStatic = env->addStaticText (L"", rectInfoStatic, true, true);
	rect< s32 > rectEventBox(10,210, 200, 400);
	env->addStaticText (L"click events (new on top)", rectEventBox, true, true);
	rectEventBox.UpperLeftCorner += dimension2di(0, 15);
	context.EventBox = env->addListBox(rectEventBox);
	rect< s32 > rectCursorBox(210,10, 400, 250);
	env->addStaticText (L"cursors, click to set the active one", rectCursorBox, true, true);
	rectCursorBox.UpperLeftCorner += dimension2di(0, 15);
	context.CursorBox = env->addListBox(rectCursorBox);
	rect< s32 > rectSpriteBox(210,260, 400, 400);
	env->addStaticText (L"sprites", rectSpriteBox, true, true);
	rectSpriteBox.UpperLeftCorner += dimension2di(0, 15);
	context.SpriteBox = env->addListBox(rectSpriteBox);

	context.ButtonSetVisible = env->addButton( rect<s32>( 410, 20, 560, 40 ), 0, -1, L"set visible (delayed)" );
	context.ButtonSetInvisible = env->addButton( rect<s32>( 410, 50, 560, 70 ), 0, -1, L"set invisible (delayed)" );
	context.ButtonSimulateBadFps = env->addButton( rect<s32>( 410, 80, 560, 100 ), 0, -1, L"simulate bad FPS" );
	context.ButtonSimulateBadFps->setIsPushButton(true);
	context.ButtonChangeIcon = env->addButton( rect<s32>( 410, 140, 560, 160 ), 0, -1, L"replace cursor icon\n(cursor+sprite must be selected)" );

	// set the names for all the system cursors
	for ( int i=0; i < (int)gui::ECI_COUNT; ++i )
	{
		context.CursorBox->addItem(stringw( GUICursorIconNames[i] ).c_str());
	}

	/*
		Create sprites which then can be used as cursor icons.
	 */
	SpriteBankIcons = env->addEmptySpriteBank(io::path("cursor_icons"));
	context.SpriteBox->setSpriteBank(SpriteBankIcons);

	const io::path mediaPath = getExampleMediaPath();

	// create one animated icon from several files
	array< io::path > files;
	files.push_back( io::path(mediaPath + "icon_crosshairs16x16bw1.png") );
	files.push_back( io::path(mediaPath + "icon_crosshairs16x16bw2.png") );
	files.push_back( io::path(mediaPath + "icon_crosshairs16x16bw3.png") );
	files.push_back( io::path(mediaPath + "icon_crosshairs16x16bw3.png") );
	files.push_back( io::path(mediaPath + "icon_crosshairs16x16bw2.png") );
	SCursorSprite spriteBw;	// the sprite + some additional information needed for cursors
	spriteBw.SpriteId = AddAnimatedIconToSpriteBank( SpriteBankIcons, driver, files, 200 );
	spriteBw.SpriteBank = SpriteBankIcons;
	spriteBw.HotSpot = position2d<s32>(7,7);
	context.addIcon(L"crosshair_bw", spriteBw);

	// create one animated icon from one file
	array< rect<s32> > iconRects;
	iconRects.push_back( rect<s32>(0,0, 16, 16) );
	iconRects.push_back( rect<s32>(16,0, 32, 16) );
	iconRects.push_back( rect<s32>(0,16, 16, 32) );
	iconRects.push_back( rect<s32>(0,16, 16, 32) );
	iconRects.push_back( rect<s32>(16,0, 32, 16) );
	SCursorSprite spriteCol;	// the sprite + some additional information needed for cursors
	spriteCol.SpriteId = AddAnimatedIconToSpriteBank( SpriteBankIcons, driver, io::path(mediaPath + "icon_crosshairs16x16col.png"), iconRects, 200 );
	spriteCol.HotSpot = position2d<s32>(7,7);
	spriteCol.SpriteBank = SpriteBankIcons;
	context.addIcon(L"crosshair_colored", spriteCol);

	// Create some non-animated icons
	rect<s32> rectIcon;
	SCursorSprite spriteNonAnimated(SpriteBankIcons, 0, position2d<s32>(7,7));

	rectIcon = rect<s32>(0,0, 16, 16);
	spriteNonAnimated.SpriteId = AddIconToSpriteBank( SpriteBankIcons, driver, io::path(mediaPath + "icon_crosshairs16x16col.png"), rectIcon );
	context.addIcon(L"crosshair_col1", spriteNonAnimated, false);

	rectIcon = rect<s32>(16,0, 32, 16);
	spriteNonAnimated.SpriteId = AddIconToSpriteBank( SpriteBankIcons, driver, io::path(mediaPath + "icon_crosshairs16x16col.png"), rectIcon );
	context.addIcon(L"crosshair_col2", spriteNonAnimated, false);

	rectIcon = rect<s32>(0,16, 16, 32);
	spriteNonAnimated.SpriteId = AddIconToSpriteBank( SpriteBankIcons, driver, io::path(mediaPath + "icon_crosshairs16x16col.png"), rectIcon );
	context.addIcon(L"crosshair_col3", spriteNonAnimated, false);


	MyEventReceiver receiver(context);
	device->setEventReceiver(&receiver);

	while(device->run() && driver)
	{
		// if (device->isWindowActive())
		{
			u32 realTimeNow = device->getTimer()->getRealTime();

			context.update();

			driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, SColor(0,200,200,200));

			env->drawAll();

			// draw custom sprite with Irrlicht functions for comparison. It should usually look the same as the cursors.
			if ( context.SpriteBox )
			{
				s32 selectedSprite = context.SpriteBox->getSelected();
				if ( selectedSprite >= 0 && context.Sprites[selectedSprite].SpriteId >= 0 )
				{
					SpriteBankIcons->draw2DSprite(u32(context.Sprites[selectedSprite].SpriteId), position2di(580, 140), 0, video::SColor(255, 255, 255, 255), 0, realTimeNow);
				}
			}

			driver->endScene();
		}

		// By simulating bad fps we can find out if hardware-support for cursors works or not. If it works the cursor will move as usual,while it otherwise will just update with 2 fps now.
		if ( context.SimulateBadFps )
		{
			device->sleep(500);	// 2 fps
		}
		else
		{
			device->sleep(10);
		}
	}

	device->drop();

	return 0;
}

/*
**/
