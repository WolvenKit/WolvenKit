using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameObjectSpawnParametersList : gameObjectSpawnParameter
	{
		[Ordinal(0)] 
		[RED("parameterList")] 
		public CArray<CHandle<gameObjectSpawnParameter>> ParameterList
		{
			get => GetPropertyValue<CArray<CHandle<gameObjectSpawnParameter>>>();
			set => SetPropertyValue<CArray<CHandle<gameObjectSpawnParameter>>>(value);
		}

		public gameObjectSpawnParametersList()
		{
			ParameterList = new();
		}
	}
}
