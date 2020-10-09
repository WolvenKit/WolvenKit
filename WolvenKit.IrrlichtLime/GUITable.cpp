#include "stdafx.h"
#include "GUIElement.h"
#include "GUITable.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUITable^ GUITable::Wrap(gui::IGUITable* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUITable(ref);
}

GUITable::GUITable(gui::IGUITable* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUITable = ref;
}

void GUITable::AddColumn(String^ caption, int columnIndex)
{
	LIME_ASSERT(columnIndex >= -1); // -1 is valid here
	m_GUITable->addColumn(LIME_SAFESTRINGTOSTRINGW_C_STR(caption), columnIndex);
}

void GUITable::AddColumn(String^ caption)
{
	m_GUITable->addColumn(LIME_SAFESTRINGTOSTRINGW_C_STR(caption));
}

int GUITable::AddRow(int rowIndex)
{
	LIME_ASSERT(rowIndex >= 0);
	return m_GUITable->addRow(rowIndex);
}

void GUITable::Clear()
{
	m_GUITable->clear();
}

void GUITable::ClearRows()
{
	m_GUITable->clearRows();
}

int GUITable::GetCellData(int rowIndex, int columnIndex)
{
	LIME_ASSERT(rowIndex >= 0 && rowIndex < RowCount);
	LIME_ASSERT(columnIndex >= 0 && columnIndex < ColumnCount);

	return (int) m_GUITable->getCellData(rowIndex, columnIndex);
}

String^ GUITable::GetCellText(int rowIndex, int columnIndex)
{
	LIME_ASSERT(rowIndex >= 0 && rowIndex < RowCount);
	LIME_ASSERT(columnIndex >= 0 && columnIndex < ColumnCount);

	return gcnew String(m_GUITable->getCellText(rowIndex, columnIndex));
}

int GUITable::GetColumnWidth(int columnIndex)
{
	LIME_ASSERT(columnIndex >= 0 && columnIndex < ColumnCount);
	return m_GUITable->getColumnWidth(columnIndex);
}

void GUITable::OrderRows(int columnIndex, GUIOrderingMode mode)
{
	LIME_ASSERT(columnIndex >= -1 && columnIndex < ColumnCount); // -1 is valid here
	m_GUITable->orderRows(columnIndex, (gui::EGUI_ORDERING_MODE)mode);
}

void GUITable::OrderRows(int columnIndex)
{
	LIME_ASSERT(columnIndex >= -1 && columnIndex < ColumnCount);
	m_GUITable->orderRows(columnIndex);
}

void GUITable::OrderRows()
{
	m_GUITable->orderRows();
}

void GUITable::RemoveColumn(int columnIndex)
{
	LIME_ASSERT(columnIndex >= 0 && columnIndex < ColumnCount);
	m_GUITable->removeColumn(columnIndex);
}

void GUITable::RemoveRow(int rowIndex)
{
	LIME_ASSERT(rowIndex >= 0 && rowIndex < RowCount);
	m_GUITable->removeRow(rowIndex);
}

void GUITable::SetCellColor(int rowIndex, int columnIndex, Video::Color^ color)
{
	LIME_ASSERT(rowIndex >= 0 && rowIndex < RowCount);
	LIME_ASSERT(columnIndex >= 0 && columnIndex < ColumnCount);
	LIME_ASSERT(color != nullptr);

	m_GUITable->setCellColor(
		rowIndex,
		columnIndex,
		*color->m_NativeValue);
}

void GUITable::SetCellData(int rowIndex, int columnIndex, int data)
{
	LIME_ASSERT(rowIndex >= 0 && rowIndex < RowCount);
	LIME_ASSERT(columnIndex >= 0 && columnIndex < ColumnCount);

	m_GUITable->setCellData(
		rowIndex,
		columnIndex,
		(void*) data);
}

void GUITable::SetCellText(int rowIndex, int columnIndex, String^ text)
{
	LIME_ASSERT(rowIndex >= 0 && rowIndex < RowCount);
	LIME_ASSERT(columnIndex >= 0 && columnIndex < ColumnCount);
	LIME_ASSERT(text != nullptr);

	m_GUITable->setCellText(
		rowIndex,
		columnIndex,
		Lime::StringToStringW(text));
}

void GUITable::SetColumnOrdering(int columnIndex, GUIColumnOrdering mode)
{
	LIME_ASSERT(columnIndex >= 0 && columnIndex < ColumnCount);

	m_GUITable->setColumnOrdering(
		columnIndex,
		(gui::EGUI_COLUMN_ORDERING)mode);
}

void GUITable::SetColumnWidth(int columnIndex, int width)
{
	LIME_ASSERT(columnIndex >= 0 && columnIndex < ColumnCount);
	LIME_ASSERT(width >= 0);

	m_GUITable->setColumnWidth(
		columnIndex,
		width);
}

void GUITable::SwapRows(int rowIndexA, int rowIndexB)
{
	LIME_ASSERT(rowIndexA >= 0 && rowIndexA < RowCount);
	LIME_ASSERT(rowIndexB >= 0 && rowIndexB < RowCount);
	LIME_ASSERT(rowIndexA != rowIndexB);

	m_GUITable->swapRows(
		rowIndexA,
		rowIndexB);
}

int GUITable::ActiveColumnIndex::get()
{
	return m_GUITable->getActiveColumn();
}

void GUITable::ActiveColumnIndex::set(int value)
{
	LIME_ASSERT(value >= 0 && value < ColumnCount);
	m_GUITable->setActiveColumn(value);
}

GUIOrderingMode GUITable::ActiveColumnOrdering::get()
{
	return (GUIOrderingMode)m_GUITable->getActiveColumnOrdering();
}

int GUITable::ColumnCount::get()
{
	return m_GUITable->getColumnCount();
}

GUITableDrawFlag GUITable::DrawFlags::get()
{
	return (GUITableDrawFlag)m_GUITable->getDrawFlags();
}

void GUITable::DrawFlags::set(GUITableDrawFlag value)
{
	m_GUITable->setDrawFlags((gui::EGUI_TABLE_DRAW_FLAGS)value);
}

bool GUITable::ResizableColumns::get()
{
	return m_GUITable->hasResizableColumns();
}

void GUITable::ResizableColumns::set(bool value)
{
	m_GUITable->setResizableColumns(value);
}

int GUITable::RowCount::get()
{
	return m_GUITable->getRowCount();
}

int GUITable::SelectedRowIndex::get()
{
	return m_GUITable->getSelected();
}

void GUITable::SelectedRowIndex::set(int value)
{
	LIME_ASSERT(value >= 0 && value < RowCount);
	m_GUITable->setSelected(value);
}

} // end namespace GUI
} // end namespace IrrlichtLime