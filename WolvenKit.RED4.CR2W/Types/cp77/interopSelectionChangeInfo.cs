using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopSelectionChangeInfo : CVariable
	{
		private CArray<CUInt64> _selected;
		private CArray<CUInt64> _deselected;

		[Ordinal(0)] 
		[RED("selected")] 
		public CArray<CUInt64> Selected
		{
			get
			{
				if (_selected == null)
				{
					_selected = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "selected", cr2w, this);
				}
				return _selected;
			}
			set
			{
				if (_selected == value)
				{
					return;
				}
				_selected = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("deselected")] 
		public CArray<CUInt64> Deselected
		{
			get
			{
				if (_deselected == null)
				{
					_deselected = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "deselected", cr2w, this);
				}
				return _deselected;
			}
			set
			{
				if (_deselected == value)
				{
					return;
				}
				_deselected = value;
				PropertySet(this);
			}
		}

		public interopSelectionChangeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
