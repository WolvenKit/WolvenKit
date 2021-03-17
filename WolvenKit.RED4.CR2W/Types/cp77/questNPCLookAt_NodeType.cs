using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questNPCLookAt_NodeType : questISceneManagerNodeType
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

		public questNPCLookAt_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
