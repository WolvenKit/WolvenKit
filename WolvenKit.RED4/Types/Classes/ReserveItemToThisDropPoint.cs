using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReserveItemToThisDropPoint : ScriptableDeviceAction
	{
		[Ordinal(38)] 
		[RED("item")] 
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ReserveItemToThisDropPoint()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
