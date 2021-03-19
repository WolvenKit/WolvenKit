using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindClosestPointOnPathTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _path;
		private CHandle<AIArgumentMapping> _patrolProgress;
		private CHandle<AIArgumentMapping> _positionOnPath;
		private CHandle<AIArgumentMapping> _entryTangent;

		[Ordinal(1)] 
		[RED("path")] 
		public CHandle<AIArgumentMapping> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(2)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get => GetProperty(ref _patrolProgress);
			set => SetProperty(ref _patrolProgress, value);
		}

		[Ordinal(3)] 
		[RED("positionOnPath")] 
		public CHandle<AIArgumentMapping> PositionOnPath
		{
			get => GetProperty(ref _positionOnPath);
			set => SetProperty(ref _positionOnPath, value);
		}

		[Ordinal(4)] 
		[RED("entryTangent")] 
		public CHandle<AIArgumentMapping> EntryTangent
		{
			get => GetProperty(ref _entryTangent);
			set => SetProperty(ref _entryTangent, value);
		}

		public AIbehaviorFindClosestPointOnPathTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
