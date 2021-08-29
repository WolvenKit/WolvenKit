using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsCoverHitEvent : gameeventsHitEvent
	{
		private CWeakHandle<gameObject> _cover;

		[Ordinal(12)] 
		[RED("cover")] 
		public CWeakHandle<gameObject> Cover
		{
			get => GetProperty(ref _cover);
			set => SetProperty(ref _cover, value);
		}
	}
}
