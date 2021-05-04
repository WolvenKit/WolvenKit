using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DrawNetworkSquadEvent : redEvent
	{
		private CBool _shouldDraw;
		private gamePersistentID _memberID;
		private gameFxResource _fxResource;
		private CBool _isPing;
		private CBool _revealMaster;
		private CBool _revealSlave;
		private CBool _memberOnly;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("shouldDraw")] 
		public CBool ShouldDraw
		{
			get => GetProperty(ref _shouldDraw);
			set => SetProperty(ref _shouldDraw, value);
		}

		[Ordinal(1)] 
		[RED("memberID")] 
		public gamePersistentID MemberID
		{
			get => GetProperty(ref _memberID);
			set => SetProperty(ref _memberID, value);
		}

		[Ordinal(2)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get => GetProperty(ref _fxResource);
			set => SetProperty(ref _fxResource, value);
		}

		[Ordinal(3)] 
		[RED("isPing")] 
		public CBool IsPing
		{
			get => GetProperty(ref _isPing);
			set => SetProperty(ref _isPing, value);
		}

		[Ordinal(4)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get => GetProperty(ref _revealMaster);
			set => SetProperty(ref _revealMaster, value);
		}

		[Ordinal(5)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get => GetProperty(ref _revealSlave);
			set => SetProperty(ref _revealSlave, value);
		}

		[Ordinal(6)] 
		[RED("memberOnly")] 
		public CBool MemberOnly
		{
			get => GetProperty(ref _memberOnly);
			set => SetProperty(ref _memberOnly, value);
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public DrawNetworkSquadEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
