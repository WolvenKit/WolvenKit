using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePlayerProximityPrereq : gameIPrereq
	{
		private CFloat _squaredRange;

		[Ordinal(0)] 
		[RED("squaredRange")] 
		public CFloat SquaredRange
		{
			get => GetProperty(ref _squaredRange);
			set => SetProperty(ref _squaredRange, value);
		}

		public gamePlayerProximityPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
