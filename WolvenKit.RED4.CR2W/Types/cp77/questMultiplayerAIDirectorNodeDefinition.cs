using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerAIDirectorNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("params")] public CHandle<questMultiplayerAIDirectorParams> Params { get; set; }

		public questMultiplayerAIDirectorNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
