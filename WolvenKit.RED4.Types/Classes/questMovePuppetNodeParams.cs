using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMovePuppetNodeParams : questAICommandParams
	{
		[Ordinal(0)] 
		[RED("moveType")] 
		public CEnum<questMoveType> MoveType
		{
			get => GetPropertyValue<CEnum<questMoveType>>();
			set => SetPropertyValue<CEnum<questMoveType>>(value);
		}

		[Ordinal(1)] 
		[RED("moveOnSplineParams")] 
		public CHandle<questMoveOnSplineParams> MoveOnSplineParams
		{
			get => GetPropertyValue<CHandle<questMoveOnSplineParams>>();
			set => SetPropertyValue<CHandle<questMoveOnSplineParams>>(value);
		}

		[Ordinal(2)] 
		[RED("moveToParams")] 
		public CHandle<questMoveToParams> MoveToParams
		{
			get => GetPropertyValue<CHandle<questMoveToParams>>();
			set => SetPropertyValue<CHandle<questMoveToParams>>(value);
		}

		[Ordinal(3)] 
		[RED("otherParams")] 
		public CHandle<questAICommandParams> OtherParams
		{
			get => GetPropertyValue<CHandle<questAICommandParams>>();
			set => SetPropertyValue<CHandle<questAICommandParams>>(value);
		}

		[Ordinal(4)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questMovePuppetNodeParams()
		{
			RepeatCommandOnInterrupt = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
