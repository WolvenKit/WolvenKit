
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleVisualDestruction_Record
	{
		[RED("back")]
		[REDProperty(IsIgnored = true)]
		public CFloat Back
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("backLeft")]
		[REDProperty(IsIgnored = true)]
		public CFloat BackLeft
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("backRight")]
		[REDProperty(IsIgnored = true)]
		public CFloat BackRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("front")]
		[REDProperty(IsIgnored = true)]
		public CFloat Front
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("frontLeft")]
		[REDProperty(IsIgnored = true)]
		public CFloat FrontLeft
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("frontRight")]
		[REDProperty(IsIgnored = true)]
		public CFloat FrontRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("left")]
		[REDProperty(IsIgnored = true)]
		public CFloat Left
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("right")]
		[REDProperty(IsIgnored = true)]
		public CFloat Right
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("roof")]
		[REDProperty(IsIgnored = true)]
		public CFloat Roof
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("setVisualDestruction")]
		[REDProperty(IsIgnored = true)]
		public CBool SetVisualDestruction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
