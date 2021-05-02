using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLayout : CVariable
	{
		private inkMargin _padding;
		private inkMargin _margin;
		private CEnum<inkEHorizontalAlign> _hAlign;
		private CEnum<inkEVerticalAlign> _vAlign;
		private CEnum<inkEAnchor> _anchor;
		private Vector2 _anchorPoint;
		private CEnum<inkESizeRule> _sizeRule;
		private CFloat _sizeCoefficient;

		[Ordinal(0)] 
		[RED("padding")] 
		public inkMargin Padding
		{
			get => GetProperty(ref _padding);
			set => SetProperty(ref _padding, value);
		}

		[Ordinal(1)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetProperty(ref _margin);
			set => SetProperty(ref _margin, value);
		}

		[Ordinal(2)] 
		[RED("HAlign")] 
		public CEnum<inkEHorizontalAlign> HAlign
		{
			get => GetProperty(ref _hAlign);
			set => SetProperty(ref _hAlign, value);
		}

		[Ordinal(3)] 
		[RED("VAlign")] 
		public CEnum<inkEVerticalAlign> VAlign
		{
			get => GetProperty(ref _vAlign);
			set => SetProperty(ref _vAlign, value);
		}

		[Ordinal(4)] 
		[RED("anchor")] 
		public CEnum<inkEAnchor> Anchor
		{
			get => GetProperty(ref _anchor);
			set => SetProperty(ref _anchor, value);
		}

		[Ordinal(5)] 
		[RED("anchorPoint")] 
		public Vector2 AnchorPoint
		{
			get => GetProperty(ref _anchorPoint);
			set => SetProperty(ref _anchorPoint, value);
		}

		[Ordinal(6)] 
		[RED("sizeRule")] 
		public CEnum<inkESizeRule> SizeRule
		{
			get => GetProperty(ref _sizeRule);
			set => SetProperty(ref _sizeRule, value);
		}

		[Ordinal(7)] 
		[RED("sizeCoefficient")] 
		public CFloat SizeCoefficient
		{
			get => GetProperty(ref _sizeCoefficient);
			set => SetProperty(ref _sizeCoefficient, value);
		}

		public inkWidgetLayout(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
