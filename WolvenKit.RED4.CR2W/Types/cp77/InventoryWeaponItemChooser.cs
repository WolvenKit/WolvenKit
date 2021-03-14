using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponItemChooser : InventoryGenericItemChooser
	{
		private inkCompoundWidgetReference _scopeRootContainer;
		private inkCompoundWidgetReference _magazineRootContainer;
		private inkCompoundWidgetReference _silencerRootContainer;
		private inkCompoundWidgetReference _scopeContainer;
		private inkCompoundWidgetReference _magazineContainer;
		private inkCompoundWidgetReference _silencerContainer;
		private inkTextWidgetReference _attachmentsLabel;
		private inkWidgetReference _attachmentsContainer;
		private inkTextWidgetReference _softwareModsLabel;
		private inkWidgetReference _softwareModsPush;
		private inkWidgetReference _softwareModsContainer;

		[Ordinal(13)] 
		[RED("scopeRootContainer")] 
		public inkCompoundWidgetReference ScopeRootContainer
		{
			get
			{
				if (_scopeRootContainer == null)
				{
					_scopeRootContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "scopeRootContainer", cr2w, this);
				}
				return _scopeRootContainer;
			}
			set
			{
				if (_scopeRootContainer == value)
				{
					return;
				}
				_scopeRootContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("magazineRootContainer")] 
		public inkCompoundWidgetReference MagazineRootContainer
		{
			get
			{
				if (_magazineRootContainer == null)
				{
					_magazineRootContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "magazineRootContainer", cr2w, this);
				}
				return _magazineRootContainer;
			}
			set
			{
				if (_magazineRootContainer == value)
				{
					return;
				}
				_magazineRootContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("silencerRootContainer")] 
		public inkCompoundWidgetReference SilencerRootContainer
		{
			get
			{
				if (_silencerRootContainer == null)
				{
					_silencerRootContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "silencerRootContainer", cr2w, this);
				}
				return _silencerRootContainer;
			}
			set
			{
				if (_silencerRootContainer == value)
				{
					return;
				}
				_silencerRootContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("scopeContainer")] 
		public inkCompoundWidgetReference ScopeContainer
		{
			get
			{
				if (_scopeContainer == null)
				{
					_scopeContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "scopeContainer", cr2w, this);
				}
				return _scopeContainer;
			}
			set
			{
				if (_scopeContainer == value)
				{
					return;
				}
				_scopeContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("magazineContainer")] 
		public inkCompoundWidgetReference MagazineContainer
		{
			get
			{
				if (_magazineContainer == null)
				{
					_magazineContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "magazineContainer", cr2w, this);
				}
				return _magazineContainer;
			}
			set
			{
				if (_magazineContainer == value)
				{
					return;
				}
				_magazineContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("silencerContainer")] 
		public inkCompoundWidgetReference SilencerContainer
		{
			get
			{
				if (_silencerContainer == null)
				{
					_silencerContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "silencerContainer", cr2w, this);
				}
				return _silencerContainer;
			}
			set
			{
				if (_silencerContainer == value)
				{
					return;
				}
				_silencerContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("attachmentsLabel")] 
		public inkTextWidgetReference AttachmentsLabel
		{
			get
			{
				if (_attachmentsLabel == null)
				{
					_attachmentsLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attachmentsLabel", cr2w, this);
				}
				return _attachmentsLabel;
			}
			set
			{
				if (_attachmentsLabel == value)
				{
					return;
				}
				_attachmentsLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("attachmentsContainer")] 
		public inkWidgetReference AttachmentsContainer
		{
			get
			{
				if (_attachmentsContainer == null)
				{
					_attachmentsContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attachmentsContainer", cr2w, this);
				}
				return _attachmentsContainer;
			}
			set
			{
				if (_attachmentsContainer == value)
				{
					return;
				}
				_attachmentsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("softwareModsLabel")] 
		public inkTextWidgetReference SoftwareModsLabel
		{
			get
			{
				if (_softwareModsLabel == null)
				{
					_softwareModsLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "softwareModsLabel", cr2w, this);
				}
				return _softwareModsLabel;
			}
			set
			{
				if (_softwareModsLabel == value)
				{
					return;
				}
				_softwareModsLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("softwareModsPush")] 
		public inkWidgetReference SoftwareModsPush
		{
			get
			{
				if (_softwareModsPush == null)
				{
					_softwareModsPush = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "softwareModsPush", cr2w, this);
				}
				return _softwareModsPush;
			}
			set
			{
				if (_softwareModsPush == value)
				{
					return;
				}
				_softwareModsPush = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("softwareModsContainer")] 
		public inkWidgetReference SoftwareModsContainer
		{
			get
			{
				if (_softwareModsContainer == null)
				{
					_softwareModsContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "softwareModsContainer", cr2w, this);
				}
				return _softwareModsContainer;
			}
			set
			{
				if (_softwareModsContainer == value)
				{
					return;
				}
				_softwareModsContainer = value;
				PropertySet(this);
			}
		}

		public InventoryWeaponItemChooser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
