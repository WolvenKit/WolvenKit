using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_MetricsUsageAbstractBase : worldEditorDebugColoringSettings
	{
		private CColor _maxColor;
		private CColor _minColor;
		private CUInt32 _minSize;
		private CUInt32 _maxSize;

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
		[RED("minSize")] 
		public CUInt32 MinSize
		{
			get
			{
				if (_minSize == null)
				{
					_minSize = (CUInt32) CR2WTypeManager.Create("Uint32", "minSize", cr2w, this);
				}
				return _minSize;
			}
			set
			{
				if (_minSize == value)
				{
					return;
				}
				_minSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxSize")] 
		public CUInt32 MaxSize
		{
			get
			{
				if (_maxSize == null)
				{
					_maxSize = (CUInt32) CR2WTypeManager.Create("Uint32", "maxSize", cr2w, this);
				}
				return _maxSize;
			}
			set
			{
				if (_maxSize == value)
				{
					return;
				}
				_maxSize = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_MetricsUsageAbstractBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
