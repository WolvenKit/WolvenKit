
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAINPCDifficultyCond_Record
	{
		[RED("comparedDifficulty")]
		[REDProperty(IsIgnored = true)]
		public CInt32 ComparedDifficulty
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("comparisonType")]
		[REDProperty(IsIgnored = true)]
		public CName ComparisonType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
