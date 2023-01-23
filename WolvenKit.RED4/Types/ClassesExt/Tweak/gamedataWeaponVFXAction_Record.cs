
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWeaponVFXAction_Record
	{
		[RED("fxAction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FxAction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("fxActionType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FxActionType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("fxName")]
		[REDProperty(IsIgnored = true)]
		public CName FxName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
