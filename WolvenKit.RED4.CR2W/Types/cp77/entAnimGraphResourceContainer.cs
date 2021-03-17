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
			get => GetProperty(ref _animGraphLookupTable);
			set => SetProperty(ref _animGraphLookupTable, value);
		}

		public entAnimGraphResourceContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
