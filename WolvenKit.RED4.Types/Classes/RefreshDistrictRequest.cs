using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RefreshDistrictRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("preventionPreset")] 
		public CWeakHandle<gamedataDistrictPreventionData_Record> PreventionPreset
		{
			get => GetPropertyValue<CWeakHandle<gamedataDistrictPreventionData_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataDistrictPreventionData_Record>>(value);
		}

		public RefreshDistrictRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
