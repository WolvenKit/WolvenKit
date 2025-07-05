using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnExecutionTag : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public scnExecutionTag()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
