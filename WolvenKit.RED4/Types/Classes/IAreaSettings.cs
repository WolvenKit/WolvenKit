using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class IAreaSettings : ISerializable
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("disabledIndexedProperties")] 
		public CUInt64 DisabledIndexedProperties
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public IAreaSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
