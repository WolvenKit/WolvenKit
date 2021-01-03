using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecuritySystem : DeviceSystemBase
	{
		[Ordinal(0)]  [RED("savedOutputCache")] public CArray<OutputValidationDataStruct> SavedOutputCache { get; set; }

		public SecuritySystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
