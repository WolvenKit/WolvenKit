using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMoveOnSplineAdditionalParams : ISerializable
	{
		private CEnum<questMoveOnSplineType> _type;
		private questSimpleMoveOnSplineParams _simpleParams;
		private questAnimMoveOnSplineParams _animParams;
		private questWithCompanionMoveOnSplineParams _withCompanionParams;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<questMoveOnSplineType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("simpleParams")] 
		public questSimpleMoveOnSplineParams SimpleParams
		{
			get => GetProperty(ref _simpleParams);
			set => SetProperty(ref _simpleParams, value);
		}

		[Ordinal(2)] 
		[RED("animParams")] 
		public questAnimMoveOnSplineParams AnimParams
		{
			get => GetProperty(ref _animParams);
			set => SetProperty(ref _animParams, value);
		}

		[Ordinal(3)] 
		[RED("withCompanionParams")] 
		public questWithCompanionMoveOnSplineParams WithCompanionParams
		{
			get => GetProperty(ref _withCompanionParams);
			set => SetProperty(ref _withCompanionParams, value);
		}
	}
}
