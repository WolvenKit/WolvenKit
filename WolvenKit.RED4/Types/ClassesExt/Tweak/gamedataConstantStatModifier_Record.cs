
namespace WolvenKit.RED4.Types
{
	public partial class gamedataConstantStatModifier_Record
	{
		[RED("value")]
		[REDProperty(IsIgnored = true)]
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
