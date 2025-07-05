using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAudioTagNode : worldNode
	{
		[Ordinal(4)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldAudioTagNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
