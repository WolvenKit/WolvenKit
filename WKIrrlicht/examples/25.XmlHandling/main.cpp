/** Example 025 Xml Handling

Demonstrates loading and saving of configurations via XML

@author Y.M. Bosman	\<yoran.bosman@gmail.com\>

This demo features a fully usable system for configuration handling. The code
can easily be integrated into own apps.

*/

#include <irrlicht.h>
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


/* SettingManager class.

This class loads and writes the settings and manages the options.

The class makes use of irrMap which is a an associative arrays using a
red-black tree it allows easy mapping of a key to a value, along the way there
is some information on how to use it.
*/

class SettingManager
{
public:

	// Construct setting managers and set default settings
	SettingManager(const stringw& settings_file): SettingsFile(settings_file), NullDevice(0)
	{
		// Irrlicht null device, we want to load settings before we actually created our device, therefore, nulldevice
		NullDevice = irr::createDevice(irr::video::EDT_NULL);

		//DriverOptions is an irrlicht map,
		//we can insert values in the map in two ways by calling insert(key,value) or by using the [key] operator
		//the [] operator overrides values if they already exist
		DriverOptions.insert(L"Software", EDT_SOFTWARE);
		DriverOptions.insert(L"OpenGL", EDT_OPENGL);
		DriverOptions.insert(L"Direct3D9", EDT_DIRECT3D9);

		//some resolution options
		ResolutionOptions.insert(L"640x480", dimension2du(640,480));
		ResolutionOptions.insert(L"800x600", dimension2du(800,600));
		ResolutionOptions.insert(L"1024x768", dimension2du(1024,768));

		//our preferred defaults
		SettingMap.insert(L"driver", L"Direct3D9");
		SettingMap.insert(L"resolution", L"640x480");
		SettingMap.insert(L"fullscreen", L"0"); //0 is false
	}

	// Destructor, you could store settings automatically on exit of your
	// application if you wanted to in our case we simply drop the
	// nulldevice
	~SettingManager()
	{
		if (NullDevice)
		{
			NullDevice->closeDevice();
			NullDevice->drop();
		}
	};

	/*
	Load xml from disk, overwrite default settings
	The xml we are trying to load has the following structure
	settings nested in sections nested in the root node, like so
	<pre>
		<?xml version="1.0"?>
		<mygame>
			<video>
				<setting name="driver" value="Direct3D9" />
				<setting name="fullscreen" value="0" />
				<setting name="resolution" value="1024x768" />
			</video>
		</mygame>
	</pre>
	*/
	bool load()
	{
		//if not able to create device don't attempt to load
		if (!NullDevice)
			return false;

		irr::io::IXMLReader* xml = NullDevice->getFileSystem()->createXMLReader(SettingsFile);	//create xml reader
		if (!xml)
			return false;

		const stringw settingTag(L"setting"); //we'll be looking for this tag in the xml
		stringw currentSection; //keep track of our current section
		const stringw videoTag(L"video"); //constant for videotag

		//while there is more to read
		while (xml->read())
		{
			//check the node type
			switch (xml->getNodeType())
			{
				//we found a new element
				case irr::io::EXN_ELEMENT:
				{
					//we currently are in the empty or mygame section and find the video tag so we set our current section to video
					if (currentSection.empty() && videoTag.equals_ignore_case(xml->getNodeName()))
					{
						currentSection = videoTag;
					}
					//we are in the video section and we find a setting to parse
					else if (currentSection.equals_ignore_case(videoTag) && settingTag.equals_ignore_case(xml->getNodeName() ))
					{
						//read in the key
						stringw key = xml->getAttributeValueSafe(L"name");
						//if there actually is a key to set
						if (!key.empty())
						{
							//set the setting in the map to the value,
							//the [] operator overrides values if they already exist or inserts a new key value
							//pair into the settings map if it was not defined yet
							SettingMap[key] = xml->getAttributeValueSafe(L"value");
						}
					}

					//..
					// You can add your own sections and tags to read in here
					//..
				}
				break;

				//we found the end of an element
				case irr::io::EXN_ELEMENT_END:
					//we were at the end of the video section so we reset our tag
					currentSection=L"";
				break;
			}
		}

		// don't forget to delete the xml reader
		xml->drop();

		return true;
	}

