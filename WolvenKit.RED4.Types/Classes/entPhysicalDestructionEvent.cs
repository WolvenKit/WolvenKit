using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entPhysicalDestructionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("levelOfDestruction")] 
		public CUInt8 LevelOfDestruction
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public entPhysicalDestructionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
