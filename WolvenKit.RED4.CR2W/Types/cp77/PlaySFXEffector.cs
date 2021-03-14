using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlaySFXEffector : gameEffector
	{
		private CName _activationSFXName;
		private CName _deactivationSFXName;
		private CBool _startOnUninitialize;
		private CBool _unique;
		private CBool _fireAndForget;
		private CBool _stopActiveSfxOnDeactivate;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("activationSFXName")] 
		public CName ActivationSFXName
		{
			get
			{
				if (_activationSFXName == null)
				{
					_activationSFXName = (CName) CR2WTypeManager.Create("CName", "activationSFXName", cr2w, this);
				}
				return _activationSFXName;
			}
			set
			{
				if (_activationSFXName == value)
				{
					return;
				}
				_activationSFXName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("deactivationSFXName")] 
		public CName DeactivationSFXName
		{
			get
			{
				if (_deactivationSFXName == null)
				{
					_deactivationSFXName = (CName) CR2WTypeManager.Create("CName", "deactivationSFXName", cr2w, this);
				}
				return _deactivationSFXName;
			}
			set
			{
				if (_deactivationSFXName == value)
				{
					return;
				}
				_deactivationSFXName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startOnUninitialize")] 
		public CBool StartOnUninitialize
		{
			get
			{
				if (_startOnUninitialize == null)
				{
					_startOnUninitialize = (CBool) CR2WTypeManager.Create("Bool", "startOnUninitialize", cr2w, this);
				}
				return _startOnUninitialize;
			}
			set
			{
				if (_startOnUninitialize == value)
				{
					return;
				}
				_startOnUninitialize = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("unique")] 
		public CBool Unique
		{
			get
			{
				if (_unique == null)
				{
					_unique = (CBool) CR2WTypeManager.Create("Bool", "unique", cr2w, this);
				}
				return _unique;
			}
			set
			{
				if (_unique == value)
				{
					return;
				}
				_unique = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("fireAndForget")] 
		public CBool FireAndForget
		{
			get
			{
				if (_fireAndForget == null)
				{
					_fireAndForget = (CBool) CR2WTypeManager.Create("Bool", "fireAndForget", cr2w, this);
				}
				return _fireAndForget;
			}
			set
			{
				if (_fireAndForget == value)
				{
					return;
				}
				_fireAndForget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("stopActiveSfxOnDeactivate")] 
		public CBool StopActiveSfxOnDeactivate
		{
			get
			{
				if (_stopActiveSfxOnDeactivate == null)
				{
					_stopActiveSfxOnDeactivate = (CBool) CR2WTypeManager.Create("Bool", "stopActiveSfxOnDeactivate", cr2w, this);
				}
				return _stopActiveSfxOnDeactivate;
			}
			set
			{
				if (_stopActiveSfxOnDeactivate == value)
				{
					return;
				}
				_stopActiveSfxOnDeactivate = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public PlaySFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
