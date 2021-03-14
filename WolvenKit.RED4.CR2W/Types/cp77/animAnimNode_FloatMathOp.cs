using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatMathOp : animAnimNode_FloatValue
	{
		private CEnum<animEAnimGraphMathOp> _operationType;
		private animFloatLink _firstInputNode;
		private animFloatLink _secondInputNode;

		[Ordinal(11)] 
		[RED("operationType")] 
		public CEnum<animEAnimGraphMathOp> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<animEAnimGraphMathOp>) CR2WTypeManager.Create("animEAnimGraphMathOp", "operationType", cr2w, this);
				}
				return _operationType;
			}
			set
			{
				if (_operationType == value)
				{
					return;
				}
				_operationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("firstInputNode")] 
		public animFloatLink FirstInputNode
		{
			get
			{
				if (_firstInputNode == null)
				{
					_firstInputNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "firstInputNode", cr2w, this);
				}
				return _firstInputNode;
			}
			set
			{
				if (_firstInputNode == value)
				{
					return;
				}
				_firstInputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("secondInputNode")] 
		public animFloatLink SecondInputNode
		{
			get
			{
				if (_secondInputNode == null)
				{
					_secondInputNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "secondInputNode", cr2w, this);
				}
				return _secondInputNode;
			}
			set
			{
				if (_secondInputNode == value)
				{
					return;
				}
				_secondInputNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FloatMathOp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
