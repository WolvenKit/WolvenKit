using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiDistrictTriggerData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("district")] 
		public CEnum<gamedataDistrict> District
		{
			get => GetPropertyValue<CEnum<gamedataDistrict>>();
			set => SetPropertyValue<CEnum<gamedataDistrict>>(value);
		}

		[Ordinal(1)] 
		[RED("triggerName")] 
		public CName TriggerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiDistrictTriggerData()
		{
			District = Enums.gamedataDistrict.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
