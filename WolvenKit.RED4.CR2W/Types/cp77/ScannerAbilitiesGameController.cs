using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerAbilitiesGameController : BaseChunkGameController
	{
		private inkCompoundWidgetReference _scannerAbilitiesRightPanel;
		private CUInt32 _abilitiesCallbackID;
		private CBool _isValidAbilities;
		private CArray<wCHandle<inkWidget>> _abilityWidgets;

		[Ordinal(5)] 
		[RED("ScannerAbilitiesRightPanel")] 
		public inkCompoundWidgetReference ScannerAbilitiesRightPanel
		{
			get
			{
				if (_scannerAbilitiesRightPanel == null)
				{
					_scannerAbilitiesRightPanel = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ScannerAbilitiesRightPanel", cr2w, this);
				}
				return _scannerAbilitiesRightPanel;
			}
			set
			{
				if (_scannerAbilitiesRightPanel == value)
				{
					return;
				}
				_scannerAbilitiesRightPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("abilitiesCallbackID")] 
		public CUInt32 AbilitiesCallbackID
		{
			get
			{
				if (_abilitiesCallbackID == null)
				{
					_abilitiesCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "abilitiesCallbackID", cr2w, this);
				}
				return _abilitiesCallbackID;
			}
			set
			{
				if (_abilitiesCallbackID == value)
				{
					return;
				}
				_abilitiesCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isValidAbilities")] 
		public CBool IsValidAbilities
		{
			get
			{
				if (_isValidAbilities == null)
				{
					_isValidAbilities = (CBool) CR2WTypeManager.Create("Bool", "isValidAbilities", cr2w, this);
				}
				return _isValidAbilities;
			}
			set
			{
				if (_isValidAbilities == value)
				{
					return;
				}
				_isValidAbilities = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("abilityWidgets")] 
		public CArray<wCHandle<inkWidget>> AbilityWidgets
		{
			get
			{
				if (_abilityWidgets == null)
				{
					_abilityWidgets = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "abilityWidgets", cr2w, this);
				}
				return _abilityWidgets;
			}
			set
			{
				if (_abilityWidgets == value)
				{
					return;
				}
				_abilityWidgets = value;
				PropertySet(this);
			}
		}

		public ScannerAbilitiesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
