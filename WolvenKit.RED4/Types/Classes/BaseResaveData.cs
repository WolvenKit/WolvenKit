using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseResaveData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("baseDeviceData")] 
		public BaseDeviceData BaseDeviceData
		{
			get => GetPropertyValue<BaseDeviceData>();
			set => SetPropertyValue<BaseDeviceData>(value);
		}

		[Ordinal(1)] 
		[RED("tweakDBRecord")] 
		public TweakDBID TweakDBRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public BaseResaveData()
		{
			BaseDeviceData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
