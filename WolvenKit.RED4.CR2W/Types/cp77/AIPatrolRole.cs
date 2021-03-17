using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIPatrolRole : AIRole
	{
		private CHandle<AIPatrolPathParameters> _pathParams;
		private CHandle<AIPatrolPathParameters> _alertedPathParams;
		private CFloat _alertedRadius;
		private CHandle<AIbehaviorWorkspotList> _alertedSpots;
		private CBool _forceAlerted;

		[Ordinal(0)] 
		[RED("pathParams")] 
		public CHandle<AIPatrolPathParameters> PathParams
		{
			get => GetProperty(ref _pathParams);
			set => SetProperty(ref _pathParams, value);
		}

		[Ordinal(1)] 
		[RED("alertedPathParams")] 
		public CHandle<AIPatrolPathParameters> AlertedPathParams
		{
			get => GetProperty(ref _alertedPathParams);
			set => SetProperty(ref _alertedPathParams, value);
		}

		[Ordinal(2)] 
		[RED("alertedRadius")] 
		public CFloat AlertedRadius
		{
			get => GetProperty(ref _alertedRadius);
			set => SetProperty(ref _alertedRadius, value);
		}

		[Ordinal(3)] 
		[RED("alertedSpots")] 
		public CHandle<AIbehaviorWorkspotList> AlertedSpots
		{
			get => GetProperty(ref _alertedSpots);
			set => SetProperty(ref _alertedSpots, value);
		}

		[Ordinal(4)] 
		[RED("forceAlerted")] 
		public CBool ForceAlerted
		{
			get => GetProperty(ref _forceAlerted);
			set => SetProperty(ref _forceAlerted, value);
		}

		public AIPatrolRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
