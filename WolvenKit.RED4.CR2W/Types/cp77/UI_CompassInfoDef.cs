using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_CompassInfoDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Float _northOffset;
		private gamebbScriptID_Float _southOffset;
		private gamebbScriptID_Float _eastOffset;
		private gamebbScriptID_Float _westOffset;
		private gamebbScriptID_Variant _pins;

		[Ordinal(0)] 
		[RED("NorthOffset")] 
		public gamebbScriptID_Float NorthOffset
		{
			get
			{
				if (_northOffset == null)
				{
					_northOffset = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "NorthOffset", cr2w, this);
				}
				return _northOffset;
			}
			set
			{
				if (_northOffset == value)
				{
					return;
				}
				_northOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("SouthOffset")] 
		public gamebbScriptID_Float SouthOffset
		{
			get
			{
				if (_southOffset == null)
				{
					_southOffset = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "SouthOffset", cr2w, this);
				}
				return _southOffset;
			}
			set
			{
				if (_southOffset == value)
				{
					return;
				}
				_southOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("EastOffset")] 
		public gamebbScriptID_Float EastOffset
		{
			get
			{
				if (_eastOffset == null)
				{
					_eastOffset = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "EastOffset", cr2w, this);
				}
				return _eastOffset;
			}
			set
			{
				if (_eastOffset == value)
				{
					return;
				}
				_eastOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("WestOffset")] 
		public gamebbScriptID_Float WestOffset
		{
			get
			{
				if (_westOffset == null)
				{
					_westOffset = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "WestOffset", cr2w, this);
				}
				return _westOffset;
			}
			set
			{
				if (_westOffset == value)
				{
					return;
				}
				_westOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("Pins")] 
		public gamebbScriptID_Variant Pins
		{
			get
			{
				if (_pins == null)
				{
					_pins = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "Pins", cr2w, this);
				}
				return _pins;
			}
			set
			{
				if (_pins == value)
				{
					return;
				}
				_pins = value;
				PropertySet(this);
			}
		}

		public UI_CompassInfoDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
