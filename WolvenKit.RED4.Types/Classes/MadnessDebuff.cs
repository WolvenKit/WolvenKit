using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MadnessDebuff : redEvent
	{
		[Ordinal(0)] 
		[RED("object")] 
		public CWeakHandle<gameObject> Object
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
