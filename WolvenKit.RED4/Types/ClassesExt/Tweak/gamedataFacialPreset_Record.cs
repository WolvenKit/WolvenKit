
namespace WolvenKit.RED4.Types
{
	public partial class gamedataFacialPreset_Record
	{
		[RED("eyesBlendAdditive")]
		[REDProperty(IsIgnored = true)]
		public CBool EyesBlendAdditive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("lowerFaceBlendAdditive")]
		[REDProperty(IsIgnored = true)]
		public CBool LowerFaceBlendAdditive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("profileName")]
		[REDProperty(IsIgnored = true)]
		public CName ProfileName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("upperFaceBlendAdditive")]
		[REDProperty(IsIgnored = true)]
		public CBool UpperFaceBlendAdditive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
