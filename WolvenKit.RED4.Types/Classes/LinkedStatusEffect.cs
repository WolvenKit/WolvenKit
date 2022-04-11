using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LinkedStatusEffect : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("netrunnerIDs")] 
		public CArray<entEntityID> NetrunnerIDs
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(1)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("statusEffectList")] 
		public CArray<TweakDBID> StatusEffectList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public LinkedStatusEffect()
		{
			NetrunnerIDs = new();
			TargetID = new();
			StatusEffectList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
