
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIPatternDelay_Record
	{
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("shotNumber")]
		[REDProperty(IsIgnored = true)]
		public CInt32 ShotNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
