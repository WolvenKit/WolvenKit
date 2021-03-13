using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPreventionAgentData : CVariable
	{
		[Ordinal(0)] [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(1)] [RED("position")] public Vector4 Position { get; set; }

		public SPreventionAgentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
