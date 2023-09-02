using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConfessionBooth : BasicDistractionDevice
	{
		[Ordinal(100)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(101)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public ConfessionBooth()
		{
			ControllerTypeName = "ConfessionBoothController";
			ShortGlitchDelayID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
