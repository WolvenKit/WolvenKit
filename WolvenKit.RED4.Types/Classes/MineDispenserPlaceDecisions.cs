using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MineDispenserPlaceDecisions : MineDispenserTransition
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
	}
}
