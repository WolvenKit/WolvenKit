using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SwapPresetEvent : redEvent
	{
		private CString _mappingName;

		[Ordinal(0)] 
		[RED("mappingName")] 
		public CString MappingName
		{
			get => GetProperty(ref _mappingName);
			set => SetProperty(ref _mappingName, value);
		}

		public SwapPresetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
