#pragma once
#include "PVSDatabase.h"

/**
* Imports the PVS from a buffer.
*/
class PVSDatabaseImporter
{
public:
	PVSDatabaseImporter(void);

	/**
	* Loads a PVS Database from a buffer.
	* @return A pointer to the PVSDatabase loaded.
	*/
	shared_ptr<PVSDatabase> load(char* buffer);

	virtual ~PVSDatabaseImporter(void);
};

