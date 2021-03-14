using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LedColors_SensorDevice : CVariable
	{
		private ScriptLightSettings _off;
		private ScriptLightSettings _red;
		private ScriptLightSettings _green;
		private ScriptLightSettings _blue;
		private ScriptLightSettings _yellow;
		private ScriptLightSettings _white;

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

		[Ordinal(3)] 
		[RED("blue")] 
		public ScriptLightSettings Blue
		{
			get
			{
				if (_blue == null)
				{
					_blue = (ScriptLightSettings) CR2WTypeManager.Create("ScriptLightSettings", "blue", cr2w, this);
				}
				return _blue;
			}
			set
			{
				if (_blue == value)
				{
					return;
				}
				_blue = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("yellow")] 
		public ScriptLightSettings Yellow
		{
			get
			{
				if (_yellow == null)
				{
					_yellow = (ScriptLightSettings) CR2WTypeManager.Create("ScriptLightSettings", "yellow", cr2w, this);
				}
				return _yellow;
			}
			set
			{
				if (_yellow == value)
				{
					return;
				}
				_yellow = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("white")] 
		public ScriptLightSettings White
		{
			get
			{
				if (_white == null)
				{
					_white = (ScriptLightSettings) CR2WTypeManager.Create("ScriptLightSettings", "white", cr2w, this);
				}
				return _white;
			}
			set
			{
				if (_white == value)
				{
					return;
				}
				_white = value;
				PropertySet(this);
			}
		}

		public LedColors_SensorDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
