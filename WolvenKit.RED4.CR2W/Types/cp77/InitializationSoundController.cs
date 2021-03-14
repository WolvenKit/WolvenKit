using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InitializationSoundController : inkWidgetLogicController
	{
		private CName _soundControlName;
		private CName _initializeSoundName;
		private CName _unitializeSoundName;

		[Ordinal(1)] 
		[RED("soundControlName")] 
		public CName SoundControlName
		{
			get
			{
				if (_soundControlName == null)
				{
					_soundControlName = (CName) CR2WTypeManager.Create("CName", "soundControlName", cr2w, this);
				}
				return _soundControlName;
			}
			set
			{
				if (_soundControlName == value)
				{
					return;
				}
				_soundControlName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("initializeSoundName")] 
		public CName InitializeSoundName
		{
			get
			{
				if (_initializeSoundName == null)
				{
					_initializeSoundName = (CName) CR2WTypeManager.Create("CName", "initializeSoundName", cr2w, this);
				}
				return _initializeSoundName;
			}
			set
			{
				if (_initializeSoundName == value)
				{
					return;
				}
				_initializeSoundName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("unitializeSoundName")] 
		public CName UnitializeSoundName
		{
			get
			{
				if (_unitializeSoundName == null)
				{
					_unitializeSoundName = (CName) CR2WTypeManager.Create("CName", "unitializeSoundName", cr2w, this);
				}
				return _unitializeSoundName;
			}
			set
			{
				if (_unitializeSoundName == value)
				{
					return;
				}
				_unitializeSoundName = value;
				PropertySet(this);
			}
		}

		public InitializationSoundController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
