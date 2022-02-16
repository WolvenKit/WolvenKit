using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_HitRepresentation_Raycast : gameEffectObjectFilter_HitRepresentation
	{
		[Ordinal(0)] 
		[RED("isPreview")] 
		public CBool IsPreview
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("fillNearlyHitData")] 
		public CBool FillNearlyHitData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
