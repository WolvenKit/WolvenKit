using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiInGameMenuGameControllerGarmentSwitchEffectController : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
