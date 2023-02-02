
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStat_Record
	{
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
		
		[RED("substats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Substats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
