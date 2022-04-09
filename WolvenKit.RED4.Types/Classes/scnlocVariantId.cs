using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnlocVariantId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		public scnlocVariantId()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
