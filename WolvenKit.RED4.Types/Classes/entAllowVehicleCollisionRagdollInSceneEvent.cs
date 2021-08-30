using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAllowVehicleCollisionRagdollInSceneEvent : redEvent
	{
		private CBool _allow;

		[Ordinal(0)] 
		[RED("allow")] 
		public CBool Allow
		{
			get => GetProperty(ref _allow);
			set => SetProperty(ref _allow, value);
		}

		public entAllowVehicleCollisionRagdollInSceneEvent()
		{
			_allow = true;
		}
	}
}
