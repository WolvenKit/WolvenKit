using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshDistrictRequest : gameScriptableSystemRequest
	{
		private CWeakHandle<gamedataDistrictPreventionData_Record> _preventionPreset;

		[Ordinal(0)] 
		[RED("preventionPreset")] 
		public CWeakHandle<gamedataDistrictPreventionData_Record> PreventionPreset
		{
			get => GetProperty(ref _preventionPreset);
			set => SetProperty(ref _preventionPreset, value);
		}
	}
}
