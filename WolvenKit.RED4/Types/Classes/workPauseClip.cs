using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workPauseClip : workIEntry
	{
		[Ordinal(2)] 
		[RED("timeMin")] 
		public CFloat TimeMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("timeMax")] 
		public CFloat TimeMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public workPauseClip()
		{
			Id = new() { Id = 4294967295 };
			Flags = 32;
			TimeMin = 2.000000F;
			TimeMax = 5.000000F;
			BlendOutTime = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
