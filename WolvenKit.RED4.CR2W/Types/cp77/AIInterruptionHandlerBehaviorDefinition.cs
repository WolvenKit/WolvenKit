using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIInterruptionHandlerBehaviorDefinition : AIInterruptionHandlerDefinition
	{
		private CHandle<LibTreeINodeDefinition> _ai;
		private CBool _parallelActivation;
		private CBool _parallelExecution;
		private CBool _blockInterruption;

		[Ordinal(2)] 
		[RED("ai")] 
		public CHandle<LibTreeINodeDefinition> Ai
		{
			get
			{
				if (_ai == null)
				{
					_ai = (CHandle<LibTreeINodeDefinition>) CR2WTypeManager.Create("handle:LibTreeINodeDefinition", "ai", cr2w, this);
				}
				return _ai;
			}
			set
			{
				if (_ai == value)
				{
					return;
				}
				_ai = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("parallelActivation")] 
		public CBool ParallelActivation
		{
			get
			{
				if (_parallelActivation == null)
				{
					_parallelActivation = (CBool) CR2WTypeManager.Create("Bool", "parallelActivation", cr2w, this);
				}
				return _parallelActivation;
			}
			set
			{
				if (_parallelActivation == value)
				{
					return;
				}
				_parallelActivation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("parallelExecution")] 
		public CBool ParallelExecution
		{
			get
			{
				if (_parallelExecution == null)
				{
					_parallelExecution = (CBool) CR2WTypeManager.Create("Bool", "parallelExecution", cr2w, this);
				}
				return _parallelExecution;
			}
			set
			{
				if (_parallelExecution == value)
				{
					return;
				}
				_parallelExecution = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("blockInterruption")] 
		public CBool BlockInterruption
		{
			get
			{
				if (_blockInterruption == null)
				{
					_blockInterruption = (CBool) CR2WTypeManager.Create("Bool", "blockInterruption", cr2w, this);
				}
				return _blockInterruption;
			}
			set
			{
				if (_blockInterruption == value)
				{
					return;
				}
				_blockInterruption = value;
				PropertySet(this);
			}
		}

		public AIInterruptionHandlerBehaviorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
