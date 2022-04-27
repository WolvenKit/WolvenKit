
namespace WolvenKit.RED4.Types
{
	public partial class gamedatadevice_role_action_desctiption_Record
	{
		[RED("isQuickHack")]
		[REDProperty(IsIgnored = true)]
		public CBool IsQuickHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("skillcheck")]
		[REDProperty(IsIgnored = true)]
		public CString Skillcheck
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
