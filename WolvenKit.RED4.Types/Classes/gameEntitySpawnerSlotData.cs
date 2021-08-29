using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntitySpawnerSlotData : RedBaseClass
	{
		private CName _slotName;
		private TweakDBID _spawnableObject;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("spawnableObject")] 
		public TweakDBID SpawnableObject
		{
			get => GetProperty(ref _spawnableObject);
			set => SetProperty(ref _spawnableObject, value);
		}
	}
}
