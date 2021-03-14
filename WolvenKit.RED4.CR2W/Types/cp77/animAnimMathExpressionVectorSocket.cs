using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimMathExpressionVectorSocket : CVariable
	{
		private animVectorLink _link;
		private CUInt16 _expressionVarId;

		[Ordinal(0)] 
		[RED("link")] 
		public animVectorLink Link
		{
			get
			{
				if (_link == null)
				{
					_link = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "link", cr2w, this);
				}
				return _link;
			}
			set
			{
				if (_link == value)
				{
					return;
				}
				_link = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("expressionVarId")] 
		public CUInt16 ExpressionVarId
		{
			get
			{
				if (_expressionVarId == null)
				{
					_expressionVarId = (CUInt16) CR2WTypeManager.Create("Uint16", "expressionVarId", cr2w, this);
				}
				return _expressionVarId;
			}
			set
			{
				if (_expressionVarId == value)
				{
					return;
				}
				_expressionVarId = value;
				PropertySet(this);
			}
		}

		public animAnimMathExpressionVectorSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
