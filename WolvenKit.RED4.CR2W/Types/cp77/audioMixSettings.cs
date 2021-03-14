using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMixSettings : audioAudioMetadata
	{
		private CFloat _masterVolume;
		private CFloat _sfxVolume;
		private CFloat _musicVolume;
		private CFloat _voVolume;
		private CFloat _uiMenuVolume;
		private CName _onStartupEvent;

		[Ordinal(1)] 
		[RED("masterVolume")] 
		public CFloat MasterVolume
		{
			get
			{
				if (_masterVolume == null)
				{
					_masterVolume = (CFloat) CR2WTypeManager.Create("Float", "masterVolume", cr2w, this);
				}
				return _masterVolume;
			}
			set
			{
				if (_masterVolume == value)
				{
					return;
				}
				_masterVolume = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sfxVolume")] 
		public CFloat SfxVolume
		{
			get
			{
				if (_sfxVolume == null)
				{
					_sfxVolume = (CFloat) CR2WTypeManager.Create("Float", "sfxVolume", cr2w, this);
				}
				return _sfxVolume;
			}
			set
			{
				if (_sfxVolume == value)
				{
					return;
				}
				_sfxVolume = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("musicVolume")] 
		public CFloat MusicVolume
		{
			get
			{
				if (_musicVolume == null)
				{
					_musicVolume = (CFloat) CR2WTypeManager.Create("Float", "musicVolume", cr2w, this);
				}
				return _musicVolume;
			}
			set
			{
				if (_musicVolume == value)
				{
					return;
				}
				_musicVolume = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("voVolume")] 
		public CFloat VoVolume
		{
			get
			{
				if (_voVolume == null)
				{
					_voVolume = (CFloat) CR2WTypeManager.Create("Float", "voVolume", cr2w, this);
				}
				return _voVolume;
			}
			set
			{
				if (_voVolume == value)
				{
					return;
				}
				_voVolume = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("uiMenuVolume")] 
		public CFloat UiMenuVolume
		{
			get
			{
				if (_uiMenuVolume == null)
				{
					_uiMenuVolume = (CFloat) CR2WTypeManager.Create("Float", "uiMenuVolume", cr2w, this);
				}
				return _uiMenuVolume;
			}
			set
			{
				if (_uiMenuVolume == value)
				{
					return;
				}
				_uiMenuVolume = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("onStartupEvent")] 
		public CName OnStartupEvent
		{
			get
			{
				if (_onStartupEvent == null)
				{
					_onStartupEvent = (CName) CR2WTypeManager.Create("CName", "onStartupEvent", cr2w, this);
				}
				return _onStartupEvent;
			}
			set
			{
				if (_onStartupEvent == value)
				{
					return;
				}
				_onStartupEvent = value;
				PropertySet(this);
			}
		}

		public audioMixSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
