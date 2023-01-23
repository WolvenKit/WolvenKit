
namespace WolvenKit.RED4.Types
{
	public partial class gamedataContinuousAttackEffector_Record
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
