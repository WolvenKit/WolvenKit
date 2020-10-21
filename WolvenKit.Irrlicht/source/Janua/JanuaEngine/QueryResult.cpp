#include "QueryResult.h"

namespace Janua
{
	QueryResult::QueryResult(const vector<int> getVisibleModelIds) : m_VisibleModelIds(getVisibleModelIds)
	{

	}

	const vector<int> QueryResult::getVisibleModelIds() const
	{
		return m_VisibleModelIds;
	}

	QueryResult::~QueryResult(void)
	{
	}
}