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
		[RED("drawBasedOnStatType")] 
		public CBool DrawBasedOnStatType
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameStatModifierGroup()
		{
			StatModifierArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
