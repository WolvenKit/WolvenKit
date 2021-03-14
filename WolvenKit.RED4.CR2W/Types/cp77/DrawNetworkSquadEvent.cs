using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DrawNetworkSquadEvent : redEvent
	{
		private CBool _shouldDraw;
		private gamePersistentID _memberID;
		private gameFxResource _fxResource;
		private CBool _isPing;
		private CBool _revealMaster;
		private CBool _revealSlave;
		private CBool _memberOnly;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("shouldDraw")] 
		public CBool ShouldDraw
		{
			get
			{
				if (_shouldDraw == null)
				{
					_shouldDraw = (CBool) CR2WTypeManager.Create("Bool", "shouldDraw", cr2w, this);
				}
				return _shouldDraw;
			}
			set
			{
				if (_shouldDraw == value)
				{
					return;
				}
				_shouldDraw = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("memberID")] 
		public gamePersistentID MemberID
		{
			get
			{
				if (_memberID == null)
				{
					_memberID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "memberID", cr2w, this);
				}
				return _memberID;
			}
			set
			{
				if (_memberID == value)
				{
					return;
				}
				_memberID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get
			{
				if (_fxResource == null)
				{
					_fxResource = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "fxResource", cr2w, this);
				}
				return _fxResource;
			}
			set
			{
				if (_fxResource == value)
				{
					return;
				}
				_fxResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isPing")] 
		public CBool IsPing
		{
			get
			{
				if (_isPing == null)
				{
					_isPing = (CBool) CR2WTypeManager.Create("Bool", "isPing", cr2w, this);
				}
				return _isPing;
			}
			set
			{
				if (_isPing == value)
				{
					return;
				}
				_isPing = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get
			{
				if (_revealMaster == null)
				{
					_revealMaster = (CBool) CR2WTypeManager.Create("Bool", "revealMaster", cr2w, this);
				}
				return _revealMaster;
			}
			set
			{
				if (_revealMaster == value)
				{
					return;
				}
				_revealMaster = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get
			{
				if (_revealSlave == null)
				{
					_revealSlave = (CBool) CR2WTypeManager.Create("Bool", "revealSlave", cr2w, this);
				}
				return _revealSlave;
			}
			set
			{
				if (_revealSlave == value)
				{
					return;
				}
				_revealSlave = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("memberOnly")] 
		public CBool MemberOnly
		{
			get
			{
				if (_memberOnly == null)
				{
					_memberOnly = (CBool) CR2WTypeManager.Create("Bool", "memberOnly", cr2w, this);
				}
				return _memberOnly;
			}
			set
			{
				if (_memberOnly == value)
				{
					return;
				}
				_memberOnly = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		public DrawNetworkSquadEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
