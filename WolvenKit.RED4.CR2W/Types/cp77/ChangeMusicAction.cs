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
			get => GetProperty(ref _interactionRecordName);
			set => SetProperty(ref _interactionRecordName, value);
		}

		[Ordinal(26)] 
		[RED("settings")] 
		public CHandle<MusicSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		public ChangeMusicAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
