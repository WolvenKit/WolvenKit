using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questNPCLookAt_NodeType : questISceneManagerNodeType
	{
		private gameEntityReference _puppetRef;
		private gameEntityReference _lookAtTargetRef;
		private CBool _assignLookAt;
		private CBool _refPlayer;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("lookAtTargetRef")] 
		public gameEntityReference LookAtTargetRef
		{
			get => GetProperty(ref _lookAtTargetRef);
			set => SetProperty(ref _lookAtTargetRef, value);
		}

		[Ordinal(2)] 
		[RED("assignLookAt")] 
		public CBool AssignLookAt
		{
			get => GetProperty(ref _assignLookAt);
			set => SetProperty(ref _assignLookAt, value);
		}

		[Ordinal(3)] 
		[RED("refPlayer")] 
		public CBool RefPlayer
		{
			get => GetProperty(ref _refPlayer);
			set => SetProperty(ref _refPlayer, value);
		}

		public questNPCLookAt_NodeType()
		{
			_assignLookAt = true;
		}
	}
}
