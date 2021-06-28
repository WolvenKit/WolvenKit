using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkScrollAreaWidget : inkCompoundWidget
	{
		private CFloat _horizontalScrolling;
		private CFloat _verticalScrolling;
		private CBool _constrainContentPosition;
		private CEnum<inkFitToContentDirection> _fitToContentDirection;
		private CBool _useInternalMask;

		[Ordinal(23)] 
		[RED("horizontalScrolling")] 
		public CFloat HorizontalScrolling
		{
			get => GetProperty(ref _horizontalScrolling);
			set => SetProperty(ref _horizontalScrolling, value);
		}

		[Ordinal(24)] 
		[RED("verticalScrolling")] 
		public CFloat VerticalScrolling
		{
			get => GetProperty(ref _verticalScrolling);
			set => SetProperty(ref _verticalScrolling, value);
		}

		[Ordinal(25)] 
		[RED("constrainContentPosition")] 
		public CBool ConstrainContentPosition
		{
			get => GetProperty(ref _constrainContentPosition);
			set => SetProperty(ref _constrainContentPosition, value);
		}

		[Ordinal(26)] 
		[RED("fitToContentDirection")] 
		public CEnum<inkFitToContentDirection> FitToContentDirection
		{
			get => GetProperty(ref _fitToContentDirection);
			set => SetProperty(ref _fitToContentDirection, value);
		}

		[Ordinal(27)] 
		[RED("useInternalMask")] 
		public CBool UseInternalMask
		{
			get => GetProperty(ref _useInternalMask);
			set => SetProperty(ref _useInternalMask, value);
		}

		public inkScrollAreaWidget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
