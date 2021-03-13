using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsMaterialTags : CVariable
	{
		[Ordinal(0)] [RED("aiVisibility")] public CEnum<physicsMaterialTagAIVisibility> AiVisibility { get; set; }
		[Ordinal(1)] [RED("projectilePenetration")] public CEnum<physicsMaterialTagProjectilePenetration> ProjectilePenetration { get; set; }
		[Ordinal(2)] [RED("vehicleTraction")] public CEnum<physicsMaterialTagVehicleTraction> VehicleTraction { get; set; }

		public physicsMaterialTags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
