using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartHouseControllerPS : MasterControllerPS
	{
		private CArray<SPresetTimetableEntry> _timetable;
		private CHandle<SmartHousePreset> _activePreset;
		private CArray<CHandle<SmartHousePreset>> _availablePresets;
		private SmartHouseConfiguration _smartHouseCustomization;
		private CUInt32 _callbackID;

		[Ordinal(104)] 
		[RED("timetable")] 
		public CArray<SPresetTimetableEntry> Timetable
		{
			get
			{
				if (_timetable == null)
				{
					_timetable = (CArray<SPresetTimetableEntry>) CR2WTypeManager.Create("array:SPresetTimetableEntry", "timetable", cr2w, this);
				}
				return _timetable;
			}
			set
			{
				if (_timetable == value)
				{
					return;
				}
				_timetable = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("activePreset")] 
		public CHandle<SmartHousePreset> ActivePreset
		{
			get
			{
				if (_activePreset == null)
				{
					_activePreset = (CHandle<SmartHousePreset>) CR2WTypeManager.Create("handle:SmartHousePreset", "activePreset", cr2w, this);
				}
				return _activePreset;
			}
			set
			{
				if (_activePreset == value)
				{
					return;
				}
				_activePreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("availablePresets")] 
		public CArray<CHandle<SmartHousePreset>> AvailablePresets
		{
			get
			{
				if (_availablePresets == null)
				{
					_availablePresets = (CArray<CHandle<SmartHousePreset>>) CR2WTypeManager.Create("array:handle:SmartHousePreset", "availablePresets", cr2w, this);
				}
				return _availablePresets;
			}
			set
			{
				if (_availablePresets == value)
				{
					return;
				}
				_availablePresets = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("smartHouseCustomization")] 
		public SmartHouseConfiguration SmartHouseCustomization
		{
			get
			{
				if (_smartHouseCustomization == null)
				{
					_smartHouseCustomization = (SmartHouseConfiguration) CR2WTypeManager.Create("SmartHouseConfiguration", "smartHouseCustomization", cr2w, this);
				}
				return _smartHouseCustomization;
			}
			set
			{
				if (_smartHouseCustomization == value)
				{
					return;
				}
				_smartHouseCustomization = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get
			{
				if (_callbackID == null)
				{
					_callbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "callbackID", cr2w, this);
				}
				return _callbackID;
			}
			set
			{
				if (_callbackID == value)
				{
					return;
				}
				_callbackID = value;
				PropertySet(this);
			}
		}

		public SmartHouseControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
