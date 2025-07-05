
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSetAttackHitTypeEffector_Record
	{
		[RED("hitType")]
		[REDProperty(IsIgnored = true)]
		public CName HitType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
