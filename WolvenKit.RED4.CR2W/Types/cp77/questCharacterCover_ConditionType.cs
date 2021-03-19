using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterCover_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _puppetRef;
		private NodeRef _coverRef;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("coverRef")] 
		public NodeRef CoverRef
		{
			get => GetProperty(ref _coverRef);
			set => SetProperty(ref _coverRef, value);
		}

		public questCharacterCover_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
