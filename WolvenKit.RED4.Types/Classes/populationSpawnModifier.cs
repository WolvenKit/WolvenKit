using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class populationSpawnModifier : populationModifier
	{
		private CHandle<gameObjectSpawnParameter> _spawnParameter;

		[Ordinal(0)] 
		[RED("spawnParameter")] 
		public CHandle<gameObjectSpawnParameter> SpawnParameter
		{
			get => GetProperty(ref _spawnParameter);
			set => SetProperty(ref _spawnParameter, value);
		}
	}
}
