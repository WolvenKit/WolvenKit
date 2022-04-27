
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLightPreset_Record
	{
		[RED("colorMax")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> ColorMax
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("colorMin")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> ColorMin
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("curve")]
		[REDProperty(IsIgnored = true)]
		public CName Curve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("force")]
		[REDProperty(IsIgnored = true)]
		public CBool Force
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("loop")]
		[REDProperty(IsIgnored = true)]
		public CBool Loop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("on")]
		[REDProperty(IsIgnored = true)]
		public CBool On
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("overrideColorMin")]
		[REDProperty(IsIgnored = true)]
		public CBool OverrideColorMin
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("strength")]
		[REDProperty(IsIgnored = true)]
		public CFloat Strength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("time")]
		[REDProperty(IsIgnored = true)]
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
