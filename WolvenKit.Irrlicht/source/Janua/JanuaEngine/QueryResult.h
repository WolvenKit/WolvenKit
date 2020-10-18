#pragma once

#include <vector>

using std::vector;

/**
* A QueryResult contains the visible model Ids.
*/
class QueryResult
{
public:

	/**
	* Creates a QueryResult containing the collection of given Model Ids.
	* @param getVisibleModelIds	The vector of model Ids.
	*/
	QueryResult(const vector<int> getVisibleModelIds);


	const vector<int> getVisibleModelIds() const;
	virtual ~QueryResult(void);

private:
	vector<int> m_VisibleModelIds;
};

