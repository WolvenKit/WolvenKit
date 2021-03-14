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
			get
			{
				if (_scannerRequirementsRightPanel == null)
				{
					_scannerRequirementsRightPanel = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ScannerRequirementsRightPanel", cr2w, this);
				}
				return _scannerRequirementsRightPanel;
			}
			set
			{
				if (_scannerRequirementsRightPanel == value)
				{
					return;
				}
				_scannerRequirementsRightPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("requirementsCallbackID")] 
		public CUInt32 RequirementsCallbackID
		{
			get
			{
				if (_requirementsCallbackID == null)
				{
					_requirementsCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "requirementsCallbackID", cr2w, this);
				}
				return _requirementsCallbackID;
			}
			set
			{
				if (_requirementsCallbackID == value)
				{
					return;
				}
				_requirementsCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isValidRequirements")] 
		public CBool IsValidRequirements
		{
			get
			{
				if (_isValidRequirements == null)
				{
					_isValidRequirements = (CBool) CR2WTypeManager.Create("Bool", "isValidRequirements", cr2w, this);
				}
				return _isValidRequirements;
			}
			set
			{
				if (_isValidRequirements == value)
				{
					return;
				}
				_isValidRequirements = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("requirementWidgets")] 
		public CArray<wCHandle<inkWidget>> RequirementWidgets
		{
			get
			{
				if (_requirementWidgets == null)
				{
					_requirementWidgets = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "requirementWidgets", cr2w, this);
				}
				return _requirementWidgets;
			}
			set
			{
				if (_requirementWidgets == value)
				{
					return;
				}
				_requirementWidgets = value;
				PropertySet(this);
			}
		}

		public ScannerRequirementsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
