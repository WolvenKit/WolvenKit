using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameScriptableComponent : gameComponent
	{
		[Ordinal(4)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameScriptableComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
