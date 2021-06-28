using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MineDispenserPlaceEvents : MineDispenserEventsTransition
	{
		private Vector4 _spawnPosition;
		private Vector4 _spawnNormal;

		[Ordinal(0)] 
		[RED("spawnPosition")] 
		public Vector4 SpawnPosition
		{
			get => GetProperty(ref _spawnPosition);
			set => SetProperty(ref _spawnPosition, value);
		}

		[Ordinal(1)] 
		[RED("spawnNormal")] 
		public Vector4 SpawnNormal
		{
			get => GetProperty(ref _spawnNormal);
			set => SetProperty(ref _spawnNormal, value);
		}

		public MineDispenserPlaceEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
