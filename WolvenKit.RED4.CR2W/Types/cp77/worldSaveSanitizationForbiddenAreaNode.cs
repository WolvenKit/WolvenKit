using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSaveSanitizationForbiddenAreaNode : worldTriggerAreaNode
	{
		[Ordinal(7)] [RED("safeSpotOffset")] public Vector4 SafeSpotOffset { get; set; }

		public worldSaveSanitizationForbiddenAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
