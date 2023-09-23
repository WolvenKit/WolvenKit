using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inGameMenuAnimContainer : IScriptable
	{
		[Ordinal(0)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public inGameMenuAnimContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
