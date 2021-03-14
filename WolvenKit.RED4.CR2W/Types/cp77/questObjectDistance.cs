using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questObjectDistance : questIDistance
	{
		private CBool _isPlayer;
		private gameEntityReference _nodeRef1;
		private gameEntityReference _nodeRef2;

		[Ordinal(0)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("nodeRef1")] 
		public gameEntityReference NodeRef1
		{
			get
			{
				if (_nodeRef1 == null)
				{
					_nodeRef1 = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "nodeRef1", cr2w, this);
				}
				return _nodeRef1;
			}
			set
			{
				if (_nodeRef1 == value)
				{
					return;
				}
				_nodeRef1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("nodeRef2")] 
		public gameEntityReference NodeRef2
		{
			get
			{
				if (_nodeRef2 == null)
				{
					_nodeRef2 = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "nodeRef2", cr2w, this);
				}
				return _nodeRef2;
			}
			set
			{
				if (_nodeRef2 == value)
				{
					return;
				}
				_nodeRef2 = value;
				PropertySet(this);
			}
		}

		public questObjectDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