	// Save the xml to disk. We use the nulldevice.
	bool save()
	{

		//if not able to create device don't attempt to save
		if (!NullDevice)
			return false;

		//create xml writer
		irr::io::IXMLWriter* xwriter = NullDevice->getFileSystem()->createXMLWriter( SettingsFile );
		if (!xwriter)
			return false;

		//write out the obligatory xml header. Each xml-file needs to have exactly one of those.
		xwriter->writeXMLHeader();

		//start element	mygame, you replace the label "mygame" with anything you want
		xwriter->writeElement(L"mygame");
		xwriter->writeLineBreak();					//new line

		//start section with video settings
		xwriter->writeElement(L"video");
		xwriter->writeLineBreak();					//new line

		// getIterator gets us a pointer to the first node of the settings map
		// every iteration we increase the iterator which gives us the next map node
		// until we reach the end we write settings one by one by using the nodes key and value functions
		map<stringw, stringw>::Iterator i = SettingMap.getIterator();
		for(; !i.atEnd(); i++)
		{
			//write element as <setting name="key" value="x" />
			//the second parameter indicates this is an empty element with no children, just attributes
			xwriter->writeElement(L"setting",true, L"name", i->getKey().c_str(), L"value",i->getValue().c_str() );
			xwriter->writeLineBreak();
		}
		xwriter->writeLineBreak();

		//close video section
		xwriter->writeClosingTag(L"video");
		xwriter->writeLineBreak();

		//..
		// You can add writing sound settings, savegame information etc
		//..

		//close mygame section
		xwriter->writeClosingTag(L"mygame");

		//delete xml writer
		xwriter->drop();

		return true;
	}

	// Set setting in our manager
	void setSetting(const stringw& name, const stringw& value)
	{
		SettingMap[name]=value;
	}

	// set setting overload to quickly assign integers to our setting map
	void setSetting(const stringw& name, s32 value)
	{
		SettingMap[name]=stringw(value);
	}

	// Get setting as string
	stringw getSetting(const stringw& key) const
	{
		//the find function or irrmap returns a pointer to a map Node
		//if the key can be found, otherwise it returns null
		//the map node has the function getValue and getKey, as we already know the key, we return node->getValue()
		map<stringw, stringw>::Node* n = SettingMap.find(key);
		if (n)
			return n->getValue();
		else
			return L"";
	}

	//
	bool getSettingAsBoolean(const stringw& key ) const
	{
		stringw s = getSetting(key);
		if (s.empty())
			return false;
		return s.equals_ignore_case(L"1");
	}

	//
	s32 getSettingAsInteger(const stringw& key) const
	{
		//we implicitly cast to string instead of stringw because strtol10 does not accept wide strings
		const stringc s = getSetting(key);
		if (s.empty())
			return 0;

		return strtol10(s.c_str());
	}

public:
	map<stringw, s32> DriverOptions; //available options for driver config
	map<stringw, dimension2du> ResolutionOptions; //available options for resolution config
private:
	SettingManager(const SettingManager& other); // defined but not implemented
	SettingManager& operator=(const SettingManager& other); // defined but not implemented

	map<stringw, stringw> SettingMap; //current config

	stringw SettingsFile; // location of the xml, usually the
	irr::IrrlichtDevice* NullDevice;
};

/*
Application context for global variables
*/
struct SAppContext
{
	SAppContext()
		: Device(0),Gui(0), Driver(0), Settings(0), ShouldQuit(false),
		ButtonSave(0), ButtonExit(0), ListboxDriver(0),
		ListboxResolution(0), CheckboxFullscreen(0)
	{
	}

