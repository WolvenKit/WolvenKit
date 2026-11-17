using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMoveOnSplineAdditionalParams : ISerializable
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<questMoveOnSplineType> Type
		{
			get => GetPropertyValue<CEnum<questMoveOnSplineType>>();
			set => SetPropertyValue<CEnum<questMoveOnSplineType>>(value);
		}

		[Ordinal(1)] 
		[RED("simpleParams")] 
		public questSimpleMoveOnSplineParams SimpleParams
		{
			get => GetPropertyValue<questSimpleMoveOnSplineParams>();
			set => SetPropertyValue<questSimpleMoveOnSplineParams>(value);
		}

		[Ordinal(2)] 
		[RED("animParams")] 
		public questAnimMoveOnSplineParams AnimParams
		{
			get => GetPropertyValue<questAnimMoveOnSplineParams>();
			set => SetPropertyValue<questAnimMoveOnSplineParams>(value);
		}

		[Ordinal(3)] 
		[RED("withCompanionParams")] 
		public questWithCompanionMoveOnSplineParams WithCompanionParams
		{
			get => GetPropertyValue<questWithCompanionMoveOnSplineParams>();
			set => SetPropertyValue<questWithCompanionMoveOnSplineParams>(value);
		}

		public questMoveOnSplineAdditionalParams()
		{
			SimpleParams = new questSimpleMoveOnSplineParams();
			AnimParams = new questAnimMoveOnSplineParams();
			WithCompanionParams = new questWithCompanionMoveOnSplineParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
