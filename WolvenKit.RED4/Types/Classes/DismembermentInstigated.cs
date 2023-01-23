using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DismembermentInstigated : redEvent
	{
		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CEnum<EHitReactionZone> BodyPart
		{
			get => GetPropertyValue<CEnum<EHitReactionZone>>();
			set => SetPropertyValue<CEnum<EHitReactionZone>>(value);
		}

		public DismembermentInstigated()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
