using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questOutputNodeDefinition : questIONodeDefinition
	{
		[Ordinal(3)] [RED("type")] public CEnum<questExitType> Type { get; set; }

		public questOutputNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
