using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnlocLocstringId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		public scnlocLocstringId()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
