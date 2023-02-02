using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WoundedInstigated : redEvent
	{
		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CEnum<EHitReactionZone> BodyPart
		{
			get => GetPropertyValue<CEnum<EHitReactionZone>>();
			set => SetPropertyValue<CEnum<EHitReactionZone>>(value);
		}

		public WoundedInstigated()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
