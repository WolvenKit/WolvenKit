using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GravityChangeTrigger : gameObject
	{
		[Ordinal(0)]  [RED("gravityType")] public CEnum<EGravityType> GravityType { get; set; }
		[Ordinal(1)]  [RED("lowGravityStateMachineName")] public CName LowGravityStateMachineName { get; set; }
		[Ordinal(2)]  [RED("regularStateMachineName")] public CName RegularStateMachineName { get; set; }

		public GravityChangeTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
