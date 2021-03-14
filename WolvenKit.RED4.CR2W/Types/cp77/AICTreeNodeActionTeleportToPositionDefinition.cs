using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionTeleportToPositionDefinition : AICTreeNodeActionDefinition
	{
		private CName _positionName;
		private CBool _doNavTest;

		[Ordinal(1)] 
		[RED("positionName")] 
		public CName PositionName
		{
			get
			{
				if (_positionName == null)
				{
					_positionName = (CName) CR2WTypeManager.Create("CName", "positionName", cr2w, this);
				}
				return _positionName;
			}
			set
			{
				if (_positionName == value)
				{
					return;
				}
				_positionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get
			{
				if (_doNavTest == null)
				{
					_doNavTest = (CBool) CR2WTypeManager.Create("Bool", "doNavTest", cr2w, this);
				}
				return _doNavTest;
			}
			set
			{
				if (_doNavTest == value)
				{
					return;
				}
				_doNavTest = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeActionTeleportToPositionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
