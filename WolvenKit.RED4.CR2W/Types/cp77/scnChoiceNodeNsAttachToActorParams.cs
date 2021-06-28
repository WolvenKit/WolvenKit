using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAttachToActorParams : CVariable
	{
		private scnActorId _actorId;
		private CEnum<scnChoiceNodeNsVisualizerStyle> _visualizerStyle;

		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetProperty(ref _actorId);
			set => SetProperty(ref _actorId, value);
		}

		[Ordinal(1)] 
		[RED("visualizerStyle")] 
		public CEnum<scnChoiceNodeNsVisualizerStyle> VisualizerStyle
		{
			get => GetProperty(ref _visualizerStyle);
			set => SetProperty(ref _visualizerStyle, value);
		}

		public scnChoiceNodeNsAttachToActorParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
