using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameInventoryPS : gameComponentPS
	{
		private CBool _isRegisteredShared;
		private CBool _accessible;

		[Ordinal(0)] 
		[RED("isRegisteredShared")] 
		public CBool IsRegisteredShared
		{
			get
			{
				if (_isRegisteredShared == null)
				{
					_isRegisteredShared = (CBool) CR2WTypeManager.Create("Bool", "isRegisteredShared", cr2w, this);
				}
				return _isRegisteredShared;
			}
			set
			{
				if (_isRegisteredShared == value)
				{
					return;
				}
				_isRegisteredShared = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("accessible")] 
		public CBool Accessible
		{
			get
			{
				if (_accessible == null)
				{
					_accessible = (CBool) CR2WTypeManager.Create("Bool", "accessible", cr2w, this);
				}
				return _accessible;
			}
			set
			{
				if (_accessible == value)
				{
					return;
				}
				_accessible = value;
				PropertySet(this);
			}
		}

		public gameInventoryPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
