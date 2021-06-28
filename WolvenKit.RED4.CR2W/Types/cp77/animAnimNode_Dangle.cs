using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Dangle : animAnimNode_OnePoseInput
	{
		private CHandle<animDangleConstraint_Simulation> _dangleConstraint;

		[Ordinal(12)] 
		[RED("dangleConstraint")] 
		public CHandle<animDangleConstraint_Simulation> DangleConstraint
		{
			get => GetProperty(ref _dangleConstraint);
			set => SetProperty(ref _dangleConstraint, value);
		}

		public animAnimNode_Dangle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
