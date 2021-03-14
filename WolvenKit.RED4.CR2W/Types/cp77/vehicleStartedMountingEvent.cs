using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleStartedMountingEvent : redEvent
	{
		private CName _slotID;
		private CBool _isMounting;
		private wCHandle<gameObject> _character;
		private CBool _instant;
		private CBool _silent;

		[Ordinal(0)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (CName) CR2WTypeManager.Create("CName", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isMounting")] 
		public CBool IsMounting
		{
			get
			{
				if (_isMounting == null)
				{
					_isMounting = (CBool) CR2WTypeManager.Create("Bool", "isMounting", cr2w, this);
				}
				return _isMounting;
			}
			set
			{
				if (_isMounting == value)
				{
					return;
				}
				_isMounting = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("character")] 
		public wCHandle<gameObject> Character
		{
			get
			{
				if (_character == null)
				{
					_character = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "character", cr2w, this);
				}
				return _character;
			}
			set
			{
				if (_character == value)
				{
					return;
				}
				_character = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("instant")] 
		public CBool Instant
		{
			get
			{
				if (_instant == null)
				{
					_instant = (CBool) CR2WTypeManager.Create("Bool", "instant", cr2w, this);
				}
				return _instant;
			}
			set
			{
				if (_instant == value)
				{
					return;
				}
				_instant = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("silent")] 
		public CBool Silent
		{
			get
			{
				if (_silent == null)
				{
					_silent = (CBool) CR2WTypeManager.Create("Bool", "silent", cr2w, this);
				}
				return _silent;
			}
			set
			{
				if (_silent == value)
				{
					return;
				}
				_silent = value;
				PropertySet(this);
			}
		}

		public vehicleStartedMountingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
