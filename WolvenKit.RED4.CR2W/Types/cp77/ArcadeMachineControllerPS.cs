using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArcadeMachineControllerPS : ScriptableDeviceComponentPS
	{
		private CArray<redResourceReferenceScriptToken> _gameVideosPaths;

		[Ordinal(104)] 
		[RED("gameVideosPaths")] 
		public CArray<redResourceReferenceScriptToken> GameVideosPaths
		{
			get => GetProperty(ref _gameVideosPaths);
			set => SetProperty(ref _gameVideosPaths, value);
		}

		public ArcadeMachineControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
