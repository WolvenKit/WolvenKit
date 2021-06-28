using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldLocationAreaNode : worldTriggerAreaNode
	{
		private CString _locationName;

		[Ordinal(7)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get => GetProperty(ref _locationName);
			set => SetProperty(ref _locationName, value);
		}

		public worldLocationAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
