using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerRequirementsGameController : BaseChunkGameController
	{
		private inkCompoundWidgetReference _scannerRequirementsRightPanel;
		private CUInt32 _requirementsCallbackID;
		private CBool _isValidRequirements;
		private CArray<wCHandle<inkWidget>> _requirementWidgets;

		[Ordinal(5)] 
		[RED("ScannerRequirementsRightPanel")] 
		public inkCompoundWidgetReference ScannerRequirementsRightPanel
		{
			get => GetProperty(ref _scannerRequirementsRightPanel);
			set => SetProperty(ref _scannerRequirementsRightPanel, value);
		}

		[Ordinal(6)] 
		[RED("requirementsCallbackID")] 
		public CUInt32 RequirementsCallbackID
		{
			get => GetProperty(ref _requirementsCallbackID);
			set => SetProperty(ref _requirementsCallbackID, value);
		}

		[Ordinal(7)] 
		[RED("isValidRequirements")] 
		public CBool IsValidRequirements
		{
			get => GetProperty(ref _isValidRequirements);
			set => SetProperty(ref _isValidRequirements, value);
		}

		[Ordinal(8)] 
		[RED("requirementWidgets")] 
		public CArray<wCHandle<inkWidget>> RequirementWidgets
		{
			get => GetProperty(ref _requirementWidgets);
			set => SetProperty(ref _requirementWidgets, value);
		}

		public ScannerRequirementsGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
