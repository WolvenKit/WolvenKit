using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questPuppeteerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("effector")] public CHandle<questPuppetsEffector> Effector { get; set; }
		[Ordinal(1)]  [RED("reference")] public gameEntityReference Reference { get; set; }

		public questPuppeteerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
