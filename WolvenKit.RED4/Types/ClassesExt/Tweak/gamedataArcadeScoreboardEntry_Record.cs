
namespace WolvenKit.RED4.Types
{
	public partial class gamedataArcadeScoreboardEntry_Record
	{
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("score")]
		[REDProperty(IsIgnored = true)]
		public CFloat Score
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
