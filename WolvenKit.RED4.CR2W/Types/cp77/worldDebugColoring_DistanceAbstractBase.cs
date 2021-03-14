using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_DistanceAbstractBase : worldEditorDebugColoringSettings
	{
		private CColor _maxColor;
		private CColor _minColor;
		private CFloat _minDistance;
		private CFloat _maxDistance;

		[Ordinal(0)] 
		[RED("maxColor")] 
		public CColor MaxColor
		{
			get
			{
				if (_maxColor == null)
				{
					_maxColor = (CColor) CR2WTypeManager.Create("Color", "maxColor", cr2w, this);
				}
				return _maxColor;
			}
			set
			{
				if (_maxColor == value)
				{
					return;
				}
				_maxColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("minColor")] 
		public CColor MinColor
		{
			get
			{
				if (_minColor == null)
				{
					_minColor = (CColor) CR2WTypeManager.Create("Color", "minColor", cr2w, this);
				}
				return _minColor;
			}
			set
			{
				if (_minColor == value)
				{
					return;
				}
				_minColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get
			{
				if (_minDistance == null)
				{
					_minDistance = (CFloat) CR2WTypeManager.Create("Float", "minDistance", cr2w, this);
				}
				return _minDistance;
			}
			set
			{
				if (_minDistance == value)
				{
					return;
				}
				_minDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get
			{
				if (_maxDistance == null)
				{
					_maxDistance = (CFloat) CR2WTypeManager.Create("Float", "maxDistance", cr2w, this);
				}
				return _maxDistance;
			}
			set
			{
				if (_maxDistance == value)
				{
					return;
				}
				_maxDistance = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_DistanceAbstractBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
