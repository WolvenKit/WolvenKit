using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProcessRelevantDevicesForNetworkGridEvent : ProcessDevicesEvent
	{
		private CBool _ignoreRevealed;
		private CBool _finalizeRegistrationAsMaster;
		private gameFxResource _breachedResource;
		private gameFxResource _defaultResource;
		private CBool _isPing;
		private CFloat _lifetime;
		private CBool _revealSlave;
		private CBool _revealMaster;

		[Ordinal(1)] 
		[RED("ignoreRevealed")] 
		public CBool IgnoreRevealed
		{
			get => GetProperty(ref _ignoreRevealed);
			set => SetProperty(ref _ignoreRevealed, value);
		}

		[Ordinal(2)] 
		[RED("finalizeRegistrationAsMaster")] 
		public CBool FinalizeRegistrationAsMaster
		{
			get => GetProperty(ref _finalizeRegistrationAsMaster);
			set => SetProperty(ref _finalizeRegistrationAsMaster, value);
		}

		[Ordinal(3)] 
		[RED("breachedResource")] 
		public gameFxResource BreachedResource
		{
			get => GetProperty(ref _breachedResource);
			set => SetProperty(ref _breachedResource, value);
		}

		[Ordinal(4)] 
		[RED("defaultResource")] 
		public gameFxResource DefaultResource
		{
			get => GetProperty(ref _defaultResource);
			set => SetProperty(ref _defaultResource, value);
		}

		[Ordinal(5)] 
		[RED("isPing")] 
		public CBool IsPing
		{
			get => GetProperty(ref _isPing);
			set => SetProperty(ref _isPing, value);
		}

		[Ordinal(6)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get => GetProperty(ref _lifetime);
			set => SetProperty(ref _lifetime, value);
		}

		[Ordinal(7)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get => GetProperty(ref _revealSlave);
			set => SetProperty(ref _revealSlave, value);
		}

		[Ordinal(8)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get => GetProperty(ref _revealMaster);
			set => SetProperty(ref _revealMaster, value);
		}

		public ProcessRelevantDevicesForNetworkGridEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
