using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_RevealObject : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameEffectExecutor_RevealObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
