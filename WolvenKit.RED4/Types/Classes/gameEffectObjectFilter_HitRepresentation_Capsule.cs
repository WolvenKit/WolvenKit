using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_HitRepresentation_Capsule : gameEffectObjectFilter_HitRepresentation
	{
		[Ordinal(0)] 
		[RED("flattenCapsuleToHeight")] 
		public CBool FlattenCapsuleToHeight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectObjectFilter_HitRepresentation_Capsule()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
