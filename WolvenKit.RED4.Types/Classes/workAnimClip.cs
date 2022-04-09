using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workAnimClip : workIEntry
	{
		[Ordinal(2)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public workAnimClip()
		{
			Id = new() { Id = 4294967295 };
			Flags = 2;
			BlendOutTime = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
