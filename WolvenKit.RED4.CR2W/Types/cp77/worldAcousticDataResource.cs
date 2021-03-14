using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAcousticDataResource : resStreamedResource
	{
		private CArray<worldAcousticDataCell> _cells;

		[Ordinal(1)] 
		[RED("cells")] 
		public CArray<worldAcousticDataCell> Cells
		{
			get
			{
				if (_cells == null)
				{
					_cells = (CArray<worldAcousticDataCell>) CR2WTypeManager.Create("array:worldAcousticDataCell", "cells", cr2w, this);
				}
				return _cells;
			}
			set
			{
				if (_cells == value)
				{
					return;
				}
				_cells = value;
				PropertySet(this);
			}
		}

		public worldAcousticDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
