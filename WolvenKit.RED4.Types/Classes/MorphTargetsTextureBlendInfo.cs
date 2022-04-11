using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MorphTargetsTextureBlendInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("blend")] 
		public CBool Blend
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("diffSize")] 
		public CEnum<MorphTargetsDiffTextureSize> DiffSize
		{
			get => GetPropertyValue<CEnum<MorphTargetsDiffTextureSize>>();
			set => SetPropertyValue<CEnum<MorphTargetsDiffTextureSize>>(value);
		}

		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public MorphTargetsTextureBlendInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
