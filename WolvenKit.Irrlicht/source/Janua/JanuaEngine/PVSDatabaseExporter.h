#pragma once
#include "PVSDatabase.h"

/**
* Exports a PVSDatabase to a buffer.
*/
class PVSDatabaseExporter
{
public:

	/**
	* Creates a PVSDatabaseExporter from PVSDatabase
	*/
	PVSDatabaseExporter(const PVSDatabase& pvsDatabase);

	/**
	* Saves the PVS Database into the given buffer.
	* The buffer must have enough allocated memory to store it.
	* @param	buffer	The buffer to store the database.
	*/
	void saveToBuffer( char* buffer);

	/**
	* Returns the size in bytes that a buffer would need to store the PVS Database.
	* @return The size in bytes.
	*/
	int getBufferSize() const;

	virtual ~PVSDatabaseExporter(void);

private:

	void save( char* buffer, int& allocatedSize, bool saveToBufferEnabled) const;

	const PVSDatabase& m_pvsDatabase;
};

