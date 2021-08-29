using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileFollowEvent : redEvent
	{
		private CWeakHandle<gameObject> _followObject;

		[Ordinal(0)] 
		[RED("followObject")] 
		public CWeakHandle<gameObject> FollowObject
		{
			get => GetProperty(ref _followObject);
			set => SetProperty(ref _followObject, value);
		}
	}
}
