
namespace WolvenKit.RED4.Types
{
	public partial class gamedataModifyStatPoolModifierEffector_Record
	{
		[RED("modificationType")]
		[REDProperty(IsIgnored = true)]
		public CString ModificationType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("poolModifier")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PoolModifier
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("statPoolType")]
		[REDProperty(IsIgnored = true)]
		public CString StatPoolType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
