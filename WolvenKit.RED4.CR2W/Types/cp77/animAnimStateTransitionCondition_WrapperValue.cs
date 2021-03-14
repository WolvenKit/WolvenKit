using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_WrapperValue : animIAnimStateTransitionCondition
	{
		private CName _wrapperName;
		private CBool _checkIfWrapperIsSet;

		[Ordinal(0)] 
		[RED("wrapperName")] 
		public CName WrapperName
		{
			get
			{
				if (_wrapperName == null)
				{
					_wrapperName = (CName) CR2WTypeManager.Create("CName", "wrapperName", cr2w, this);
				}
				return _wrapperName;
			}
			set
			{
				if (_wrapperName == value)
				{
					return;
				}
				_wrapperName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("checkIfWrapperIsSet")] 
		public CBool CheckIfWrapperIsSet
		{
			get
			{
				if (_checkIfWrapperIsSet == null)
				{
					_checkIfWrapperIsSet = (CBool) CR2WTypeManager.Create("Bool", "checkIfWrapperIsSet", cr2w, this);
				}
				return _checkIfWrapperIsSet;
			}
			set
			{
				if (_checkIfWrapperIsSet == value)
				{
					return;
				}
				_checkIfWrapperIsSet = value;
				PropertySet(this);
			}
		}

		public animAnimStateTransitionCondition_WrapperValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
