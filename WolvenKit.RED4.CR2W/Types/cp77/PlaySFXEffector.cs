using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlaySFXEffector : gameEffector
	{
		private CName _activationSFXName;
		private CName _deactivationSFXName;
		private CBool _startOnUninitialize;
		private CBool _unique;
		private CBool _fireAndForget;
		private CBool _stopActiveSfxOnDeactivate;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("activationSFXName")] 
		public CName ActivationSFXName
		{
			get => GetProperty(ref _activationSFXName);
			set => SetProperty(ref _activationSFXName, value);
		}

		[Ordinal(1)] 
		[RED("deactivationSFXName")] 
		public CName DeactivationSFXName
		{
			get => GetProperty(ref _deactivationSFXName);
			set => SetProperty(ref _deactivationSFXName, value);
		}

		[Ordinal(2)] 
		[RED("startOnUninitialize")] 
		public CBool StartOnUninitialize
		{
			get => GetProperty(ref _startOnUninitialize);
			set => SetProperty(ref _startOnUninitialize, value);
		}

		[Ordinal(3)] 
		[RED("unique")] 
		public CBool Unique
		{
			get => GetProperty(ref _unique);
			set => SetProperty(ref _unique, value);
		}

		[Ordinal(4)] 
		[RED("fireAndForget")] 
		public CBool FireAndForget
		{
			get => GetProperty(ref _fireAndForget);
			set => SetProperty(ref _fireAndForget, value);
		}

		[Ordinal(5)] 
		[RED("stopActiveSfxOnDeactivate")] 
		public CBool StopActiveSfxOnDeactivate
		{
			get => GetProperty(ref _stopActiveSfxOnDeactivate);
			set => SetProperty(ref _stopActiveSfxOnDeactivate, value);
		}

		[Ordinal(6)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public PlaySFXEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
