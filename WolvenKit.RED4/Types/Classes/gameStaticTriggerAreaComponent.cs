using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStaticTriggerAreaComponent : gameStaticAreaShapeComponent
	{
		[Ordinal(8)] 
		[RED("includeMask")] 
		public CUInt32 IncludeMask
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("excludeMask")] 
		public CUInt32 ExcludeMask
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameStaticTriggerAreaComponent()
		{
			IncludeMask = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
