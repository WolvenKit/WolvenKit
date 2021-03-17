using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_ManageRagdoll : questICharacterManagerCombat_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CBool _enableRagdoll;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("enableRagdoll")] 
		public CBool EnableRagdoll
		{
			get => GetProperty(ref _enableRagdoll);
			set => SetProperty(ref _enableRagdoll, value);
		}

		public questCharacterManagerCombat_ManageRagdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
