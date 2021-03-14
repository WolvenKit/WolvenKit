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
			get
			{
				if (_path == null)
				{
					_path = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get
			{
				if (_patrolProgress == null)
				{
					_patrolProgress = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "patrolProgress", cr2w, this);
				}
				return _patrolProgress;
			}
			set
			{
				if (_patrolProgress == value)
				{
					return;
				}
				_patrolProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("positionOnPath")] 
		public CHandle<AIArgumentMapping> PositionOnPath
		{
			get
			{
				if (_positionOnPath == null)
				{
					_positionOnPath = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "positionOnPath", cr2w, this);
				}
				return _positionOnPath;
			}
			set
			{
				if (_positionOnPath == value)
				{
					return;
				}
				_positionOnPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("entryTangent")] 
		public CHandle<AIArgumentMapping> EntryTangent
		{
			get
			{
				if (_entryTangent == null)
				{
					_entryTangent = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "entryTangent", cr2w, this);
				}
				return _entryTangent;
			}
			set
			{
				if (_entryTangent == value)
				{
					return;
				}
				_entryTangent = value;
				PropertySet(this);
			}
		}

		public AIbehaviorFindClosestPointOnPathTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
