using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioParameterNodeType : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("param")] 
		public audioAudParameter Param
		{
			get => GetPropertyValue<audioAudParameter>();
			set => SetPropertyValue<audioAudParameter>(value);
		}

		[Ordinal(1)] 
		[RED("isMusic")] 
		public CBool IsMusic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questAudioParameterNodeType()
		{
			Param = new() { EnterCurveType = Enums.audioESoundCurveType.Linear, EnterCurveTime = 1.000000F, ExitCurveType = Enums.audioESoundCurveType.Linear, ExitCurveTime = 1.000000F };
			ObjectRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
