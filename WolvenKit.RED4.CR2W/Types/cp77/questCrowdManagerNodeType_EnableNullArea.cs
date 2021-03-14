using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCrowdManagerNodeType_EnableNullArea : questICrowdManager_NodeType
	{
		private NodeRef _areaReference;
		private CBool _enable;

		[Ordinal(0)] 
		[RED("areaReference")] 
		public NodeRef AreaReference
		{
			get
			{
				if (_areaReference == null)
				{
					_areaReference = (NodeRef) CR2WTypeManager.Create("NodeRef", "areaReference", cr2w, this);
				}
				return _areaReference;
			}
			set
			{
				if (_areaReference == value)
				{
					return;
				}
				_areaReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		public questCrowdManagerNodeType_EnableNullArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
