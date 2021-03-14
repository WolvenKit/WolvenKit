using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEnvAreaNotifier : worldITriggerAreaNotifer
	{
		private CUInt8 _priority;
		private CFloat _horizontalFadeDistance;
		private CFloat _verticalFadeDistance;
		private CFloat _blendTimeIn;
		private CFloat _blendTimeOut;
		private rRef<worldEnvironmentAreaParameters> _env;
		private WorldRenderAreaSettings _params;
		private CArray<CName> _weatherStateNames;
		private CArray<CBool> _weatherStateValues;

		[Ordinal(3)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CUInt8) CR2WTypeManager.Create("Uint8", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("horizontalFadeDistance")] 
		public CFloat HorizontalFadeDistance
		{
			get
			{
				if (_horizontalFadeDistance == null)
				{
					_horizontalFadeDistance = (CFloat) CR2WTypeManager.Create("Float", "horizontalFadeDistance", cr2w, this);
				}
				return _horizontalFadeDistance;
			}
			set
			{
				if (_horizontalFadeDistance == value)
				{
					return;
				}
				_horizontalFadeDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("verticalFadeDistance")] 
		public CFloat VerticalFadeDistance
		{
			get
			{
				if (_verticalFadeDistance == null)
				{
					_verticalFadeDistance = (CFloat) CR2WTypeManager.Create("Float", "verticalFadeDistance", cr2w, this);
				}
				return _verticalFadeDistance;
			}
			set
			{
				if (_verticalFadeDistance == value)
				{
					return;
				}
				_verticalFadeDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("blendTimeIn")] 
		public CFloat BlendTimeIn
		{
			get
			{
				if (_blendTimeIn == null)
				{
					_blendTimeIn = (CFloat) CR2WTypeManager.Create("Float", "blendTimeIn", cr2w, this);
				}
				return _blendTimeIn;
			}
			set
			{
				if (_blendTimeIn == value)
				{
					return;
				}
				_blendTimeIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("blendTimeOut")] 
		public CFloat BlendTimeOut
		{
			get
			{
				if (_blendTimeOut == null)
				{
					_blendTimeOut = (CFloat) CR2WTypeManager.Create("Float", "blendTimeOut", cr2w, this);
				}
				return _blendTimeOut;
			}
			set
			{
				if (_blendTimeOut == value)
				{
					return;
				}
				_blendTimeOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("env")] 
		public rRef<worldEnvironmentAreaParameters> Env
		{
			get
			{
				if (_env == null)
				{
					_env = (rRef<worldEnvironmentAreaParameters>) CR2WTypeManager.Create("rRef:worldEnvironmentAreaParameters", "env", cr2w, this);
				}
				return _env;
			}
			set
			{
				if (_env == value)
				{
					return;
				}
				_env = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("params")] 
		public WorldRenderAreaSettings Params
		{
			get
			{
				if (_params == null)
				{
					_params = (WorldRenderAreaSettings) CR2WTypeManager.Create("WorldRenderAreaSettings", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("weatherStateNames")] 
		public CArray<CName> WeatherStateNames
		{
			get
			{
				if (_weatherStateNames == null)
				{
					_weatherStateNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "weatherStateNames", cr2w, this);
				}
				return _weatherStateNames;
			}
			set
			{
				if (_weatherStateNames == value)
				{
					return;
				}
				_weatherStateNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("weatherStateValues")] 
		public CArray<CBool> WeatherStateValues
		{
			get
			{
				if (_weatherStateValues == null)
				{
					_weatherStateValues = (CArray<CBool>) CR2WTypeManager.Create("array:Bool", "weatherStateValues", cr2w, this);
				}
				return _weatherStateValues;
			}
			set
			{
				if (_weatherStateValues == value)
				{
					return;
				}
				_weatherStateValues = value;
				PropertySet(this);
			}
		}

		public worldEnvAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
