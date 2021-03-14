using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioSecurityTurretMetadata : audioCustomEmitterMetadata
	{
		private CName _singleFire;
		private CName _activated;
		private CName _deactivaed;
		private CName _destroyed;
		private CName _idleStart;
		private CName _idleStop;
		private CBool _obstructionEnabled;
		private CBool _occlusionEnabled;

		[Ordinal(1)] 
		[RED("singleFire")] 
		public CName SingleFire
		{
			get
			{
				if (_singleFire == null)
				{
					_singleFire = (CName) CR2WTypeManager.Create("CName", "singleFire", cr2w, this);
				}
				return _singleFire;
			}
			set
			{
				if (_singleFire == value)
				{
					return;
				}
				_singleFire = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("activated")] 
		public CName Activated
		{
			get
			{
				if (_activated == null)
				{
					_activated = (CName) CR2WTypeManager.Create("CName", "activated", cr2w, this);
				}
				return _activated;
			}
			set
			{
				if (_activated == value)
				{
					return;
				}
				_activated = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("deactivaed")] 
		public CName Deactivaed
		{
			get
			{
				if (_deactivaed == null)
				{
					_deactivaed = (CName) CR2WTypeManager.Create("CName", "deactivaed", cr2w, this);
				}
				return _deactivaed;
			}
			set
			{
				if (_deactivaed == value)
				{
					return;
				}
				_deactivaed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("destroyed")] 
		public CName Destroyed
		{
			get
			{
				if (_destroyed == null)
				{
					_destroyed = (CName) CR2WTypeManager.Create("CName", "destroyed", cr2w, this);
				}
				return _destroyed;
			}
			set
			{
				if (_destroyed == value)
				{
					return;
				}
				_destroyed = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("idleStart")] 
		public CName IdleStart
		{
			get
			{
				if (_idleStart == null)
				{
					_idleStart = (CName) CR2WTypeManager.Create("CName", "idleStart", cr2w, this);
				}
				return _idleStart;
			}
			set
			{
				if (_idleStart == value)
				{
					return;
				}
				_idleStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("idleStop")] 
		public CName IdleStop
		{
			get
			{
				if (_idleStop == null)
				{
					_idleStop = (CName) CR2WTypeManager.Create("CName", "idleStop", cr2w, this);
				}
				return _idleStop;
			}
			set
			{
				if (_idleStop == value)
				{
					return;
				}
				_idleStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("obstructionEnabled")] 
		public CBool ObstructionEnabled
		{
			get
			{
				if (_obstructionEnabled == null)
				{
					_obstructionEnabled = (CBool) CR2WTypeManager.Create("Bool", "obstructionEnabled", cr2w, this);
				}
				return _obstructionEnabled;
			}
			set
			{
				if (_obstructionEnabled == value)
				{
					return;
				}
				_obstructionEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get
			{
				if (_occlusionEnabled == null)
				{
					_occlusionEnabled = (CBool) CR2WTypeManager.Create("Bool", "occlusionEnabled", cr2w, this);
				}
				return _occlusionEnabled;
			}
			set
			{
				if (_occlusionEnabled == value)
				{
					return;
				}
				_occlusionEnabled = value;
				PropertySet(this);
			}
		}

		public audioSecurityTurretMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
