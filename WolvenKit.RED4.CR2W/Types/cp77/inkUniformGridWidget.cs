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
			get => GetProperty(ref _wrappingWidgetCount);
			set => SetProperty(ref _wrappingWidgetCount, value);
		}

		[Ordinal(24)] 
		[RED("orientation")] 
		public CEnum<inkEOrientation> Orientation
		{
			get => GetProperty(ref _orientation);
			set => SetProperty(ref _orientation, value);
		}

		public inkUniformGridWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
