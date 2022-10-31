
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTriggerAttackEffector_Record
	{
		[RED("attackRecord")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttackRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
