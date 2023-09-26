
namespace WolvenKit.RED4.Types
{
	public partial class gamedataArcadeSpawnableObject_Record
	{
		[RED("object")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Object
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("probability")]
		[REDProperty(IsIgnored = true)]
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
