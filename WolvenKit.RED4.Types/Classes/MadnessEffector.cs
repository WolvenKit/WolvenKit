using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MadnessEffector : gameEffector
	{
		private CArray<entEntityID> _squadMembers;
		private CWeakHandle<ScriptedPuppet> _owner;

		[Ordinal(0)] 
		[RED("squadMembers")] 
		public CArray<entEntityID> SquadMembers
		{
			get => GetProperty(ref _squadMembers);
			set => SetProperty(ref _squadMembers, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<ScriptedPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
