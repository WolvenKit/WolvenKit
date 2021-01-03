using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AimAssistModule : HUDModule
	{
		[Ordinal(0)]  [RED("activeAssists")] public CArray<CHandle<AimAssist>> ActiveAssists { get; set; }

		public AimAssistModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
