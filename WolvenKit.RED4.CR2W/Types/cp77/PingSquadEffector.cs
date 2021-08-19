using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PingSquadEffector : gameEffector
	{
		private CArray<entEntityID> _squadMembers;
		private wCHandle<gameObject> _owner;
		private CHandle<gameAttitudeAgent> _oldSquadAttitude;
		private CFloat _quickhackLevel;
		private CHandle<FocusForcedHighlightData> _data;
		private CName _squadName;

		[Ordinal(0)] 
		[RED("squadMembers")] 
		public CArray<entEntityID> SquadMembers
		{
			get => GetProperty(ref _squadMembers);
			set => SetProperty(ref _squadMembers, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(2)] 
		[RED("oldSquadAttitude")] 
		public CHandle<gameAttitudeAgent> OldSquadAttitude
		{
			get => GetProperty(ref _oldSquadAttitude);
			set => SetProperty(ref _oldSquadAttitude, value);
		}

		[Ordinal(3)] 
		[RED("quickhackLevel")] 
		public CFloat QuickhackLevel
		{
			get => GetProperty(ref _quickhackLevel);
			set => SetProperty(ref _quickhackLevel, value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<FocusForcedHighlightData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(5)] 
		[RED("squadName")] 
		public CName SquadName
		{
			get => GetProperty(ref _squadName);
			set => SetProperty(ref _squadName, value);
		}

		public PingSquadEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
