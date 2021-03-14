using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCutControlNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("permanent")] public CBool Permanent { get; set; }

		public questCutControlNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
