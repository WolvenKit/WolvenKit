
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStat_Record
	{
		[RED("displayPlus")]
		[REDProperty(IsIgnored = true)]
		public CBool DisplayPlus
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("enumComment")]
		[REDProperty(IsIgnored = true)]
		public CString EnumComment
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CString EnumName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("flags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Flags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("improvementRelation")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ImprovementRelation
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("inMeters")]
		[REDProperty(IsIgnored = true)]
		public CBool InMeters
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("inSeconds")]
		[REDProperty(IsIgnored = true)]
		public CBool InSeconds
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("inSpeed")]
		[REDProperty(IsIgnored = true)]
		public CBool InSpeed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CBool IsMultiplier
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isPercentage")]
		[REDProperty(IsIgnored = true)]
		public CBool IsPercentage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("localizedDescription")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("localizedName")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("localizedStatDisplay")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedStatDisplay
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("max")]
		[REDProperty(IsIgnored = true)]
		public CFloat Max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("min")]
		[REDProperty(IsIgnored = true)]
		public CFloat Min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("multByHundred")]
		[REDProperty(IsIgnored = true)]
		public CBool MultByHundred
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("roundValue")]
		[REDProperty(IsIgnored = true)]
		public CBool RoundValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("shouldFlipNegativeValue")]
		[REDProperty(IsIgnored = true)]
		public CBool ShouldFlipNegativeValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("substats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Substats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
