using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsCoverHitEvent : gameeventsHitEvent
	{
		[Ordinal(12)] 
		[RED("cover")] 
		public CWeakHandle<gameObject> Cover
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
