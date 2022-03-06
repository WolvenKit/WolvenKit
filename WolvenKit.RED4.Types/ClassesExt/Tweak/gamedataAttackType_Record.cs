
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAttackType_Record
	{
		[RED("comment")]
		[REDProperty(IsIgnored = true)]
		public CString Comment
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
