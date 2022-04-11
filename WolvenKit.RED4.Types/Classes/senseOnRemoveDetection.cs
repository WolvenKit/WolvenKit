using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseOnRemoveDetection : redEvent
	{
		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
