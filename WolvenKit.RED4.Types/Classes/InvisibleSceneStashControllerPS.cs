using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InvisibleSceneStashControllerPS : ScriptableDeviceComponentPS
	{
		private CArray<gameItemID> _storedItems;

		[Ordinal(104)] 
		[RED("storedItems")] 
		public CArray<gameItemID> StoredItems
		{
			get => GetProperty(ref _storedItems);
			set => SetProperty(ref _storedItems, value);
		}
	}
}
