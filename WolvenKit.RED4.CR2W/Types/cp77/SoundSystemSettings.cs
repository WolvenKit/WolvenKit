using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SoundSystemSettings : CVariable
	{
		private TweakDBID _interactionName;
		private CHandle<MusicSettings> _musicSettings;
		private CBool _canBeUsedAsQuickHack;

		[Ordinal(0)] 
		[RED("interactionName")] 
		public TweakDBID InteractionName
		{
			get
			{
				if (_interactionName == null)
				{
					_interactionName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "interactionName", cr2w, this);
				}
				return _interactionName;
			}
			set
			{
				if (_interactionName == value)
				{
					return;
				}
				_interactionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("musicSettings")] 
		public CHandle<MusicSettings> MusicSettings
		{
			get
			{
				if (_musicSettings == null)
				{
					_musicSettings = (CHandle<MusicSettings>) CR2WTypeManager.Create("handle:MusicSettings", "musicSettings", cr2w, this);
				}
				return _musicSettings;
			}
			set
			{
				if (_musicSettings == value)
				{
					return;
				}
				_musicSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("canBeUsedAsQuickHack")] 
		public CBool CanBeUsedAsQuickHack
		{
			get
			{
				if (_canBeUsedAsQuickHack == null)
				{
					_canBeUsedAsQuickHack = (CBool) CR2WTypeManager.Create("Bool", "canBeUsedAsQuickHack", cr2w, this);
				}
				return _canBeUsedAsQuickHack;
			}
			set
			{
				if (_canBeUsedAsQuickHack == value)
				{
					return;
				}
				_canBeUsedAsQuickHack = value;
				PropertySet(this);
			}
		}

		public SoundSystemSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
