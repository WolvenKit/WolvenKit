using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RuntimeSwitch : animAnimNode_Base
	{
		private CHandle<animIRuntimeCondition> _condition;
		private animPoseLink _true;
		private animPoseLink _false;

		[Ordinal(11)] 
		[RED("condition")] 
		public CHandle<animIRuntimeCondition> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CHandle<animIRuntimeCondition>) CR2WTypeManager.Create("handle:animIRuntimeCondition", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("True")] 
		public animPoseLink True
		{
			get
			{
				if (_true == null)
				{
					_true = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "True", cr2w, this);
				}
				return _true;
			}
			set
			{
				if (_true == value)
				{
					return;
				}
				_true = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("False")] 
		public animPoseLink False
		{
			get
			{
				if (_false == null)
				{
					_false = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "False", cr2w, this);
				}
				return _false;
			}
			set
			{
				if (_false == value)
				{
					return;
				}
				_false = value;
				PropertySet(this);
			}
		}

		public animAnimNode_RuntimeSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
