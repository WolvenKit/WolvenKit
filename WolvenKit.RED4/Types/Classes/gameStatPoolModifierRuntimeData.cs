using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatPoolModifierRuntimeData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("modifier")] 
		public gameStatPoolModifier Modifier
		{
			get => GetPropertyValue<gameStatPoolModifier>();
			set => SetPropertyValue<gameStatPoolModifier>(value);
		}

		[Ordinal(1)] 
		[RED("modificationDelay")] 
		public CFloat ModificationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("inRange")] 
		public CBool InRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameStatPoolModifierRuntimeData()
		{
			Modifier = new gameStatPoolModifier();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
