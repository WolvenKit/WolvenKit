
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBaseObject_Record
	{
		[RED("effectors")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Effectors
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("objectActions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ObjectActions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("savable")]
		[REDProperty(IsIgnored = true)]
		public CBool Savable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("statModifierGroups")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatModifierGroups
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
		
		[RED("statPools")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatPools
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("weakspots")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Weakspots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
