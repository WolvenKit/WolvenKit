using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLookAtPartInfo : RedBaseClass
	{
		private CName _partName;
		private CName _defaultPositionBoneName;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}

		[Ordinal(1)] 
		[RED("defaultPositionBoneName")] 
		public CName DefaultPositionBoneName
		{
			get => GetProperty(ref _defaultPositionBoneName);
			set => SetProperty(ref _defaultPositionBoneName, value);
		}
	}
}
