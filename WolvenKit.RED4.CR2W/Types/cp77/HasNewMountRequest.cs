using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HasNewMountRequest : AIVehicleConditionAbstract
	{
		[Ordinal(0)] [RED("mountRequest")] public CHandle<AIArgumentMapping> MountRequest { get; set; }
		[Ordinal(1)] [RED("checkOnlyInstant")] public CBool CheckOnlyInstant { get; set; }

		public HasNewMountRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
