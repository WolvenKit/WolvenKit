using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDefaultMixingSignposts : audioAudioMetadata
	{
		[Ordinal(1)] [RED("endOfCombat")] public CName EndOfCombat { get; set; }
		[Ordinal(2)] [RED("inCombat")] public CName InCombat { get; set; }
		[Ordinal(3)] [RED("inStealth")] public CName InStealth { get; set; }
		[Ordinal(4)] [RED("aiAlerted")] public CName AiAlerted { get; set; }
		[Ordinal(5)] [RED("sceneBootstrapSignpost")] public CName SceneBootstrapSignpost { get; set; }
		[Ordinal(6)] [RED("reservedSignposts")] public CArray<CName> ReservedSignposts { get; set; }

		public audioDefaultMixingSignposts(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
