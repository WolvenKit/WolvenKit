
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatPoolPrereq_Record
	{
		[RED("comparePercentage")]
		[REDProperty(IsIgnored = true)]
		public CBool ComparePercentage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("comparisonType")]
		[REDProperty(IsIgnored = true)]
		public CName ComparisonType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("listenConstantly")]
		[REDProperty(IsIgnored = true)]
		public CBool ListenConstantly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("objectToCheck")]
		[REDProperty(IsIgnored = true)]
		public CName ObjectToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("skipOnApply")]
		[REDProperty(IsIgnored = true)]
		public CBool SkipOnApply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("statPoolType")]
		[REDProperty(IsIgnored = true)]
		public CName StatPoolType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("valueToCheck")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ValueToCheck
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
