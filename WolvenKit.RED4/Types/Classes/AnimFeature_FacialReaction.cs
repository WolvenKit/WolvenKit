using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_FacialReaction : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("category")] 
		public CInt32 Category
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("idle")] 
		public CInt32 Idle
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeature_FacialReaction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
