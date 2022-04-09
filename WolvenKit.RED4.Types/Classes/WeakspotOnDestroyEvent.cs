using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeakspotOnDestroyEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("weakspotRecordData")] 
		public WeakspotRecordData WeakspotRecordData
		{
			get => GetPropertyValue<WeakspotRecordData>();
			set => SetPropertyValue<WeakspotRecordData>(value);
		}

		public WeakspotOnDestroyEvent()
		{
			WeakspotRecordData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
