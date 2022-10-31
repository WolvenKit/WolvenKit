
namespace WolvenKit.RED4.Types
{
	public partial class gamedataContinuousEffector_Record
	{
		[RED("delayTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat DelayTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("timeDilationDriver")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TimeDilationDriver
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
