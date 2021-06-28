using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpawnComponent : entIPlacedComponent
	{
		private Vector3 _spawnOffset;
		private CArray<CName> _projectileTemplates;
		private CName _slotName;

		[Ordinal(5)] 
		[RED("spawnOffset")] 
		public Vector3 SpawnOffset
		{
			get => GetProperty(ref _spawnOffset);
			set => SetProperty(ref _spawnOffset, value);
		}

		[Ordinal(6)] 
		[RED("projectileTemplates")] 
		public CArray<CName> ProjectileTemplates
		{
			get => GetProperty(ref _projectileTemplates);
			set => SetProperty(ref _projectileTemplates, value);
		}

		[Ordinal(7)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		public gameprojectileSpawnComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
