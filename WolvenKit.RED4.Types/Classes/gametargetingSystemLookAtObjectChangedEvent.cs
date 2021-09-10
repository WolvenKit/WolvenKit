using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gametargetingSystemLookAtObjectChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("lookatObject")] 
		public CWeakHandle<gameObject> LookatObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
