using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAudioSignpostTriggerNode : worldTriggerAreaNode
	{
		[Ordinal(5)] 
		[RED("enterSignpost")] 
		public CName EnterSignpost
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("exitSignpost")] 
		public CName ExitSignpost
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("reEnterSignpost")] 
		public CName ReEnterSignpost
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("preExitSignpost")] 
		public CName PreExitSignpost
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("exitCooldown")] 
		public CFloat ExitCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldAudioSignpostTriggerNode()
		{
			Color = new CColor { Green = 255, Blue = 255, Alpha = 255 };
			ExitCooldown = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
