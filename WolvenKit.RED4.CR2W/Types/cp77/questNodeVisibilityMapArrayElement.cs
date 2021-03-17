using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questNodeVisibilityMapArrayElement : CVariable
	{
		private worldGlobalNodeRef _globalNodeRef;
		private CBool _visible;

		[Ordinal(0)] 
		[RED("globalNodeRef")] 
		public worldGlobalNodeRef GlobalNodeRef
		{
			get => GetProperty(ref _globalNodeRef);
			set => SetProperty(ref _globalNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetProperty(ref _visible);
			set => SetProperty(ref _visible, value);
		}

		public questNodeVisibilityMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
