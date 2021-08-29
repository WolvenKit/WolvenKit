using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimMathExpressionFloatSocket : RedBaseClass
	{
		private animFloatLink _link;
		private CUInt16 _expressionVarId;
		private animNamedTrackIndex _inputFloatTrack;

		[Ordinal(0)] 
		[RED("link")] 
		public animFloatLink Link
		{
			get => GetProperty(ref _link);
			set => SetProperty(ref _link, value);
		}

		[Ordinal(1)] 
		[RED("expressionVarId")] 
		public CUInt16 ExpressionVarId
		{
			get => GetProperty(ref _expressionVarId);
			set => SetProperty(ref _expressionVarId, value);
		}

		[Ordinal(2)] 
		[RED("inputFloatTrack")] 
		public animNamedTrackIndex InputFloatTrack
		{
			get => GetProperty(ref _inputFloatTrack);
			set => SetProperty(ref _inputFloatTrack, value);
		}
	}
}
