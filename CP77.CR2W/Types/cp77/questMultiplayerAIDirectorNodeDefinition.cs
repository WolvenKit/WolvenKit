using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerAIDirectorNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("params")] public CHandle<questMultiplayerAIDirectorParams> Params { get; set; }

		public questMultiplayerAIDirectorNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
