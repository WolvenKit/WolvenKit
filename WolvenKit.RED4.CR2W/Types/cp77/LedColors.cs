using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LedColors : CVariable
	{
		private ScriptLightSettings _off;
		private ScriptLightSettings _red;
		private ScriptLightSettings _green;

		[Ordinal(0)] 
		[RED("off")] 
		public ScriptLightSettings Off
		{
			get
			{
				if (_off == null)
				{
					_off = (ScriptLightSettings) CR2WTypeManager.Create("ScriptLightSettings", "off", cr2w, this);
				}
				return _off;
			}
			set
			{
				if (_off == value)
				{
					return;
				}
				_off = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("red")] 
		public ScriptLightSettings Red
		{
			get
			{
				if (_red == null)
				{
					_red = (ScriptLightSettings) CR2WTypeManager.Create("ScriptLightSettings", "red", cr2w, this);
				}
				return _red;
			}
			set
			{
				if (_red == value)
				{
					return;
				}
				_red = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("green")] 
		public ScriptLightSettings Green
		{
			get
			{
				if (_green == null)
				{
					_green = (ScriptLightSettings) CR2WTypeManager.Create("ScriptLightSettings", "green", cr2w, this);
				}
				return _green;
			}
			set
			{
				if (_green == value)
				{
					return;
				}
				_green = value;
				PropertySet(this);
			}
		}

		public LedColors(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
