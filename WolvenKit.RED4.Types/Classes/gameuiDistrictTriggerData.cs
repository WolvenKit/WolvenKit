using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiDistrictTriggerData : RedBaseClass
	{
		private CEnum<gamedataDistrict> _district;
		private CName _triggerName;

		[Ordinal(0)] 
		[RED("district")] 
		public CEnum<gamedataDistrict> District
		{
			get => GetProperty(ref _district);
			set => SetProperty(ref _district, value);
		}

		[Ordinal(1)] 
		[RED("triggerName")] 
		public CName TriggerName
		{
			get => GetProperty(ref _triggerName);
			set => SetProperty(ref _triggerName, value);
		}
	}
}
