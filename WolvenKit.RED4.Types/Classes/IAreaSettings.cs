using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IAreaSettings : ISerializable
	{
		private CBool _enable;
		private CUInt64 _disabledIndexedProperties;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("disabledIndexedProperties")] 
		public CUInt64 DisabledIndexedProperties
		{
			get => GetProperty(ref _disabledIndexedProperties);
			set => SetProperty(ref _disabledIndexedProperties, value);
		}
	}
}
