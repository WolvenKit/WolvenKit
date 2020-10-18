/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */
#pragma once
#include "AABB.h"
#include "Point3i.h"
#include <vector>

class Portal;

using std::shared_ptr;
using std::vector;

class Cell
{
public:

	Cell(const Point3i minPoint, const Point3i maxPoint);
	~Cell(void);

	Point3i minPoint;
	Point3i maxPoint;

	const vector<shared_ptr<Portal>> getPortals() const { return m_portals; };
	void addPortal(const shared_ptr<Portal> val);

	vector<shared_ptr<Cell>> getVisibleCells() const { return m_visibleSetCells; };
	void addVisibleCell(const shared_ptr<Cell> val);

	friend bool Cell::operator == (const Cell& lhs, const Cell& rhs );
	friend bool Cell::operator != (const Cell& lhs, const Cell& rhs );

	void addModelId(int modelId);
	void getModelsIds(vector<int>& modelIds) const;

	bool isModelIdInCell(int modelId) const;

private:

	vector<int> m_modelIds; //The id's of the models inside the cell

	vector<shared_ptr<Portal>> m_portals; //The portals that connect to other Cells.
	vector<shared_ptr<Cell>> m_visibleSetCells; //The Cells that are potentially visible from the current Cell

};

