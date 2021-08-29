using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class textWrappingInfo : RedBaseClass
	{
		private CBool _autoWrappingEnabled;
		private CFloat _wrappingAtPosition;
		private CEnum<textWrappingPolicy> _wrappingPolicy;

		[Ordinal(0)] 
		[RED("autoWrappingEnabled")] 
		public CBool AutoWrappingEnabled
		{
			get => GetProperty(ref _autoWrappingEnabled);
			set => SetProperty(ref _autoWrappingEnabled, value);
		}

		[Ordinal(1)] 
		[RED("wrappingAtPosition")] 
		public CFloat WrappingAtPosition
		{
			get => GetProperty(ref _wrappingAtPosition);
			set => SetProperty(ref _wrappingAtPosition, value);
		}

		[Ordinal(2)] 
		[RED("wrappingPolicy")] 
		public CEnum<textWrappingPolicy> WrappingPolicy
		{
			get => GetProperty(ref _wrappingPolicy);
			set => SetProperty(ref _wrappingPolicy, value);
		}
	}
}
