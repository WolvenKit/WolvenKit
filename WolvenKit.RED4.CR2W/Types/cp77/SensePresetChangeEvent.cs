using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SensePresetChangeEvent : senseVisibilityEvent
	{
		private TweakDBID _presetID;
		private CBool _mainPreset;
		private CBool _reset;

		[Ordinal(4)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get
			{
				if (_presetID == null)
				{
					_presetID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "presetID", cr2w, this);
				}
				return _presetID;
			}
			set
			{
				if (_presetID == value)
				{
					return;
				}
				_presetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("mainPreset")] 
		public CBool MainPreset
		{
			get
			{
				if (_mainPreset == null)
				{
					_mainPreset = (CBool) CR2WTypeManager.Create("Bool", "mainPreset", cr2w, this);
				}
				return _mainPreset;
			}
			set
			{
				if (_mainPreset == value)
				{
					return;
				}
				_mainPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("reset")] 
		public CBool Reset
		{
			get
			{
				if (_reset == null)
				{
					_reset = (CBool) CR2WTypeManager.Create("Bool", "reset", cr2w, this);
				}
				return _reset;
			}
			set
			{
				if (_reset == value)
				{
					return;
				}
				_reset = value;
				PropertySet(this);
			}
		}

		public SensePresetChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
