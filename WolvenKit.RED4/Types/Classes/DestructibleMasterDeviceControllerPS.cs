using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DestructibleMasterDeviceControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DestructibleMasterDeviceControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
