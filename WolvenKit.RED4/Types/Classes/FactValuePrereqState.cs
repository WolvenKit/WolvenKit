using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FactValuePrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listenerID")] 
		public CUInt32 ListenerID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public FactValuePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
