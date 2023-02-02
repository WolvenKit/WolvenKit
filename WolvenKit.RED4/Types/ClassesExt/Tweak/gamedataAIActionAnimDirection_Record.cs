
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionAnimDirection_Record
	{
		[RED("directionAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat DirectionAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
