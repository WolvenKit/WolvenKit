using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InspectionTriggerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("item")] 
		public CString Item
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("adsOffset")] 
		public CFloat AdsOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("timeToScan")] 
		public CFloat TimeToScan
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("inspectedObjID")] 
		public entEntityID InspectedObjID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public InspectionTriggerEvent()
		{
			InspectedObjID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
