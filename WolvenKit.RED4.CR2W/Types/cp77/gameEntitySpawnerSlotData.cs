using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEntitySpawnerSlotData : CVariable
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

		public gameEntitySpawnerSlotData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
