using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpeakerSetup : CVariable
	{
		private CEnum<ERadioStationList> _defaultMusic;
		private CEnum<ERadioStationList> _distractionMusic;
		private CFloat _range;
		private CName _glitchSFX;
		private CBool _useOnlyGlitchSFX;

		[Ordinal(0)] 
		[RED("defaultMusic")] 
		public CEnum<ERadioStationList> DefaultMusic
		{
			get
			{
				if (_defaultMusic == null)
				{
					_defaultMusic = (CEnum<ERadioStationList>) CR2WTypeManager.Create("ERadioStationList", "defaultMusic", cr2w, this);
				}
				return _defaultMusic;
			}
			set
			{
				if (_defaultMusic == value)
				{
					return;
				}
				_defaultMusic = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("distractionMusic")] 
		public CEnum<ERadioStationList> DistractionMusic
		{
			get
			{
				if (_distractionMusic == null)
				{
					_distractionMusic = (CEnum<ERadioStationList>) CR2WTypeManager.Create("ERadioStationList", "distractionMusic", cr2w, this);
				}
				return _distractionMusic;
			}
			set
			{
				if (_distractionMusic == value)
				{
					return;
				}
				_distractionMusic = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("range")] 
		public CFloat Range
		{
			get
			{
				if (_range == null)
				{
					_range = (CFloat) CR2WTypeManager.Create("Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get
			{
				if (_glitchSFX == null)
				{
					_glitchSFX = (CName) CR2WTypeManager.Create("CName", "glitchSFX", cr2w, this);
				}
				return _glitchSFX;
			}
			set
			{
				if (_glitchSFX == value)
				{
					return;
				}
				_glitchSFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useOnlyGlitchSFX")] 
		public CBool UseOnlyGlitchSFX
		{
			get
			{
				if (_useOnlyGlitchSFX == null)
				{
					_useOnlyGlitchSFX = (CBool) CR2WTypeManager.Create("Bool", "useOnlyGlitchSFX", cr2w, this);
				}
				return _useOnlyGlitchSFX;
			}
			set
			{
				if (_useOnlyGlitchSFX == value)
				{
					return;
				}
				_useOnlyGlitchSFX = value;
				PropertySet(this);
			}
		}

		public SpeakerSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
