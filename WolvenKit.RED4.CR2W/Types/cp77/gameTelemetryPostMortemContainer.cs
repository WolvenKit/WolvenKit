using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryPostMortemContainer : ISerializable
	{
		private gameTelemetryPostMortem _postMortem;

		[Ordinal(0)] 
		[RED("postMortem")] 
		public gameTelemetryPostMortem PostMortem
		{
			get => GetProperty(ref _postMortem);
			set => SetProperty(ref _postMortem, value);
		}

		public gameTelemetryPostMortemContainer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
