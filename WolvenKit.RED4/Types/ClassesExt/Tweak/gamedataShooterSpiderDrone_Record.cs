
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterSpiderDrone_Record
	{
		[RED("attackDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("attackSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
