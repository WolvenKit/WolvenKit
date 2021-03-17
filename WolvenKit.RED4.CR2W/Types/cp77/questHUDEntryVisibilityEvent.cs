using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questHUDEntryVisibilityEvent : CVariable
	{
		private CArray<questHUDEntryVisibilityData> _dataEntries;

		[Ordinal(0)] 
		[RED("dataEntries")] 
		public CArray<questHUDEntryVisibilityData> DataEntries
		{
			get => GetProperty(ref _dataEntries);
			set => SetProperty(ref _dataEntries, value);
		}

		public questHUDEntryVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
