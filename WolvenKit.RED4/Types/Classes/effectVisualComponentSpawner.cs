using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectVisualComponentSpawner : effectSpawner
	{
		[Ordinal(0)] 
		[RED("componentName")] 
		public CArray<CName> ComponentName
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public effectVisualComponentSpawner()
		{
			ComponentName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
