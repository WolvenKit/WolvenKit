using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldConversationData : ISerializable
	{
		private raRef<scnSceneResource> _sceneFilename;
		private CHandle<questIBaseCondition> _condition;
		private CArray<CHandle<scnIInterruptionOperation>> _interruptionOperations;
		private CBool _ignoreLocalLimit;
		private CBool _ignoreGlobalLimit;

		[Ordinal(0)] 
		[RED("sceneFilename")] 
		public raRef<scnSceneResource> SceneFilename
		{
			get => GetProperty(ref _sceneFilename);
			set => SetProperty(ref _sceneFilename, value);
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(2)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get => GetProperty(ref _interruptionOperations);
			set => SetProperty(ref _interruptionOperations, value);
		}

		[Ordinal(3)] 
		[RED("ignoreLocalLimit")] 
		public CBool IgnoreLocalLimit
		{
			get => GetProperty(ref _ignoreLocalLimit);
			set => SetProperty(ref _ignoreLocalLimit, value);
		}

		[Ordinal(4)] 
		[RED("ignoreGlobalLimit")] 
		public CBool IgnoreGlobalLimit
		{
			get => GetProperty(ref _ignoreGlobalLimit);
			set => SetProperty(ref _ignoreGlobalLimit, value);
		}

		public worldConversationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
