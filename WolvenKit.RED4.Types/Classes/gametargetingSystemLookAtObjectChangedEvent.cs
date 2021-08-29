using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gametargetingSystemLookAtObjectChangedEvent : redEvent
	{
		private CWeakHandle<gameObject> _lookatObject;

		[Ordinal(0)] 
		[RED("lookatObject")] 
		public CWeakHandle<gameObject> LookatObject
		{
			get => GetProperty(ref _lookatObject);
			set => SetProperty(ref _lookatObject, value);
		}
	}
}