	~SAppContext()
	{
		if (Settings)
			delete Settings;

		if (Device)
		{
			Device->closeDevice();
			Device->drop();
		}
	}

	IrrlichtDevice* Device;
	IGUIEnvironment* Gui;
	IVideoDriver* Driver;
	SettingManager* Settings;
	bool ShouldQuit;

	//settings dialog
	IGUIButton* ButtonSave;
	IGUIButton* ButtonExit;
	IGUIListBox* ListboxDriver;
	IGUIListBox* ListboxResolution;
	IGUICheckBox* CheckboxFullscreen;
};

/*
	A typical event receiver.
*/
class MyEventReceiver : public IEventReceiver
{
public:
	MyEventReceiver(SAppContext & a) : App(a) { }

	virtual bool OnEvent(const SEvent& event)
	{
		if (event.EventType == EET_GUI_EVENT )
		{
			switch ( event.GUIEvent.EventType )
			{
				//handle button click events
				case EGET_BUTTON_CLICKED:
				{
					//Our save button was called so we obtain the settings from our dialog and save them
					if ( event.GUIEvent.Caller == App.ButtonSave )
					{
						//if there is a selection write it
						if ( App.ListboxDriver->getSelected() != -1)
							App.Settings->setSetting(L"driver",	App.ListboxDriver->getListItem(App.ListboxDriver->getSelected()));

						//if there is a selection write it
						if ( App.ListboxResolution->getSelected() != -1)
							App.Settings->setSetting(L"resolution", App.ListboxResolution->getListItem(App.ListboxResolution->getSelected()));

						App.Settings->setSetting(L"fullscreen",	App.CheckboxFullscreen->isChecked());


						if (App.Settings->save())
						{
							App.Gui->addMessageBox(L"settings save",L"settings saved, please restart for settings to change effect","",true);
						}
					}
					// cancel/exit button clicked, tell the application to exit
					else if ( event.GUIEvent.Caller == App.ButtonExit)
					{
						App.ShouldQuit = true;
					}
				}
				break;
			}
		}

		return false;
	}

private:
	SAppContext & App;
};


/*
Function to create a video settings dialog
This dialog shows the current settings from the configuration xml and allows them to be changed
*/
void createSettingsDialog(SAppContext& app)
{
	// first get rid of alpha in gui
	for (irr::s32 i=0; i<irr::gui::EGDC_COUNT ; ++i)
	{
		irr::video::SColor col = app.Gui->getSkin()->getColor((irr::gui::EGUI_DEFAULT_COLOR)i);
		col.setAlpha(255);
		app.Gui->getSkin()->setColor((irr::gui::EGUI_DEFAULT_COLOR)i, col);
	}

	//create video settings windows
	gui::IGUIWindow* windowSettings = app.Gui->addWindow(rect<s32>(10,10,400,400),true,L"Videosettings");
	app.Gui->addStaticText (L"Select your desired video settings", rect< s32 >(10,20, 200, 40), false, true, windowSettings);

	// add listbox for driver choice
	app.Gui->addStaticText (L"Driver", rect< s32 >(10,50, 200, 60), false, true, windowSettings);
	app.ListboxDriver = app.Gui->addListBox(rect<s32>(10,60,220,120), windowSettings, 1,true);

	//add all available options to the driver choice listbox
	map<stringw, s32>::Iterator i = app.Settings->DriverOptions.getIterator();
	for(; !i.atEnd(); i++)
		app.ListboxDriver->addItem(i->getKey().c_str());

	//set currently selected driver
	app.ListboxDriver->setSelected(app.Settings->getSetting("driver").c_str());

	// add listbox for resolution choice
	app.Gui->addStaticText (L"Resolution", rect< s32 >(10,130, 200, 140), false, true, windowSettings);
	app.ListboxResolution = app.Gui->addListBox(rect<s32>(10,140,220,200), windowSettings, 1,true);

	//add all available options to the resolution listbox
	map<stringw, dimension2du>::Iterator ri = app.Settings->ResolutionOptions.getIterator();
	for(; !ri.atEnd(); ri++)
		app.ListboxResolution->addItem(ri->getKey().c_str());

	//set currently selected resolution
	app.ListboxResolution->setSelected(app.Settings->getSetting("resolution").c_str());

	//add checkbox to toggle fullscreen, initially set to loaded setting
	app.CheckboxFullscreen = app.Gui->addCheckBox(
			app.Settings->getSettingAsBoolean("fullscreen"),
			rect<s32>(10,220,220,240), windowSettings, -1,
			L"Fullscreen");

	//last but not least add save button
	app.ButtonSave = app.Gui->addButton(
			rect<s32>(80,250,150,270), windowSettings, 2,
			L"Save video settings");

	//exit/cancel button
	app.ButtonExit = app.Gui->addButton(
			rect<s32>(160,250,240,270), windowSettings, 2,
			L"Cancel and exit");
}

