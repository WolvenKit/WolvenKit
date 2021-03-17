using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLinePatternWidget : inkImageWidget
	{
		private CArray<inkLineVertex> _vertexList;
		private CFloat _spacing;
		private CFloat _looseSpacing;
		private CFloat _startOffset;
		private CFloat _endOffset;
		private CFloat _fadeInLength;
		private CBool _rotateWithSegment;
		private CEnum<inkEChildOrder> _patternDirection;

		[Ordinal(30)] 
		[RED("vertexList")] 
		public CArray<inkLineVertex> VertexList
		{
			get => GetProperty(ref _vertexList);
			set => SetProperty(ref _vertexList, value);
		}

		[Ordinal(31)] 
		[RED("spacing")] 
		public CFloat Spacing
		{
			get => GetProperty(ref _spacing);
			set => SetProperty(ref _spacing, value);
		}

		[Ordinal(32)] 
		[RED("looseSpacing")] 
		public CFloat LooseSpacing
		{
			get => GetProperty(ref _looseSpacing);
			set => SetProperty(ref _looseSpacing, value);
		}

		[Ordinal(33)] 
		[RED("startOffset")] 
		public CFloat StartOffset
		{
			get => GetProperty(ref _startOffset);
			set => SetProperty(ref _startOffset, value);
		}

		[Ordinal(34)] 
		[RED("endOffset")] 
		public CFloat EndOffset
		{
			get => GetProperty(ref _endOffset);
			set => SetProperty(ref _endOffset, value);
		}

		[Ordinal(35)] 
		[RED("fadeInLength")] 
		public CFloat FadeInLength
		{
			get => GetProperty(ref _fadeInLength);
			set => SetProperty(ref _fadeInLength, value);
		}

		[Ordinal(36)] 
		[RED("rotateWithSegment")] 
		public CBool RotateWithSegment
		{
			get => GetProperty(ref _rotateWithSegment);
			set => SetProperty(ref _rotateWithSegment, value);
		}

		[Ordinal(37)] 
		[RED("patternDirection")] 
		public CEnum<inkEChildOrder> PatternDirection
		{
			get => GetProperty(ref _patternDirection);
			set => SetProperty(ref _patternDirection, value);
		}

		public inkLinePatternWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
