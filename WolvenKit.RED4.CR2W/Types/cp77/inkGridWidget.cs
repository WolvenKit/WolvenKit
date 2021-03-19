using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGridWidget : inkCompoundWidget
	{
		private CEnum<inkEOrientation> _orientation;
		private inkMargin _childPadding;
		private Vector2 _childSizeStep;

		[Ordinal(23)] 
		[RED("orientation")] 
		public CEnum<inkEOrientation> Orientation
		{
			get => GetProperty(ref _orientation);
			set => SetProperty(ref _orientation, value);
		}

		[Ordinal(24)] 
		[RED("childPadding")] 
		public inkMargin ChildPadding
		{
			get => GetProperty(ref _childPadding);
			set => SetProperty(ref _childPadding, value);
		}

		[Ordinal(25)] 
		[RED("childSizeStep")] 
		public Vector2 ChildSizeStep
		{
			get => GetProperty(ref _childSizeStep);
			set => SetProperty(ref _childSizeStep, value);
		}

		public inkGridWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
