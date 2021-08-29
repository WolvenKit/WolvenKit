using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ArcadeMachineControllerPS : ScriptableDeviceComponentPS
	{
		private CArray<redResourceReferenceScriptToken> _gameVideosPaths;

		[Ordinal(104)] 
		[RED("gameVideosPaths")] 
		public CArray<redResourceReferenceScriptToken> GameVideosPaths
		{
			get => GetProperty(ref _gameVideosPaths);
			set => SetProperty(ref _gameVideosPaths, value);
		}
	}
}
