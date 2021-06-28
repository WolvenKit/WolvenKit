using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IntercomControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isCalling;
		private CBool _sceneStarted;
		private CBool _endingCall;
		private entEntityID _forceLookAt;
		private CBool _forceFollow;

		[Ordinal(103)] 
		[RED("isCalling")] 
		public CBool IsCalling
		{
			get => GetProperty(ref _isCalling);
			set => SetProperty(ref _isCalling, value);
		}

		[Ordinal(104)] 
		[RED("sceneStarted")] 
		public CBool SceneStarted
		{
			get => GetProperty(ref _sceneStarted);
			set => SetProperty(ref _sceneStarted, value);
		}

		[Ordinal(105)] 
		[RED("endingCall")] 
		public CBool EndingCall
		{
			get => GetProperty(ref _endingCall);
			set => SetProperty(ref _endingCall, value);
		}

		[Ordinal(106)] 
		[RED("forceLookAt")] 
		public entEntityID ForceLookAt
		{
			get => GetProperty(ref _forceLookAt);
			set => SetProperty(ref _forceLookAt, value);
		}

		[Ordinal(107)] 
		[RED("forceFollow")] 
		public CBool ForceFollow
		{
			get => GetProperty(ref _forceFollow);
			set => SetProperty(ref _forceFollow, value);
		}

		public IntercomControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
