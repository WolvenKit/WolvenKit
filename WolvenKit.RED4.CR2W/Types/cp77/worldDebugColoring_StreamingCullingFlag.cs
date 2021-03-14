using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_StreamingCullingFlag : worldEditorDebugColoringSettings
	{
		private CColor _cullableColor;
		private CColor _forceCulledAlwaysColor;
		private CColor _forceCulledPeripheralColor;
		private CColor _defaultColor;

		[Ordinal(0)] 
		[RED("cullableColor")] 
		public CColor CullableColor
		{
			get
			{
				if (_cullableColor == null)
				{
					_cullableColor = (CColor) CR2WTypeManager.Create("Color", "cullableColor", cr2w, this);
				}
				return _cullableColor;
			}
			set
			{
				if (_cullableColor == value)
				{
					return;
				}
				_cullableColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("forceCulledAlwaysColor")] 
		public CColor ForceCulledAlwaysColor
		{
			get
			{
				if (_forceCulledAlwaysColor == null)
				{
					_forceCulledAlwaysColor = (CColor) CR2WTypeManager.Create("Color", "forceCulledAlwaysColor", cr2w, this);
				}
				return _forceCulledAlwaysColor;
			}
			set
			{
				if (_forceCulledAlwaysColor == value)
				{
					return;
				}
				_forceCulledAlwaysColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("forceCulledPeripheralColor")] 
		public CColor ForceCulledPeripheralColor
		{
			get
			{
				if (_forceCulledPeripheralColor == null)
				{
					_forceCulledPeripheralColor = (CColor) CR2WTypeManager.Create("Color", "forceCulledPeripheralColor", cr2w, this);
				}
				return _forceCulledPeripheralColor;
			}
			set
			{
				if (_forceCulledPeripheralColor == value)
				{
					return;
				}
				_forceCulledPeripheralColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get
			{
				if (_defaultColor == null)
				{
					_defaultColor = (CColor) CR2WTypeManager.Create("Color", "defaultColor", cr2w, this);
				}
				return _defaultColor;
			}
			set
			{
				if (_defaultColor == value)
				{
					return;
				}
				_defaultColor = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_StreamingCullingFlag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
