using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveSplineReverseTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _spline;

		[Ordinal(1)] 
		[RED("spline")] 
		public CHandle<AIArgumentMapping> Spline
		{
			get => GetProperty(ref _spline);
			set => SetProperty(ref _spline, value);
		}

		public AIbehaviorDriveSplineReverseTreeNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
