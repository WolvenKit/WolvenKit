using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTransformAnimatorNode_Action_Skip : questTransformAnimatorNode_ActionType
	{
		private CFloat _skipTo;
		private CBool _skipToEnd;

		[Ordinal(0)] 
		[RED("skipTo")] 
		public CFloat SkipTo
		{
			get
			{
				if (_skipTo == null)
				{
					_skipTo = (CFloat) CR2WTypeManager.Create("Float", "skipTo", cr2w, this);
				}
				return _skipTo;
			}
			set
			{
				if (_skipTo == value)
				{
					return;
				}
				_skipTo = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("skipToEnd")] 
		public CBool SkipToEnd
		{
			get
			{
				if (_skipToEnd == null)
				{
					_skipToEnd = (CBool) CR2WTypeManager.Create("Bool", "skipToEnd", cr2w, this);
				}
				return _skipToEnd;
			}
			set
			{
				if (_skipToEnd == value)
				{
					return;
				}
				_skipToEnd = value;
				PropertySet(this);
			}
		}

		public questTransformAnimatorNode_Action_Skip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
