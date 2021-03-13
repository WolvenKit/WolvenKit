using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MountAssigendVehicle : AIVehicleTaskAbstract
	{
		[Ordinal(0)] [RED("result")] public CEnum<AIbehaviorUpdateOutcome> Result { get; set; }

		public MountAssigendVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
