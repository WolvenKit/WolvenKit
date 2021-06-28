using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsDistanceFromScreenCenterPredicate : gameinteractionsIPredicateType
	{
		private CFloat _height;
		private CFloat _width;
		private CFloat _curvature;
		private CFloat _maxPriorityBoundsFactor;

		[Ordinal(0)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(1)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(2)] 
		[RED("curvature")] 
		public CFloat Curvature
		{
			get => GetProperty(ref _curvature);
			set => SetProperty(ref _curvature, value);
		}

		[Ordinal(3)] 
		[RED("maxPriorityBoundsFactor")] 
		public CFloat MaxPriorityBoundsFactor
		{
			get => GetProperty(ref _maxPriorityBoundsFactor);
			set => SetProperty(ref _maxPriorityBoundsFactor, value);
		}

		public gameinteractionsDistanceFromScreenCenterPredicate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
