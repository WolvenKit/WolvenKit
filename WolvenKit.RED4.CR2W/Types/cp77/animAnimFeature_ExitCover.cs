using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_ExitCover : animAnimFeature_AIAction
	{
		private CInt32 _coverStance;
		private CInt32 _coverExitDirection;

		[Ordinal(4)] 
		[RED("coverStance")] 
		public CInt32 CoverStance
		{
			get => GetProperty(ref _coverStance);
			set => SetProperty(ref _coverStance, value);
		}

		[Ordinal(5)] 
		[RED("coverExitDirection")] 
		public CInt32 CoverExitDirection
		{
			get => GetProperty(ref _coverExitDirection);
			set => SetProperty(ref _coverExitDirection, value);
		}

		public animAnimFeature_ExitCover(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
