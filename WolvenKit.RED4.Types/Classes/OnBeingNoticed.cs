using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnBeingNoticed : redEvent
	{
		private CWeakHandle<gameObject> _objectThatNoticed;

		[Ordinal(0)] 
		[RED("objectThatNoticed")] 
		public CWeakHandle<gameObject> ObjectThatNoticed
		{
			get => GetProperty(ref _objectThatNoticed);
			set => SetProperty(ref _objectThatNoticed, value);
		}
	}
}
