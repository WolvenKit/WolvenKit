using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceMappinsContainer : IScriptable
	{
		[Ordinal(0)] 
		[RED("mappins")] 
		public CArray<SDeviceMappinData> Mappins
		{
			get => GetPropertyValue<CArray<SDeviceMappinData>>();
			set => SetPropertyValue<CArray<SDeviceMappinData>>(value);
		}

		[Ordinal(1)] 
		[RED("newNewFocusMappin")] 
		public SDeviceMappinData NewNewFocusMappin
		{
			get => GetPropertyValue<SDeviceMappinData>();
			set => SetPropertyValue<SDeviceMappinData>(value);
		}

		[Ordinal(2)] 
		[RED("useNewFocusMappin")] 
		public CBool UseNewFocusMappin
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("offsetValue")] 
		public CFloat OffsetValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DeviceMappinsContainer()
		{
			Mappins = new();
			NewNewFocusMappin = new() { Enabled = true, Range = 30.000000F, Offset = new(), Position = new(), CheckIfIsTarget = true, Id = new() };
			OffsetValue = 0.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
