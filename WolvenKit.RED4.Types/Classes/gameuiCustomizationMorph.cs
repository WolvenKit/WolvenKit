using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCustomizationMorph : gameuiCensorshipInfo
	{
		private CName _regionName;
		private CName _targetName;

		[Ordinal(2)] 
		[RED("regionName")] 
		public CName RegionName
		{
			get => GetProperty(ref _regionName);
			set => SetProperty(ref _regionName, value);
		}

		[Ordinal(3)] 
		[RED("targetName")] 
		public CName TargetName
		{
			get => GetProperty(ref _targetName);
			set => SetProperty(ref _targetName, value);
		}
	}
}
