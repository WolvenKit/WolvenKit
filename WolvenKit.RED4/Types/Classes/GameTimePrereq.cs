using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameTimePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public GameTimePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
