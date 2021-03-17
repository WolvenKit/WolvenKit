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
			get => GetProperty(ref _selected);
			set => SetProperty(ref _selected, value);
		}

		[Ordinal(1)] 
		[RED("deselected")] 
		public CArray<CUInt64> Deselected
		{
			get => GetProperty(ref _deselected);
			set => SetProperty(ref _deselected, value);
		}

		public interopSelectionChangeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
