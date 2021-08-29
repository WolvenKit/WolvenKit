using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameObjectSpawnParametersList : gameObjectSpawnParameter
	{
		private CArray<CHandle<gameObjectSpawnParameter>> _parameterList;

		[Ordinal(0)] 
		[RED("parameterList")] 
		public CArray<CHandle<gameObjectSpawnParameter>> ParameterList
		{
			get => GetProperty(ref _parameterList);
			set => SetProperty(ref _parameterList, value);
		}
	}
}
