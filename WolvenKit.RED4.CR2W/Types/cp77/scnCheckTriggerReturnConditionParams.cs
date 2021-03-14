using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckTriggerReturnConditionParams : CVariable
	{
		private CBool _inside;
		private NodeRef _triggerArea;

		[Ordinal(0)] 
		[RED("inside")] 
		public CBool Inside
		{
			get
			{
				if (_inside == null)
				{
					_inside = (CBool) CR2WTypeManager.Create("Bool", "inside", cr2w, this);
				}
				return _inside;
			}
			set
			{
				if (_inside == value)
				{
					return;
				}
				_inside = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("triggerArea")] 
		public NodeRef TriggerArea
		{
			get
			{
				if (_triggerArea == null)
				{
					_triggerArea = (NodeRef) CR2WTypeManager.Create("NodeRef", "triggerArea", cr2w, this);
				}
				return _triggerArea;
			}
			set
			{
				if (_triggerArea == value)
				{
					return;
				}
				_triggerArea = value;
				PropertySet(this);
			}
		}

		public scnCheckTriggerReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
