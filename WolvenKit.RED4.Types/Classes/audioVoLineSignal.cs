using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoLineSignal : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(1)] 
		[RED("signal")] 
		public CName Signal
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
