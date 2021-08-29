using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleDriveToGameObjectEvent : redEvent
	{
		private CWeakHandle<gameObject> _targetObjToReach;

		[Ordinal(0)] 
		[RED("targetObjToReach")] 
		public CWeakHandle<gameObject> TargetObjToReach
		{
			get => GetProperty(ref _targetObjToReach);
			set => SetProperty(ref _targetObjToReach, value);
		}
	}
}
