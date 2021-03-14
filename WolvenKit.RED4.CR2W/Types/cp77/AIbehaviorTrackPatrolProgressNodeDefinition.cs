using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTrackPatrolProgressNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _pathParameters;
		private CHandle<AIArgumentMapping> _patrolProgress;
		private CHandle<AIArgumentMapping> _startFromClosestPoint;

		[Ordinal(1)] 
		[RED("pathParameters")] 
		public CHandle<AIArgumentMapping> PathParameters
		{
			get
			{
				if (_pathParameters == null)
				{
					_pathParameters = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "pathParameters", cr2w, this);
				}
				return _pathParameters;
			}
			set
			{
				if (_pathParameters == value)
				{
					return;
				}
				_pathParameters = value;
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
		[RED("startFromClosestPoint")] 
		public CHandle<AIArgumentMapping> StartFromClosestPoint
		{
			get
			{
				if (_startFromClosestPoint == null)
				{
					_startFromClosestPoint = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "startFromClosestPoint", cr2w, this);
				}
				return _startFromClosestPoint;
			}
			set
			{
				if (_startFromClosestPoint == value)
				{
					return;
				}
				_startFromClosestPoint = value;
				PropertySet(this);
			}
		}

		public AIbehaviorTrackPatrolProgressNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
