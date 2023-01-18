
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBroadcastStimEffector_Record
	{
        [RED("radius")]
		[REDProperty(IsIgnored = true)]
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
