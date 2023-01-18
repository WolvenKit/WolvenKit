
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPrereq_Record
	{
		[RED("andValues")]
		[REDProperty(IsIgnored = true)]
		public CBool AndValues
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("checks")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Checks
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("devNotes")]
		[REDProperty(IsIgnored = true)]
		public CString DevNotes
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
