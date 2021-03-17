using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PingNetworkGridEvent : redEvent
	{
		private Vector4 _ownerEntityPosition;
		private gameFxResource _fxResource;
		private CFloat _lifetime;
		private CEnum<EPingType> _pingType;
		private CBool _revealSlave;
		private CBool _revealMaster;
		private CBool _ignoreRevealed;

		[Ordinal(0)] 
		[RED("ownerEntityPosition")] 
		public Vector4 OwnerEntityPosition
		{
			get => GetProperty(ref _ownerEntityPosition);
			set => SetProperty(ref _ownerEntityPosition, value);
		}

		[Ordinal(1)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get => GetProperty(ref _fxResource);
			set => SetProperty(ref _fxResource, value);
		}

		[Ordinal(2)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get => GetProperty(ref _lifetime);
			set => SetProperty(ref _lifetime, value);
		}

		[Ordinal(3)] 
		[RED("pingType")] 
		public CEnum<EPingType> PingType
		{
			get => GetProperty(ref _pingType);
			set => SetProperty(ref _pingType, value);
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

		[Ordinal(6)] 
		[RED("ignoreRevealed")] 
		public CBool IgnoreRevealed
		{
			get => GetProperty(ref _ignoreRevealed);
			set => SetProperty(ref _ignoreRevealed, value);
		}

		public PingNetworkGridEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
