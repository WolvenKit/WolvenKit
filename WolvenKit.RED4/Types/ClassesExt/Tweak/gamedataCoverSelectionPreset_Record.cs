
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCoverSelectionPreset_Record
	{
		[RED("combatRing")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CombatRing
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("dismissedCoverTimer")]
		[REDProperty(IsIgnored = true)]
		public CFloat DismissedCoverTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("filtering")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> Filtering
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("gatherRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat GatherRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("postFiltering")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> PostFiltering
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("scoring")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> Scoring
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("usesLineOfSight")]
		[REDProperty(IsIgnored = true)]
		public CBool UsesLineOfSight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
