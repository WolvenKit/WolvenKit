using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SceneScreen : gameObject
	{
		private CHandle<SceneScreenUIAnimationsData> _uiAnimationsData;
		private CHandle<gameIBlackboard> _blackboard;

		[Ordinal(40)] 
		[RED("uiAnimationsData")] 
		public CHandle<SceneScreenUIAnimationsData> UiAnimationsData
		{
			get => GetProperty(ref _uiAnimationsData);
			set => SetProperty(ref _uiAnimationsData, value);
		}

		[Ordinal(41)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		public SceneScreen(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
