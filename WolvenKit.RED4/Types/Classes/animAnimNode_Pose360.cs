using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Pose360 : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("angle")] 
		public animFloatLink Angle
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(12)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_Pose360()
		{
			Id = uint.MaxValue;
			Angle = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
