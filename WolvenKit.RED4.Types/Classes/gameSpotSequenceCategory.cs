using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSpotSequenceCategory : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataWorkspotCategory> Type
		{
			get => GetPropertyValue<CEnum<gamedataWorkspotCategory>>();
			set => SetPropertyValue<CEnum<gamedataWorkspotCategory>>(value);
		}

		[Ordinal(1)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameSpotSequenceCategory()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
