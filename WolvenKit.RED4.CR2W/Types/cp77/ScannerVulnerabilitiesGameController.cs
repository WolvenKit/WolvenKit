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
			get => GetProperty(ref _scannerVulnerabilitiesRightPanel);
			set => SetProperty(ref _scannerVulnerabilitiesRightPanel, value);
		}

		[Ordinal(6)] 
		[RED("vulnerabilitiesCallbackID")] 
		public CUInt32 VulnerabilitiesCallbackID
		{
			get => GetProperty(ref _vulnerabilitiesCallbackID);
			set => SetProperty(ref _vulnerabilitiesCallbackID, value);
		}

		[Ordinal(7)] 
		[RED("isValidVulnerabilities")] 
		public CBool IsValidVulnerabilities
		{
			get => GetProperty(ref _isValidVulnerabilities);
			set => SetProperty(ref _isValidVulnerabilities, value);
		}

		[Ordinal(8)] 
		[RED("vulnerabilityWidgets")] 
		public CArray<wCHandle<inkWidget>> VulnerabilityWidgets
		{
			get => GetProperty(ref _vulnerabilityWidgets);
			set => SetProperty(ref _vulnerabilityWidgets, value);
		}

		public ScannerVulnerabilitiesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
