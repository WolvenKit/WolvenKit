
namespace WolvenKit.RED4.Types
{
	public partial class gamedataReactionPreset_Record
	{
		[RED("aggressiveThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat AggressiveThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
		public CName EnumName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("fearThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat FearThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("isAggressive")]
		[REDProperty(IsIgnored = true)]
		public CBool IsAggressive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("presetMapper")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PresetMapper
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("reactionGroup")]
		[REDProperty(IsIgnored = true)]
		public CString ReactionGroup
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("rules")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Rules
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statModifiers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatModifiers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
