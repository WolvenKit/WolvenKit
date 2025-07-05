using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnVoicetagId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CRUID Id
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		public scnVoicetagId()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
