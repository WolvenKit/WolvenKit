using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPuppeteerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("effector")] public CHandle<questPuppetsEffector> Effector { get; set; }
		[Ordinal(3)] [RED("reference")] public gameEntityReference Reference { get; set; }

		public questPuppeteerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
