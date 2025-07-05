using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatModifierGroup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("statModifierArray")] 
		public CArray<gameStatModifierHandle> StatModifierArray
		{
			get => GetPropertyValue<CArray<gameStatModifierHandle>>();
			set => SetPropertyValue<CArray<gameStatModifierHandle>>(value);
		}

		[Ordinal(1)] 
		[RED("statModifiersLimit")] 
		public CInt32 StatModifiersLimit
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("statModifiersLimitModifier")] 
		public TweakDBID StatModifiersLimitModifier
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("relatedModifierGroups")] 
		public CArray<TweakDBID> RelatedModifierGroups
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(4)] 
		[RED("statModifierGroupRecordID")] 
		public TweakDBID StatModifierGroupRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("stackCount")] 
		public CUInt16 StackCount
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(6)] 
		[RED("drawBasedOnStatType")] 
		public CBool DrawBasedOnStatType
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("saveBasedOnStatType")] 
		public CBool SaveBasedOnStatType
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("optimiseCombinedModifiers")] 
		public CBool OptimiseCombinedModifiers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameStatModifierGroup()
		{
			StatModifierArray = new();
			RelatedModifierGroups = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
