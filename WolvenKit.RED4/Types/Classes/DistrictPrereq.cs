using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DistrictPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("district")] 
		public CWeakHandle<gamedataDistrict_Record> District
		{
			get => GetPropertyValue<CWeakHandle<gamedataDistrict_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataDistrict_Record>>(value);
		}

		public DistrictPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
