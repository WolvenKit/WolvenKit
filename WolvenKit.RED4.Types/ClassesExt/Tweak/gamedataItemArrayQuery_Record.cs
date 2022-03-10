
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemArrayQuery_Record
	{
		[RED("maxItems")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxItems
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("minItems")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MinItems
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
