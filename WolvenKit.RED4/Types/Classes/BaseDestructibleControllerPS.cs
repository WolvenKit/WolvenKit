using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseDestructibleControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("destroyed")] 
		public CBool Destroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BaseDestructibleControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
