using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRaceSplineNodeOffset : CVariable
	{
		private CFloat _from;
		private CFloat _to;
		private CFloat _left;
		private CFloat _right;

		[Ordinal(0)] 
		[RED("from")] 
		public CFloat From
		{
			get => GetProperty(ref _from);
			set => SetProperty(ref _from, value);
		}

		[Ordinal(1)] 
		[RED("to")] 
		public CFloat To
		{
			get => GetProperty(ref _to);
			set => SetProperty(ref _to, value);
		}

		[Ordinal(2)] 
		[RED("left")] 
		public CFloat Left
		{
			get => GetProperty(ref _left);
			set => SetProperty(ref _left, value);
		}

		[Ordinal(3)] 
		[RED("right")] 
		public CFloat Right
		{
			get => GetProperty(ref _right);
			set => SetProperty(ref _right, value);
		}

		public worldRaceSplineNodeOffset(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
