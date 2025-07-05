using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimMathExpressionFloatSocket : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("link")] 
		public animFloatLink Link
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(1)] 
		[RED("expressionVarId")] 
		public CUInt16 ExpressionVarId
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("inputFloatTrack")] 
		public animNamedTrackIndex InputFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animAnimMathExpressionFloatSocket()
		{
			Link = new animFloatLink();
			InputFloatTrack = new animNamedTrackIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
