
namespace WolvenKit.RED4.Types
{
	public partial class gamedataContinuousAttackEffector_Record
	{
		[RED("delayTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat DelayTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
