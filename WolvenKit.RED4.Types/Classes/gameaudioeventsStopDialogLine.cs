using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsStopDialogLine : redEvent
	{
		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(1)] 
		[RED("fadeOut")] 
		public CFloat FadeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameaudioeventsStopDialogLine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
