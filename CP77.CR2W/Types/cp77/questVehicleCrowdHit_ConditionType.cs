using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questVehicleCrowdHit_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)]  [RED("lethal")] public CBool Lethal { get; set; }

		public questVehicleCrowdHit_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
