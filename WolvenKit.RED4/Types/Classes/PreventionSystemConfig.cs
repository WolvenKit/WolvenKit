using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionSystemConfig : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public PreventionSystemConfig()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
