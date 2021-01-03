using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MountAssigendVehicle : AIVehicleTaskAbstract
	{
		[Ordinal(0)]  [RED("result")] public CEnum<AIbehaviorUpdateOutcome> Result { get; set; }

		public MountAssigendVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
