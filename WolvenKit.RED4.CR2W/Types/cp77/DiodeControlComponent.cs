using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DiodeControlComponent : gameScriptableComponent
	{
		private CArray<CName> _affectedLights;
		private CBool _lightsState;
		private DiodeLightPreset _primaryLightPreset;
		private DiodeLightPreset _secondaryLightPreset;
		private CBool _secondaryPresetActive;
		private gameDelayID _secondaryPresetRemovalID;

		[Ordinal(5)] 
		[RED("affectedLights")] 
		public CArray<CName> AffectedLights
		{
			get
			{
				if (_affectedLights == null)
				{
					_affectedLights = (CArray<CName>) CR2WTypeManager.Create("array:CName", "affectedLights", cr2w, this);
				}
				return _affectedLights;
			}
			set
			{
				if (_affectedLights == value)
				{
					return;
				}
				_affectedLights = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("lightsState")] 
		public CBool LightsState
		{
			get
			{
				if (_lightsState == null)
				{
					_lightsState = (CBool) CR2WTypeManager.Create("Bool", "lightsState", cr2w, this);
				}
				return _lightsState;
			}
			set
			{
				if (_lightsState == value)
				{
					return;
				}
				_lightsState = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("primaryLightPreset")] 
		public DiodeLightPreset PrimaryLightPreset
		{
			get
			{
				if (_primaryLightPreset == null)
				{
					_primaryLightPreset = (DiodeLightPreset) CR2WTypeManager.Create("DiodeLightPreset", "primaryLightPreset", cr2w, this);
				}
				return _primaryLightPreset;
			}
			set
			{
				if (_primaryLightPreset == value)
				{
					return;
				}
				_primaryLightPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("secondaryLightPreset")] 
		public DiodeLightPreset SecondaryLightPreset
		{
			get
			{
				if (_secondaryLightPreset == null)
				{
					_secondaryLightPreset = (DiodeLightPreset) CR2WTypeManager.Create("DiodeLightPreset", "secondaryLightPreset", cr2w, this);
				}
				return _secondaryLightPreset;
			}
			set
			{
				if (_secondaryLightPreset == value)
				{
					return;
				}
				_secondaryLightPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("secondaryPresetActive")] 
		public CBool SecondaryPresetActive
		{
			get
			{
				if (_secondaryPresetActive == null)
				{
					_secondaryPresetActive = (CBool) CR2WTypeManager.Create("Bool", "secondaryPresetActive", cr2w, this);
				}
				return _secondaryPresetActive;
			}
			set
			{
				if (_secondaryPresetActive == value)
				{
					return;
				}
				_secondaryPresetActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("secondaryPresetRemovalID")] 
		public gameDelayID SecondaryPresetRemovalID
		{
			get
			{
				if (_secondaryPresetRemovalID == null)
				{
					_secondaryPresetRemovalID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "secondaryPresetRemovalID", cr2w, this);
				}
				return _secondaryPresetRemovalID;
			}
			set
			{
				if (_secondaryPresetRemovalID == value)
				{
					return;
				}
				_secondaryPresetRemovalID = value;
				PropertySet(this);
			}
		}

		public DiodeControlComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
