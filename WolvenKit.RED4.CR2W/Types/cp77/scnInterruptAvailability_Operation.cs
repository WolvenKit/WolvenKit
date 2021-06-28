using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInterruptAvailability_Operation : scnIInterruptManager_Operation
	{
		private CBool _available;

		[Ordinal(0)] 
		[RED("available")] 
		public CBool Available
		{
			get => GetProperty(ref _available);
			set => SetProperty(ref _available, value);
		}

		public scnInterruptAvailability_Operation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
