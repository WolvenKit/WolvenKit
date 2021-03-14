using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameExtendedWorkspotInfo : IScriptable
	{
		private CBool _isActive;
		private CBool _entering;
		private CBool _exiting;
		private CBool _playingSyncAnim;
		private CBool _inReaction;
		private CBool _inMotion;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entering")] 
		public CBool Entering
		{
			get
			{
				if (_entering == null)
				{
					_entering = (CBool) CR2WTypeManager.Create("Bool", "entering", cr2w, this);
				}
				return _entering;
			}
			set
			{
				if (_entering == value)
				{
					return;
				}
				_entering = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("exiting")] 
		public CBool Exiting
		{
			get
			{
				if (_exiting == null)
				{
					_exiting = (CBool) CR2WTypeManager.Create("Bool", "exiting", cr2w, this);
				}
				return _exiting;
			}
			set
			{
				if (_exiting == value)
				{
					return;
				}
				_exiting = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("playingSyncAnim")] 
		public CBool PlayingSyncAnim
		{
			get
			{
				if (_playingSyncAnim == null)
				{
					_playingSyncAnim = (CBool) CR2WTypeManager.Create("Bool", "playingSyncAnim", cr2w, this);
				}
				return _playingSyncAnim;
			}
			set
			{
				if (_playingSyncAnim == value)
				{
					return;
				}
				_playingSyncAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("inReaction")] 
		public CBool InReaction
		{
			get
			{
				if (_inReaction == null)
				{
					_inReaction = (CBool) CR2WTypeManager.Create("Bool", "inReaction", cr2w, this);
				}
				return _inReaction;
			}
			set
			{
				if (_inReaction == value)
				{
					return;
				}
				_inReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("inMotion")] 
		public CBool InMotion
		{
			get
			{
				if (_inMotion == null)
				{
					_inMotion = (CBool) CR2WTypeManager.Create("Bool", "inMotion", cr2w, this);
				}
				return _inMotion;
			}
			set
			{
				if (_inMotion == value)
				{
					return;
				}
				_inMotion = value;
				PropertySet(this);
			}
		}

		public gameExtendedWorkspotInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
