#include "StdAfx.h"
#include "Cell.h"
#include <alg.h>

#include <algorithm>
using std::find;

namespace Janua
{
	Cell::Cell(const Point3i p_minPoint, const Point3i p_maxPoint) : minPoint(p_minPoint), maxPoint(p_maxPoint)
	{

	}

	Cell::~Cell(void)
	{
	}

	bool operator!=(const Cell& lhs, const Cell& rhs)
	{
		return lhs.minPoint != rhs.minPoint || lhs.maxPoint != rhs.maxPoint;
	}

	bool operator==(const Cell& lhs, const Cell& rhs)
	{
		return lhs.minPoint == rhs.minPoint && lhs.maxPoint == rhs.maxPoint;
	}

	void Cell::addPortal(const shared_ptr<Portal> val)
	{
		m_portals.push_back(val);
	}

	void Cell::addVisibleCell(const shared_ptr<Cell> val)
	{
		m_visibleSetCells.push_back(val);
	}

	void Cell::getModelsIds(vector<int>& modelIds) const
	{
		modelIds.insert(modelIds.end(), m_modelIds.begin(), m_modelIds.end());
	}

	void Cell::addModelId(int modelId)
	{
		m_modelIds.push_back(modelId);
	}

	bool Cell::isModelIdInCell(int modelId) const
	{

		if (std::find(m_modelIds.begin(), m_modelIds.end(), modelId) == m_modelIds.end())
			return false;
		else
			return true;
	}
}