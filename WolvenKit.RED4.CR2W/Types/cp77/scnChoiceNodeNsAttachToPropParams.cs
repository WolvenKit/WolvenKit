using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAttachToPropParams : CVariable
	{
		private scnPropId _propId;
		private CEnum<scnChoiceNodeNsVisualizerStyle> _visualizerStyle;

		[Ordinal(0)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get => GetProperty(ref _propId);
			set => SetProperty(ref _propId, value);
		}

		[Ordinal(1)] 
		[RED("visualizerStyle")] 
		public CEnum<scnChoiceNodeNsVisualizerStyle> VisualizerStyle
		{
			get => GetProperty(ref _visualizerStyle);
			set => SetProperty(ref _visualizerStyle, value);
		}

		public scnChoiceNodeNsAttachToPropParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
