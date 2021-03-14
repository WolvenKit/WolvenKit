using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVendorPanel_NodeType : questIUIManagerNodeType
	{
		private CName _scenarioName;
		private CBool _openVendorPanel;
		private CString _vendorId;
		private gameEntityReference _objectRef;
		private CString _assetsLibrary;
		private CName _rootItemName;

		[Ordinal(0)] 
		[RED("scenarioName")] 
		public CName ScenarioName
		{
			get
			{
				if (_scenarioName == null)
				{
					_scenarioName = (CName) CR2WTypeManager.Create("CName", "scenarioName", cr2w, this);
				}
				return _scenarioName;
			}
			set
			{
				if (_scenarioName == value)
				{
					return;
				}
				_scenarioName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("openVendorPanel")] 
		public CBool OpenVendorPanel
		{
			get
			{
				if (_openVendorPanel == null)
				{
					_openVendorPanel = (CBool) CR2WTypeManager.Create("Bool", "openVendorPanel", cr2w, this);
				}
				return _openVendorPanel;
			}
			set
			{
				if (_openVendorPanel == value)
				{
					return;
				}
				_openVendorPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("vendorId")] 
		public CString VendorId
		{
			get
			{
				if (_vendorId == null)
				{
					_vendorId = (CString) CR2WTypeManager.Create("String", "vendorId", cr2w, this);
				}
				return _vendorId;
			}
			set
			{
				if (_vendorId == value)
				{
					return;
				}
				_vendorId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("assetsLibrary")] 
		public CString AssetsLibrary
		{
			get
			{
				if (_assetsLibrary == null)
				{
					_assetsLibrary = (CString) CR2WTypeManager.Create("String", "assetsLibrary", cr2w, this);
				}
				return _assetsLibrary;
			}
			set
			{
				if (_assetsLibrary == value)
				{
					return;
				}
				_assetsLibrary = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rootItemName")] 
		public CName RootItemName
		{
			get
			{
				if (_rootItemName == null)
				{
					_rootItemName = (CName) CR2WTypeManager.Create("CName", "rootItemName", cr2w, this);
				}
				return _rootItemName;
			}
			set
			{
				if (_rootItemName == value)
				{
					return;
				}
				_rootItemName = value;
				PropertySet(this);
			}
		}

		public questVendorPanel_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
