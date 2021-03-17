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
			get => GetProperty(ref _scenarioName);
			set => SetProperty(ref _scenarioName, value);
		}

		[Ordinal(1)] 
		[RED("openVendorPanel")] 
		public CBool OpenVendorPanel
		{
			get => GetProperty(ref _openVendorPanel);
			set => SetProperty(ref _openVendorPanel, value);
		}

		[Ordinal(2)] 
		[RED("vendorId")] 
		public CString VendorId
		{
			get => GetProperty(ref _vendorId);
			set => SetProperty(ref _vendorId, value);
		}

		[Ordinal(3)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(4)] 
		[RED("assetsLibrary")] 
		public CString AssetsLibrary
		{
			get => GetProperty(ref _assetsLibrary);
			set => SetProperty(ref _assetsLibrary, value);
		}

		[Ordinal(5)] 
		[RED("rootItemName")] 
		public CName RootItemName
		{
			get => GetProperty(ref _rootItemName);
			set => SetProperty(ref _rootItemName, value);
		}

		public questVendorPanel_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
