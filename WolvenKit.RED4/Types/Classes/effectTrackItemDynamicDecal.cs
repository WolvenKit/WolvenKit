using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemDynamicDecal : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("material")] 
		public CResourceReference<IMaterial> Material
		{
			get => GetPropertyValue<CResourceReference<IMaterial>>();
			set => SetPropertyValue<CResourceReference<IMaterial>>(value);
		}

		[Ordinal(4)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("fadeInTime")] 
		public CFloat FadeInTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("fadeOutTime")] 
		public CFloat FadeOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("additionalRotation")] 
		public CFloat AdditionalRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("randomRotation")] 
		public CBool RandomRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public effectTrackItemDynamicDecal()
		{
			TimeDuration = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
