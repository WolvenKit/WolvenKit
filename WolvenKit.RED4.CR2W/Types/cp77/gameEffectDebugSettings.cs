using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectDebugSettings : CVariable
	{
		private CBool _overrideGlobalSettings;
		private CFloat _duration;
		private CColor _color;

		[Ordinal(0)] 
		[RED("overrideGlobalSettings")] 
		public CBool OverrideGlobalSettings
		{
			get
			{
				if (_overrideGlobalSettings == null)
				{
					_overrideGlobalSettings = (CBool) CR2WTypeManager.Create("Bool", "overrideGlobalSettings", cr2w, this);
				}
				return _overrideGlobalSettings;
			}
			set
			{
				if (_overrideGlobalSettings == value)
				{
					return;
				}
				_overrideGlobalSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("color")] 
		public CColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CColor) CR2WTypeManager.Create("Color", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		public gameEffectDebugSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
