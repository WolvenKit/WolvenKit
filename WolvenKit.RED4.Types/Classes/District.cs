using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class District : IScriptable
	{
		private TweakDBID _districtID;
		private TweakDBID _presetID;

		[Ordinal(0)] 
		[RED("districtID")] 
		public TweakDBID DistrictID
		{
			get => GetProperty(ref _districtID);
			set => SetProperty(ref _districtID, value);
		}

		[Ordinal(1)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get => GetProperty(ref _presetID);
			set => SetProperty(ref _presetID, value);
		}
	}
}
