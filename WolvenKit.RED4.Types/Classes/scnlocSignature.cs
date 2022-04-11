using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnlocSignature : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("val")] 
		public CUInt64 Val
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public scnlocSignature()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
