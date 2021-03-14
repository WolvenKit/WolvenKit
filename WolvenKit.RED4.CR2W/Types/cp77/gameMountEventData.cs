using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMountEventData : IScriptable
	{
		private CName _slotName;
		private entEntityID _mountParentEntityId;
		private CBool _isInstant;
		private CName _entryAnimName;
		private Transform _initialTransformLS;
		private CBool _setEntityVisibleWhenMountFinish;
		private CBool _removePitchRollRotationOnDismount;
		private CBool _ignoreHLS;
		private CHandle<gameMountEventOptions> _mountEventOptions;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mountParentEntityId")] 
		public entEntityID MountParentEntityId
		{
			get
			{
				if (_mountParentEntityId == null)
				{
					_mountParentEntityId = (entEntityID) CR2WTypeManager.Create("entEntityID", "mountParentEntityId", cr2w, this);
				}
				return _mountParentEntityId;
			}
			set
			{
				if (_mountParentEntityId == value)
				{
					return;
				}
				_mountParentEntityId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get
			{
				if (_isInstant == null)
				{
					_isInstant = (CBool) CR2WTypeManager.Create("Bool", "isInstant", cr2w, this);
				}
				return _isInstant;
			}
			set
			{
				if (_isInstant == value)
				{
					return;
				}
				_isInstant = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entryAnimName")] 
		public CName EntryAnimName
		{
			get
			{
				if (_entryAnimName == null)
				{
					_entryAnimName = (CName) CR2WTypeManager.Create("CName", "entryAnimName", cr2w, this);
				}
				return _entryAnimName;
			}
			set
			{
				if (_entryAnimName == value)
				{
					return;
				}
				_entryAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("initialTransformLS")] 
		public Transform InitialTransformLS
		{
			get
			{
				if (_initialTransformLS == null)
				{
					_initialTransformLS = (Transform) CR2WTypeManager.Create("Transform", "initialTransformLS", cr2w, this);
				}
				return _initialTransformLS;
			}
			set
			{
				if (_initialTransformLS == value)
				{
					return;
				}
				_initialTransformLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("setEntityVisibleWhenMountFinish")] 
		public CBool SetEntityVisibleWhenMountFinish
		{
			get
			{
				if (_setEntityVisibleWhenMountFinish == null)
				{
					_setEntityVisibleWhenMountFinish = (CBool) CR2WTypeManager.Create("Bool", "setEntityVisibleWhenMountFinish", cr2w, this);
				}
				return _setEntityVisibleWhenMountFinish;
			}
			set
			{
				if (_setEntityVisibleWhenMountFinish == value)
				{
					return;
				}
				_setEntityVisibleWhenMountFinish = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("removePitchRollRotationOnDismount")] 
		public CBool RemovePitchRollRotationOnDismount
		{
			get
			{
				if (_removePitchRollRotationOnDismount == null)
				{
					_removePitchRollRotationOnDismount = (CBool) CR2WTypeManager.Create("Bool", "removePitchRollRotationOnDismount", cr2w, this);
				}
				return _removePitchRollRotationOnDismount;
			}
			set
			{
				if (_removePitchRollRotationOnDismount == value)
				{
					return;
				}
				_removePitchRollRotationOnDismount = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ignoreHLS")] 
		public CBool IgnoreHLS
		{
			get
			{
				if (_ignoreHLS == null)
				{
					_ignoreHLS = (CBool) CR2WTypeManager.Create("Bool", "ignoreHLS", cr2w, this);
				}
				return _ignoreHLS;
			}
			set
			{
				if (_ignoreHLS == value)
				{
					return;
				}
				_ignoreHLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("mountEventOptions")] 
		public CHandle<gameMountEventOptions> MountEventOptions
		{
			get
			{
				if (_mountEventOptions == null)
				{
					_mountEventOptions = (CHandle<gameMountEventOptions>) CR2WTypeManager.Create("handle:gameMountEventOptions", "mountEventOptions", cr2w, this);
				}
				return _mountEventOptions;
			}
			set
			{
				if (_mountEventOptions == value)
				{
					return;
				}
				_mountEventOptions = value;
				PropertySet(this);
			}
		}

		public gameMountEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
