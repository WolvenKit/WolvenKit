using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_OwnerType : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("ownerEnum")] 
		public CInt32 OwnerEnum
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeature_OwnerType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
