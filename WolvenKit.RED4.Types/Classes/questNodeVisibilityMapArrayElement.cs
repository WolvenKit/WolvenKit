using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questNodeVisibilityMapArrayElement : RedBaseClass
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
	}
}
