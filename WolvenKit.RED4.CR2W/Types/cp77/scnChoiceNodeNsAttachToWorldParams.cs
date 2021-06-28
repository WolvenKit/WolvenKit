using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAttachToWorldParams : CVariable
	{
		private Vector3 _entityPosition;
		private Quaternion _entityOrientation;
		private CFloat _customEntityRadius;
		private CEnum<scnChoiceNodeNsVisualizerStyle> _visualizerStyle;

		[Ordinal(0)] 
		[RED("entityPosition")] 
		public Vector3 EntityPosition
		{
			get => GetProperty(ref _entityPosition);
			set => SetProperty(ref _entityPosition, value);
		}

		[Ordinal(1)] 
		[RED("entityOrientation")] 
		public Quaternion EntityOrientation
		{
			get => GetProperty(ref _entityOrientation);
			set => SetProperty(ref _entityOrientation, value);
		}

		[Ordinal(2)] 
		[RED("customEntityRadius")] 
		public CFloat CustomEntityRadius
		{
			get => GetProperty(ref _customEntityRadius);
			set => SetProperty(ref _customEntityRadius, value);
		}

		[Ordinal(3)] 
		[RED("visualizerStyle")] 
		public CEnum<scnChoiceNodeNsVisualizerStyle> VisualizerStyle
		{
			get => GetProperty(ref _visualizerStyle);
			set => SetProperty(ref _visualizerStyle, value);
		}

		public scnChoiceNodeNsAttachToWorldParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
