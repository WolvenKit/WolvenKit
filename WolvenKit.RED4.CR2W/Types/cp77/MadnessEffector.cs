using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MadnessEffector : gameEffector
	{
		private CArray<entEntityID> _squadMembers;
		private wCHandle<ScriptedPuppet> _owner;

		[Ordinal(0)] 
		[RED("squadMembers")] 
		public CArray<entEntityID> SquadMembers
		{
			get => GetProperty(ref _squadMembers);
			set => SetProperty(ref _squadMembers, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<ScriptedPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public MadnessEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
