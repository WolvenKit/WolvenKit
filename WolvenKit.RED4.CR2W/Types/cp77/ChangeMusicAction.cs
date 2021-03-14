using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeMusicAction : ActionBool
	{
		private CString _interactionRecordName;
		private CHandle<MusicSettings> _settings;

		[Ordinal(25)] 
		[RED("interactionRecordName")] 
		public CString InteractionRecordName
		{
			get
			{
				if (_interactionRecordName == null)
				{
					_interactionRecordName = (CString) CR2WTypeManager.Create("String", "interactionRecordName", cr2w, this);
				}
				return _interactionRecordName;
			}
			set
			{
				if (_interactionRecordName == value)
				{
					return;
				}
				_interactionRecordName = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("settings")] 
		public CHandle<MusicSettings> Settings
		{
			get
			{
				if (_settings == null)
				{
					_settings = (CHandle<MusicSettings>) CR2WTypeManager.Create("handle:MusicSettings", "settings", cr2w, this);
				}
				return _settings;
			}
			set
			{
				if (_settings == value)
				{
					return;
				}
				_settings = value;
				PropertySet(this);
			}
		}

		public ChangeMusicAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
