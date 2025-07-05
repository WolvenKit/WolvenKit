
namespace WolvenKit.RED4.Types
{
	public partial class gamedataValueAssignment_Record
	{
		[RED("overrideValue")]
		[REDProperty(IsIgnored = true)]
		public CInt32 OverrideValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
