using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SequenceCallback : redEvent
	{
		[Ordinal(0)] 
		[RED("persistentID")] 
		public gamePersistentID PersistentID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(1)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("actionToForward")] 
		public CHandle<ScriptableDeviceAction> ActionToForward
		{
			get => GetPropertyValue<CHandle<ScriptableDeviceAction>>();
			set => SetPropertyValue<CHandle<ScriptableDeviceAction>>(value);
		}

		public SequenceCallback()
		{
			PersistentID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
