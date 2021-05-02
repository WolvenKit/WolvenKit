using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealNetworkGridEvent : redEvent
	{
		private CBool _shouldDraw;
		private Vector4 _ownerEntityPosition;
		private gameFxResource _fxDefault;
		private gameFxResource _fxBreached;
		private CBool _revealSlave;
		private CBool _revealMaster;

		[Ordinal(0)] 
		[RED("shouldDraw")] 
		public CBool ShouldDraw
		{
			get => GetProperty(ref _shouldDraw);
			set => SetProperty(ref _shouldDraw, value);
		}

		[Ordinal(1)] 
		[RED("ownerEntityPosition")] 
		public Vector4 OwnerEntityPosition
		{
			get => GetProperty(ref _ownerEntityPosition);
			set => SetProperty(ref _ownerEntityPosition, value);
		}

		[Ordinal(2)] 
		[RED("fxDefault")] 
		public gameFxResource FxDefault
		{
			get => GetProperty(ref _fxDefault);
			set => SetProperty(ref _fxDefault, value);
		}

		[Ordinal(3)] 
		[RED("fxBreached")] 
		public gameFxResource FxBreached
		{
			get => GetProperty(ref _fxBreached);
			set => SetProperty(ref _fxBreached, value);
		}

		[Ordinal(4)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get => GetProperty(ref _revealSlave);
			set => SetProperty(ref _revealSlave, value);
		}

		[Ordinal(5)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get => GetProperty(ref _revealMaster);
			set => SetProperty(ref _revealMaster, value);
		}

		public RevealNetworkGridEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
