using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cpPlayerDetectorPS : gameObjectPS
	{
		[Ordinal(0)] 
		[RED("secondsCounter")] 
		public CInt32 SecondsCounter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public cpPlayerDetectorPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
