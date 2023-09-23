using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DriverCombatListener : IScriptable
	{
		[Ordinal(0)] 
		[RED("mountedCallback")] 
		public CHandle<redCallbackObject> MountedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(1)] 
		[RED("tppCallback")] 
		public CHandle<redCallbackObject> TppCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(2)] 
		[RED("isMounted")] 
		public CBool IsMounted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isInTPP")] 
		public CBool IsInTPP
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DriverCombatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
