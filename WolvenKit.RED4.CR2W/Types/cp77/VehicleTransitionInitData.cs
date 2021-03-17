using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleTransitionInitData : IScriptable
	{
		private CBool _instant;
		private entEntityID _entityID;
		private CBool _alive;
		private CBool _occupiedByNeutral;

		[Ordinal(0)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(2)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		[Ordinal(3)] 
		[RED("occupiedByNeutral")] 
		public CBool OccupiedByNeutral
		{
			get => GetProperty(ref _occupiedByNeutral);
			set => SetProperty(ref _occupiedByNeutral, value);
		}

		public VehicleTransitionInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
