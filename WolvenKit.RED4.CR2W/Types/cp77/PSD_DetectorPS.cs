using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSD_DetectorPS : gameDeviceComponentPS
	{
		private CInt32 _counter;
		private CBool _toggle;
		private entEntityID _lastEntityID;
		private gamePersistentID _lastPersistentID;
		private CName _name;

		[Ordinal(12)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get
			{
				if (_counter == null)
				{
					_counter = (CInt32) CR2WTypeManager.Create("Int32", "counter", cr2w, this);
				}
				return _counter;
			}
			set
			{
				if (_counter == value)
				{
					return;
				}
				_counter = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get
			{
				if (_toggle == null)
				{
					_toggle = (CBool) CR2WTypeManager.Create("Bool", "toggle", cr2w, this);
				}
				return _toggle;
			}
			set
			{
				if (_toggle == value)
				{
					return;
				}
				_toggle = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("lastEntityID")] 
		public entEntityID LastEntityID
		{
			get
			{
				if (_lastEntityID == null)
				{
					_lastEntityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "lastEntityID", cr2w, this);
				}
				return _lastEntityID;
			}
			set
			{
				if (_lastEntityID == value)
				{
					return;
				}
				_lastEntityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("lastPersistentID")] 
		public gamePersistentID LastPersistentID
		{
			get
			{
				if (_lastPersistentID == null)
				{
					_lastPersistentID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "lastPersistentID", cr2w, this);
				}
				return _lastPersistentID;
			}
			set
			{
				if (_lastPersistentID == value)
				{
					return;
				}
				_lastPersistentID = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		public PSD_DetectorPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
