using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlayEnv_SetWeather : questIEnvironmentManagerNodeType
	{
		private CBool _reset;
		private TweakDBID _weatherID;
		private CFloat _blendTime;
		private CUInt32 _priority;
		private CName _source;

		[Ordinal(0)] 
		[RED("reset")] 
		public CBool Reset
		{
			get
			{
				if (_reset == null)
				{
					_reset = (CBool) CR2WTypeManager.Create("Bool", "reset", cr2w, this);
				}
				return _reset;
			}
			set
			{
				if (_reset == value)
				{
					return;
				}
				_reset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weatherID")] 
		public TweakDBID WeatherID
		{
			get
			{
				if (_weatherID == null)
				{
					_weatherID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "weatherID", cr2w, this);
				}
				return _weatherID;
			}
			set
			{
				if (_weatherID == value)
				{
					return;
				}
				_weatherID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get
			{
				if (_blendTime == null)
				{
					_blendTime = (CFloat) CR2WTypeManager.Create("Float", "blendTime", cr2w, this);
				}
				return _blendTime;
			}
			set
			{
				if (_blendTime == value)
				{
					return;
				}
				_blendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CUInt32) CR2WTypeManager.Create("Uint32", "priority", cr2w, this);
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
		[RED("source")] 
		public CName Source
		{
			get
			{
				if (_source == null)
				{
					_source = (CName) CR2WTypeManager.Create("CName", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		public questPlayEnv_SetWeather(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
