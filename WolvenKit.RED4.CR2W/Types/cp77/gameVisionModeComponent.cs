using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeComponent : gameComponent
	{
		private CArray<gameVisionModuleParams> _availableVisionModes;
		private CHandle<HighlightEditableData> _defaultHighlightData;
		private CArray<CHandle<FocusForcedHighlightData>> _forcedHighlights;
		private CHandle<FocusForcedHighlightData> _activeForcedHighlight;
		private CHandle<FocusForcedHighlightData> _currentDefaultHighlight;
		private CArray<gameVisionModeSystemRevealIdentifier> _activeRevealRequests;
		private CBool _isFocusModeActive;
		private CBool _wasCleanedUp;

		[Ordinal(4)] 
		[RED("availableVisionModes")] 
		public CArray<gameVisionModuleParams> AvailableVisionModes
		{
			get
			{
				if (_availableVisionModes == null)
				{
					_availableVisionModes = (CArray<gameVisionModuleParams>) CR2WTypeManager.Create("array:gameVisionModuleParams", "availableVisionModes", cr2w, this);
				}
				return _availableVisionModes;
			}
			set
			{
				if (_availableVisionModes == value)
				{
					return;
				}
				_availableVisionModes = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("defaultHighlightData")] 
		public CHandle<HighlightEditableData> DefaultHighlightData
		{
			get
			{
				if (_defaultHighlightData == null)
				{
					_defaultHighlightData = (CHandle<HighlightEditableData>) CR2WTypeManager.Create("handle:HighlightEditableData", "defaultHighlightData", cr2w, this);
				}
				return _defaultHighlightData;
			}
			set
			{
				if (_defaultHighlightData == value)
				{
					return;
				}
				_defaultHighlightData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("forcedHighlights")] 
		public CArray<CHandle<FocusForcedHighlightData>> ForcedHighlights
		{
			get
			{
				if (_forcedHighlights == null)
				{
					_forcedHighlights = (CArray<CHandle<FocusForcedHighlightData>>) CR2WTypeManager.Create("array:handle:FocusForcedHighlightData", "forcedHighlights", cr2w, this);
				}
				return _forcedHighlights;
			}
			set
			{
				if (_forcedHighlights == value)
				{
					return;
				}
				_forcedHighlights = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("activeForcedHighlight")] 
		public CHandle<FocusForcedHighlightData> ActiveForcedHighlight
		{
			get
			{
				if (_activeForcedHighlight == null)
				{
					_activeForcedHighlight = (CHandle<FocusForcedHighlightData>) CR2WTypeManager.Create("handle:FocusForcedHighlightData", "activeForcedHighlight", cr2w, this);
				}
				return _activeForcedHighlight;
			}
			set
			{
				if (_activeForcedHighlight == value)
				{
					return;
				}
				_activeForcedHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("currentDefaultHighlight")] 
		public CHandle<FocusForcedHighlightData> CurrentDefaultHighlight
		{
			get
			{
				if (_currentDefaultHighlight == null)
				{
					_currentDefaultHighlight = (CHandle<FocusForcedHighlightData>) CR2WTypeManager.Create("handle:FocusForcedHighlightData", "currentDefaultHighlight", cr2w, this);
				}
				return _currentDefaultHighlight;
			}
			set
			{
				if (_currentDefaultHighlight == value)
				{
					return;
				}
				_currentDefaultHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("activeRevealRequests")] 
		public CArray<gameVisionModeSystemRevealIdentifier> ActiveRevealRequests
		{
			get
			{
				if (_activeRevealRequests == null)
				{
					_activeRevealRequests = (CArray<gameVisionModeSystemRevealIdentifier>) CR2WTypeManager.Create("array:gameVisionModeSystemRevealIdentifier", "activeRevealRequests", cr2w, this);
				}
				return _activeRevealRequests;
			}
			set
			{
				if (_activeRevealRequests == value)
				{
					return;
				}
				_activeRevealRequests = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isFocusModeActive")] 
		public CBool IsFocusModeActive
		{
			get
			{
				if (_isFocusModeActive == null)
				{
					_isFocusModeActive = (CBool) CR2WTypeManager.Create("Bool", "isFocusModeActive", cr2w, this);
				}
				return _isFocusModeActive;
			}
			set
			{
				if (_isFocusModeActive == value)
				{
					return;
				}
				_isFocusModeActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("wasCleanedUp")] 
		public CBool WasCleanedUp
		{
			get
			{
				if (_wasCleanedUp == null)
				{
					_wasCleanedUp = (CBool) CR2WTypeManager.Create("Bool", "wasCleanedUp", cr2w, this);
				}
				return _wasCleanedUp;
			}
			set
			{
				if (_wasCleanedUp == value)
				{
					return;
				}
				_wasCleanedUp = value;
				PropertySet(this);
			}
		}

		public gameVisionModeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
