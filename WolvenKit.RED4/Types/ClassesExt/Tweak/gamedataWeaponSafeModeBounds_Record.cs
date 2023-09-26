
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWeaponSafeModeBounds_Record
	{
		[RED("backBound")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BackBound
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("enableSafeModeBounds")]
		[REDProperty(IsIgnored = true)]
		public CBool EnableSafeModeBounds
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("windshieldBound")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID WindshieldBound
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
