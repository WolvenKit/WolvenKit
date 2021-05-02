using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionHelperTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _actionTweakIDMapping;
		private CString _actionStringName;
		private CBool _initialized;
		private CName _actionName;
		private TweakDBID _actionID;

		[Ordinal(0)] 
		[RED("actionTweakIDMapping")] 
		public CHandle<AIArgumentMapping> ActionTweakIDMapping
		{
			get => GetProperty(ref _actionTweakIDMapping);
			set => SetProperty(ref _actionTweakIDMapping, value);
		}

		[Ordinal(1)] 
		[RED("actionStringName")] 
		public CString ActionStringName
		{
			get => GetProperty(ref _actionStringName);
			set => SetProperty(ref _actionStringName, value);
		}

		[Ordinal(2)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		[Ordinal(3)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		[Ordinal(4)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get => GetProperty(ref _actionID);
			set => SetProperty(ref _actionID, value);
		}

		public AIActionHelperTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
