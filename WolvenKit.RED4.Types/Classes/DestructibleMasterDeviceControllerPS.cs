using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DestructibleMasterDeviceControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
