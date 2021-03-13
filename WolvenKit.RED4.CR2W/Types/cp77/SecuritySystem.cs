using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystem : DeviceSystemBase
	{
		[Ordinal(93)] [RED("savedOutputCache")] public CArray<OutputValidationDataStruct> SavedOutputCache { get; set; }

		public SecuritySystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