/*
The main function. Creates all objects and does the XML handling.
*/
int main()
{
	//create new application context
	SAppContext app;

	//create device creation parameters that can get overwritten by our settings file
	SIrrlichtCreationParameters param;
	param.DriverType = EDT_SOFTWARE;
	param.WindowSize.set(640,480);

	// Try to load config.
	// I leave it as an exercise of the reader to store the configuration in the local application data folder,
	// the only logical place to store config data for games. For all other operating systems I redirect to your manuals
	app.Settings = new SettingManager(getExampleMediaPath() + "settings.xml");
	if ( !app.Settings->load() )
	{
		// ...
		// Here add your own exception handling, for now we continue because there are defaults set in SettingManager constructor
		// ...
	}
	else
	{
		//settings xml loaded from disk,

		//map driversetting to driver type and test if the setting is valid
		//the DriverOptions map contains string representations mapped to to irrlicht E_DRIVER_TYPE enum
		//e.g "direct3d9" will become 4
		//see DriverOptions in the settingmanager class for details
		map<stringw, s32>::Node* driver = app.Settings->DriverOptions.find( app.Settings->getSetting("driver") );

		if (driver)
		{
			if ( irr::IrrlichtDevice::isDriverSupported( static_cast<E_DRIVER_TYPE>( driver->getValue() )))
			{
				// selected driver is supported, so we use it.
				param.DriverType = static_cast<E_DRIVER_TYPE>( driver->getValue());
			}
		}

		//map resolution setting to dimension in a similar way as demonstrated above
		map<stringw, dimension2du>::Node* res = app.Settings->ResolutionOptions.find( app.Settings->getSetting("resolution") );
		if (res)
		{
			param.WindowSize = res->getValue();
		}

		//get fullscreen setting from config
		param.Fullscreen = app.Settings->getSettingAsBoolean("fullscreen");
	}

	//create the irrlicht device using the settings
	app.Device = createDeviceEx(param);
	if (app.Device == 0)
	{
		// You can add your own exception handling on driver failure
		exit(0);
	}

	app.Device->setWindowCaption(L"Xmlhandling - Irrlicht engine tutorial");
	app.Driver	= app.Device->getVideoDriver();
	app.Gui		= app.Device->getGUIEnvironment();

	createSettingsDialog(app);

	//set event receiver so we can respond to gui events
	MyEventReceiver receiver(app);
	app.Device->setEventReceiver(&receiver);

	//enter main loop
	while (!app.ShouldQuit && app.Device->run())
	{
		if (app.Device->isWindowActive())
		{
			app.Driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, SColor(0,200,200,200));
			app.Gui->drawAll();
			app.Driver->endScene();
		}
		app.Device->sleep(10);
	}

	//app destroys device in destructor

	return 0;
}

/*
**/
