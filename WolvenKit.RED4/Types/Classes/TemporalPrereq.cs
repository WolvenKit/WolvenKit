using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TemporalPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("totalDuration")] 
		public CFloat TotalDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public TemporalPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
