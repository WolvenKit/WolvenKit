using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVulnerabilitiesGameController : BaseChunkGameController
	{
		private inkCompoundWidgetReference _scannerVulnerabilitiesRightPanel;
		private CUInt32 _vulnerabilitiesCallbackID;
		private CBool _isValidVulnerabilities;
		private CArray<wCHandle<inkWidget>> _vulnerabilityWidgets;

		[Ordinal(5)] 
		[RED("ScannerVulnerabilitiesRightPanel")] 
		public inkCompoundWidgetReference ScannerVulnerabilitiesRightPanel
		{
			get
			{
				if (_scannerVulnerabilitiesRightPanel == null)
				{
					_scannerVulnerabilitiesRightPanel = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ScannerVulnerabilitiesRightPanel", cr2w, this);
				}
				return _scannerVulnerabilitiesRightPanel;
			}
			set
			{
				if (_scannerVulnerabilitiesRightPanel == value)
				{
					return;
				}
				_scannerVulnerabilitiesRightPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("vulnerabilitiesCallbackID")] 
		public CUInt32 VulnerabilitiesCallbackID
		{
			get
			{
				if (_vulnerabilitiesCallbackID == null)
				{
					_vulnerabilitiesCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "vulnerabilitiesCallbackID", cr2w, this);
				}
				return _vulnerabilitiesCallbackID;
			}
			set
			{
				if (_vulnerabilitiesCallbackID == value)
				{
					return;
				}
				_vulnerabilitiesCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isValidVulnerabilities")] 
		public CBool IsValidVulnerabilities
		{
			get
			{
				if (_isValidVulnerabilities == null)
				{
					_isValidVulnerabilities = (CBool) CR2WTypeManager.Create("Bool", "isValidVulnerabilities", cr2w, this);
				}
				return _isValidVulnerabilities;
			}
			set
			{
				if (_isValidVulnerabilities == value)
				{
					return;
				}
				_isValidVulnerabilities = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("vulnerabilityWidgets")] 
		public CArray<wCHandle<inkWidget>> VulnerabilityWidgets
		{
			get
			{
				if (_vulnerabilityWidgets == null)
				{
					_vulnerabilityWidgets = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "vulnerabilityWidgets", cr2w, this);
				}
				return _vulnerabilityWidgets;
			}
			set
			{
				if (_vulnerabilityWidgets == value)
				{
					return;
				}
				_vulnerabilityWidgets = value;
				PropertySet(this);
			}
		}

		public ScannerVulnerabilitiesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
