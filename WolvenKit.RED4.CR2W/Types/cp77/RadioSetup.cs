using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioSetup : CVariable
	{
		private CEnum<ERadioStationList> _startingStation;
		private CBool _isInteractive;
		private CName _glitchSFX;

		[Ordinal(0)] 
		[RED("startingStation")] 
		public CEnum<ERadioStationList> StartingStation
		{
			get
			{
				if (_startingStation == null)
				{
					_startingStation = (CEnum<ERadioStationList>) CR2WTypeManager.Create("ERadioStationList", "startingStation", cr2w, this);
				}
				return _startingStation;
			}
			set
			{
				if (_startingStation == value)
				{
					return;
				}
				_startingStation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get
			{
				if (_isInteractive == null)
				{
					_isInteractive = (CBool) CR2WTypeManager.Create("Bool", "isInteractive", cr2w, this);
				}
				return _isInteractive;
			}
			set
			{
				if (_isInteractive == value)
				{
					return;
				}
				_isInteractive = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public RadioSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
