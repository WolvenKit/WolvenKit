using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SHighlightTarget : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get => GetPropertyValue<CEnum<EFocusForcedHighlightType>>();
			set => SetPropertyValue<CEnum<EFocusForcedHighlightType>>(value);
		}

		public SHighlightTarget()
		{
			TargetID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
