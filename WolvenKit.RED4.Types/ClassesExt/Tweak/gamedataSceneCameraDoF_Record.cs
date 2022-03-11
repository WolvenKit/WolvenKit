
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSceneCameraDoF_Record
	{
		[RED("dofFarBlur")]
		[REDProperty(IsIgnored = true)]
		public CFloat DofFarBlur
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dofFarFocus")]
		[REDProperty(IsIgnored = true)]
		public CFloat DofFarFocus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dofIntensity")]
		[REDProperty(IsIgnored = true)]
		public CFloat DofIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dofNearBlur")]
		[REDProperty(IsIgnored = true)]
		public CFloat DofNearBlur
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dofNearFocus")]
		[REDProperty(IsIgnored = true)]
		public CFloat DofNearFocus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("profileName")]
		[REDProperty(IsIgnored = true)]
		public CName ProfileName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("useFarPlane")]
		[REDProperty(IsIgnored = true)]
		public CBool UseFarPlane
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("useNearPlane")]
		[REDProperty(IsIgnored = true)]
		public CBool UseNearPlane
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
