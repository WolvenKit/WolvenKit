using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimGraphResourceContainer : entIComponent
	{
		private CArray<entAnimGraphResourceContainerEntry> _animGraphLookupTable;

		[Ordinal(3)] 
		[RED("animGraphLookupTable")] 
		public CArray<entAnimGraphResourceContainerEntry> AnimGraphLookupTable
		{
			get
			{
				if (_animGraphLookupTable == null)
				{
					_animGraphLookupTable = (CArray<entAnimGraphResourceContainerEntry>) CR2WTypeManager.Create("array:entAnimGraphResourceContainerEntry", "animGraphLookupTable", cr2w, this);
				}
				return _animGraphLookupTable;
			}
			set
			{
				if (_animGraphLookupTable == value)
				{
					return;
				}
				_animGraphLookupTable = value;
				PropertySet(this);
			}
		}

		public entAnimGraphResourceContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
