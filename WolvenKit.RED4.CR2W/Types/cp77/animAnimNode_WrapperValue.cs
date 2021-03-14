using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_WrapperValue : animAnimNode_FloatValue
	{
		private CArray<CName> _wrapperNames;
		private CEnum<animEAnimGraphLogicOp> _logicOp;
		private CBool _oneMinus;

		[Ordinal(11)] 
		[RED("wrapperNames")] 
		public CArray<CName> WrapperNames
		{
			get
			{
				if (_wrapperNames == null)
				{
					_wrapperNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "wrapperNames", cr2w, this);
				}
				return _wrapperNames;
			}
			set
			{
				if (_wrapperNames == value)
				{
					return;
				}
				_wrapperNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("logicOp")] 
		public CEnum<animEAnimGraphLogicOp> LogicOp
		{
			get
			{
				if (_logicOp == null)
				{
					_logicOp = (CEnum<animEAnimGraphLogicOp>) CR2WTypeManager.Create("animEAnimGraphLogicOp", "logicOp", cr2w, this);
				}
				return _logicOp;
			}
			set
			{
				if (_logicOp == value)
				{
					return;
				}
				_logicOp = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("oneMinus")] 
		public CBool OneMinus
		{
			get
			{
				if (_oneMinus == null)
				{
					_oneMinus = (CBool) CR2WTypeManager.Create("Bool", "oneMinus", cr2w, this);
				}
				return _oneMinus;
			}
			set
			{
				if (_oneMinus == value)
				{
					return;
				}
				_oneMinus = value;
				PropertySet(this);
			}
		}

		public animAnimNode_WrapperValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
