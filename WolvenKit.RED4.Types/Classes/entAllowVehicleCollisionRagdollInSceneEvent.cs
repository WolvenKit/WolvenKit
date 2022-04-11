using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAllowVehicleCollisionRagdollInSceneEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("allow")] 
		public CBool Allow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entAllowVehicleCollisionRagdollInSceneEvent()
		{
			Allow = true;
		}
	}
}
