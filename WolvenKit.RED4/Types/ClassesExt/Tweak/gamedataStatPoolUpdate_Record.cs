
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatPoolUpdate_Record
	{
		[RED("statModifiers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatModifiers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statPoolType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatPoolType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("statPoolValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat StatPoolValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
