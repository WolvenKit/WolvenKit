using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpConveyor : gameObject
	{
		private CArray<cpConveyorLine> _lines;
		private curveData<CFloat> _movementCurve;
		private CFloat _entityDistance;
		private CFloat _entitySpawnOffset;
		private CName _audioParameterLineActive;
		private CName _audioParameterLineCycle;
		private CName _audioParameterLineSpeed;

		[Ordinal(40)] 
		[RED("lines")] 
		public CArray<cpConveyorLine> Lines
		{
			get
			{
				if (_lines == null)
				{
					_lines = (CArray<cpConveyorLine>) CR2WTypeManager.Create("array:cpConveyorLine", "lines", cr2w, this);
				}
				return _lines;
			}
			set
			{
				if (_lines == value)
				{
					return;
				}
				_lines = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("movementCurve")] 
		public curveData<CFloat> MovementCurve
		{
			get
			{
				if (_movementCurve == null)
				{
					_movementCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "movementCurve", cr2w, this);
				}
				return _movementCurve;
			}
			set
			{
				if (_movementCurve == value)
				{
					return;
				}
				_movementCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("entityDistance")] 
		public CFloat EntityDistance
		{
			get
			{
				if (_entityDistance == null)
				{
					_entityDistance = (CFloat) CR2WTypeManager.Create("Float", "entityDistance", cr2w, this);
				}
				return _entityDistance;
			}
			set
			{
				if (_entityDistance == value)
				{
					return;
				}
				_entityDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("entitySpawnOffset")] 
		public CFloat EntitySpawnOffset
		{
			get
			{
				if (_entitySpawnOffset == null)
				{
					_entitySpawnOffset = (CFloat) CR2WTypeManager.Create("Float", "entitySpawnOffset", cr2w, this);
				}
				return _entitySpawnOffset;
			}
			set
			{
				if (_entitySpawnOffset == value)
				{
					return;
				}
				_entitySpawnOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("audioParameterLineActive")] 
		public CName AudioParameterLineActive
		{
			get
			{
				if (_audioParameterLineActive == null)
				{
					_audioParameterLineActive = (CName) CR2WTypeManager.Create("CName", "audioParameterLineActive", cr2w, this);
				}
				return _audioParameterLineActive;
			}
			set
			{
				if (_audioParameterLineActive == value)
				{
					return;
				}
				_audioParameterLineActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("audioParameterLineCycle")] 
		public CName AudioParameterLineCycle
		{
			get
			{
				if (_audioParameterLineCycle == null)
				{
					_audioParameterLineCycle = (CName) CR2WTypeManager.Create("CName", "audioParameterLineCycle", cr2w, this);
				}
				return _audioParameterLineCycle;
			}
			set
			{
				if (_audioParameterLineCycle == value)
				{
					return;
				}
				_audioParameterLineCycle = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("audioParameterLineSpeed")] 
		public CName AudioParameterLineSpeed
		{
			get
			{
				if (_audioParameterLineSpeed == null)
				{
					_audioParameterLineSpeed = (CName) CR2WTypeManager.Create("CName", "audioParameterLineSpeed", cr2w, this);
				}
				return _audioParameterLineSpeed;
			}
			set
			{
				if (_audioParameterLineSpeed == value)
				{
					return;
				}
				_audioParameterLineSpeed = value;
				PropertySet(this);
			}
		}

		public cpConveyor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
