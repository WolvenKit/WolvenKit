
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWidgetStyle_Record
	{
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CString EnumName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
