
namespace WolvenKit.RED4.Types
{
	public partial class gamedataApplyEffectorEffector_Record
	{
		[RED("effectorToApply")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EffectorToApply
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
