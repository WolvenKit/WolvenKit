using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AimAssistModule : HUDModule
	{
		[Ordinal(3)] [RED("activeAssists")] public CArray<CHandle<AimAssist>> ActiveAssists { get; set; }

		public AimAssistModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
