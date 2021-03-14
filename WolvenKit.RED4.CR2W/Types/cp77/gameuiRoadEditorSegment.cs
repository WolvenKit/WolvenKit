using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoadEditorSegment : CVariable
	{
		private CUInt32 _length;
		private CFloat _curve;
		private CBool _hasCheckpoint;
		private CArray<gameuiRoadEditorObstacleSettings> _obstacleSettings;
		private CArray<gameuiRoadEditorDecorationSettings> _decorationSettings;

		[Ordinal(0)] 
		[RED("length")] 
		public CUInt32 Length
		{
			get
			{
				if (_length == null)
				{
					_length = (CUInt32) CR2WTypeManager.Create("Uint32", "length", cr2w, this);
				}
				return _length;
			}
			set
			{
				if (_length == value)
				{
					return;
				}
				_length = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("curve")] 
		public CFloat Curve
		{
			get
			{
				if (_curve == null)
				{
					_curve = (CFloat) CR2WTypeManager.Create("Float", "curve", cr2w, this);
				}
				return _curve;
			}
			set
			{
				if (_curve == value)
				{
					return;
				}
				_curve = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hasCheckpoint")] 
		public CBool HasCheckpoint
		{
			get
			{
				if (_hasCheckpoint == null)
				{
					_hasCheckpoint = (CBool) CR2WTypeManager.Create("Bool", "hasCheckpoint", cr2w, this);
				}
				return _hasCheckpoint;
			}
			set
			{
				if (_hasCheckpoint == value)
				{
					return;
				}
				_hasCheckpoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("obstacleSettings")] 
		public CArray<gameuiRoadEditorObstacleSettings> ObstacleSettings
		{
			get
			{
				if (_obstacleSettings == null)
				{
					_obstacleSettings = (CArray<gameuiRoadEditorObstacleSettings>) CR2WTypeManager.Create("array:gameuiRoadEditorObstacleSettings", "obstacleSettings", cr2w, this);
				}
				return _obstacleSettings;
			}
			set
			{
				if (_obstacleSettings == value)
				{
					return;
				}
				_obstacleSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("decorationSettings")] 
		public CArray<gameuiRoadEditorDecorationSettings> DecorationSettings
		{
			get
			{
				if (_decorationSettings == null)
				{
					_decorationSettings = (CArray<gameuiRoadEditorDecorationSettings>) CR2WTypeManager.Create("array:gameuiRoadEditorDecorationSettings", "decorationSettings", cr2w, this);
				}
				return _decorationSettings;
			}
			set
			{
				if (_decorationSettings == value)
				{
					return;
				}
				_decorationSettings = value;
				PropertySet(this);
			}
		}

		public gameuiRoadEditorSegment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
