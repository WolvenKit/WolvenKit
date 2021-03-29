using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Window : Door
	{
		private CHandle<entIComponent> _soloCollider;
		private CHandle<entMeshComponent> _strongSoloHandle;
		private CBool _duplicateDestruction;

		[Ordinal(138)] 
		[RED("soloCollider")] 
		public CHandle<entIComponent> SoloCollider
		{
			get => GetProperty(ref _soloCollider);
			set => SetProperty(ref _soloCollider, value);
		}

		[Ordinal(139)] 
		[RED("strongSoloHandle")] 
		public CHandle<entMeshComponent> StrongSoloHandle
		{
			get => GetProperty(ref _strongSoloHandle);
			set => SetProperty(ref _strongSoloHandle, value);
		}

		[Ordinal(140)] 
		[RED("duplicateDestruction")] 
		public CBool DuplicateDestruction
		{
			get => GetProperty(ref _duplicateDestruction);
			set => SetProperty(ref _duplicateDestruction, value);
		}

		public Window(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
