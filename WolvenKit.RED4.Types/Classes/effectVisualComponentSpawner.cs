using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectVisualComponentSpawner : effectSpawner
	{
		private CArray<CName> _componentName;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CArray<CName> ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}
	}
}
