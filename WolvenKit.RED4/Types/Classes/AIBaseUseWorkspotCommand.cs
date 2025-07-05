using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AIBaseUseWorkspotCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("moveToWorkspot")] 
		public CBool MoveToWorkspot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("forceEntryAnimName")] 
		public CName ForceEntryAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("workExcludedGestures")] 
		public CArray<workWorkEntryId> WorkExcludedGestures
		{
			get => GetPropertyValue<CArray<workWorkEntryId>>();
			set => SetPropertyValue<CArray<workWorkEntryId>>(value);
		}

		[Ordinal(7)] 
		[RED("infiniteSequenceEntryId")] 
		public workWorkEntryId InfiniteSequenceEntryId
		{
			get => GetPropertyValue<workWorkEntryId>();
			set => SetPropertyValue<workWorkEntryId>(value);
		}

		[Ordinal(8)] 
		[RED("idleOnlyMode")] 
		public CBool IdleOnlyMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("continueInCombat")] 
		public CBool ContinueInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		public AIBaseUseWorkspotCommand()
		{
			Id = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
