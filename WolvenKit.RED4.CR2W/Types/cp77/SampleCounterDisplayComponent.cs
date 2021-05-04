using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleCounterDisplayComponent : gameScriptableComponent
	{
		private gamePersistentID _targetPersistentID;

		[Ordinal(5)] 
		[RED("targetPersistentID")] 
		public gamePersistentID TargetPersistentID
		{
			get => GetProperty(ref _targetPersistentID);
			set => SetProperty(ref _targetPersistentID, value);
		}

		public SampleCounterDisplayComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
