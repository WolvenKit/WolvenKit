
namespace WolvenKit.RED4.Types
{
	public partial class gamedataEffector_Record
	{
		[RED("effectorClassName")]
		[REDProperty(IsIgnored = true)]
		public CName EffectorClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("prereqRecord")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PrereqRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("removeAfterActionCall")]
		[REDProperty(IsIgnored = true)]
		public CBool RemoveAfterActionCall
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
		
		[RED("statPoolUpdates")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatPoolUpdates
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
