
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMappinUIParamGroup_Record
	{
		[RED("maxFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("quadratic")]
		[REDProperty(IsIgnored = true)]
		public CBool Quadratic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("quadraticPeakMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat QuadraticPeakMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("valueOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat ValueOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
