using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkUniformGridWidget : inkCompoundWidget
	{
		private CUInt32 _wrappingWidgetCount;
		private CEnum<inkEOrientation> _orientation;

		[Ordinal(23)] 
		[RED("wrappingWidgetCount")] 
		public CUInt32 WrappingWidgetCount
		{
			get
			{
				if (_wrappingWidgetCount == null)
				{
					_wrappingWidgetCount = (CUInt32) CR2WTypeManager.Create("Uint32", "wrappingWidgetCount", cr2w, this);
				}
				return _wrappingWidgetCount;
			}
			set
			{
				if (_wrappingWidgetCount == value)
				{
					return;
				}
				_wrappingWidgetCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("orientation")] 
		public CEnum<inkEOrientation> Orientation
		{
			get
			{
				if (_orientation == null)
				{
					_orientation = (CEnum<inkEOrientation>) CR2WTypeManager.Create("inkEOrientation", "orientation", cr2w, this);
				}
				return _orientation;
			}
			set
			{
				if (_orientation == value)
				{
					return;
				}
				_orientation = value;
				PropertySet(this);
			}
		}

		public inkUniformGridWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
