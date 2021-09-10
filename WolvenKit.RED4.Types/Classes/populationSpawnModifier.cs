using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class populationSpawnModifier : populationModifier
	{
		[Ordinal(0)] 
		[RED("spawnParameter")] 
		public CHandle<gameObjectSpawnParameter> SpawnParameter
		{
			get => GetPropertyValue<CHandle<gameObjectSpawnParameter>>();
			set => SetPropertyValue<CHandle<gameObjectSpawnParameter>>(value);
		}
	}
}
