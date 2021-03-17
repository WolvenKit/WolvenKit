using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerSpotted : redEvent
	{
		private CBool _comesFromNPC;
		private gamePersistentID _ownerID;
		private CBool _doesSee;
		private CArray<CHandle<SecurityAreaControllerPS>> _agentAreas;

		[Ordinal(0)] 
		[RED("comesFromNPC")] 
		public CBool ComesFromNPC
		{
			get => GetProperty(ref _comesFromNPC);
			set => SetProperty(ref _comesFromNPC, value);
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public gamePersistentID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(2)] 
		[RED("doesSee")] 
		public CBool DoesSee
		{
			get => GetProperty(ref _doesSee);
			set => SetProperty(ref _doesSee, value);
		}

		[Ordinal(3)] 
		[RED("agentAreas")] 
		public CArray<CHandle<SecurityAreaControllerPS>> AgentAreas
		{
			get => GetProperty(ref _agentAreas);
			set => SetProperty(ref _agentAreas, value);
		}

		public PlayerSpotted(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
