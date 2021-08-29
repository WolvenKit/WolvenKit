using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseResaveData : RedBaseClass
	{
		private BaseDeviceData _baseDeviceData;
		private TweakDBID _tweakDBRecord;

		[Ordinal(0)] 
		[RED("baseDeviceData")] 
		public BaseDeviceData BaseDeviceData
		{
			get => GetProperty(ref _baseDeviceData);
			set => SetProperty(ref _baseDeviceData, value);
		}

		[Ordinal(1)] 
		[RED("tweakDBRecord")] 
		public TweakDBID TweakDBRecord
		{
			get => GetProperty(ref _tweakDBRecord);
			set => SetProperty(ref _tweakDBRecord, value);
		}
	}
}
