using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNodeStatusDebuggerCommandEntry : CVariable
	{
		private CGUID _nodeId;
		private CEnum<AIbehaviorDebugNodeStatus> _status;
		private CUInt32 _generation;
		private CHandle<gamedebugFailure> _failure;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public CGUID NodeId
		{
			get
			{
				if (_nodeId == null)
				{
					_nodeId = (CGUID) CR2WTypeManager.Create("CGUID", "nodeId", cr2w, this);
				}
				return _nodeId;
			}
			set
			{
				if (_nodeId == value)
				{
					return;
				}
				_nodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<AIbehaviorDebugNodeStatus> Status
		{
			get
			{
				if (_status == null)
				{
					_status = (CEnum<AIbehaviorDebugNodeStatus>) CR2WTypeManager.Create("AIbehaviorDebugNodeStatus", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("generation")] 
		public CUInt32 Generation
		{
			get
			{
				if (_generation == null)
				{
					_generation = (CUInt32) CR2WTypeManager.Create("Uint32", "generation", cr2w, this);
				}
				return _generation;
			}
			set
			{
				if (_generation == value)
				{
					return;
				}
				_generation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("failure")] 
		public CHandle<gamedebugFailure> Failure
		{
			get
			{
				if (_failure == null)
				{
					_failure = (CHandle<gamedebugFailure>) CR2WTypeManager.Create("handle:gamedebugFailure", "failure", cr2w, this);
				}
				return _failure;
			}
			set
			{
				if (_failure == value)
				{
					return;
				}
				_failure = value;
				PropertySet(this);
			}
		}

		public AIbehaviorNodeStatusDebuggerCommandEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
