using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDeleteInputGroupEvent : redEvent
	{
		private CName _groupId;
		private CName _targetHintContainer;

		[Ordinal(0)] 
		[RED("groupId")] 
		public CName GroupId
		{
			get
			{
				if (_groupId == null)
				{
					_groupId = (CName) CR2WTypeManager.Create("CName", "groupId", cr2w, this);
				}
				return _groupId;
			}
			set
			{
				if (_groupId == value)
				{
					return;
				}
				_groupId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetHintContainer")] 
		public CName TargetHintContainer
		{
			get
			{
				if (_targetHintContainer == null)
				{
					_targetHintContainer = (CName) CR2WTypeManager.Create("CName", "targetHintContainer", cr2w, this);
				}
				return _targetHintContainer;
			}
			set
			{
				if (_targetHintContainer == value)
				{
					return;
				}
				_targetHintContainer = value;
				PropertySet(this);
			}
		}

		public gameuiDeleteInputGroupEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
