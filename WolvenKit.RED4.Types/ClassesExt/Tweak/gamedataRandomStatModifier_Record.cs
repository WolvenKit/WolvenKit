
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRandomStatModifier_Record
	{
		[RED("max")]
		[REDProperty(IsIgnored = true)]
		public CFloat Max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("min")]
		[REDProperty(IsIgnored = true)]
		public CFloat Min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useControlledRandom")]
		[REDProperty(IsIgnored = true)]
		public CBool UseControlledRandom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
