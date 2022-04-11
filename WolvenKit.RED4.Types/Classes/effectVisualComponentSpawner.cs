using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
