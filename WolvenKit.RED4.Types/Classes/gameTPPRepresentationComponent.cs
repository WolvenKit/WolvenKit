using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTPPRepresentationComponent : entIComponent
	{
		private CArray<gameFppRepDetachedObjectInfo> _detachedObjectInfo;
		private CArray<gameTppRepAttachedObjectInfo> _attachedObjectInfo;
		private CArray<TweakDBID> _affectedAppearanceSlots;

		[Ordinal(3)] 
		[RED("detachedObjectInfo")] 
		public CArray<gameFppRepDetachedObjectInfo> DetachedObjectInfo
		{
			get => GetProperty(ref _detachedObjectInfo);
			set => SetProperty(ref _detachedObjectInfo, value);
		}

		[Ordinal(4)] 
		[RED("attachedObjectInfo")] 
		public CArray<gameTppRepAttachedObjectInfo> AttachedObjectInfo
		{
			get => GetProperty(ref _attachedObjectInfo);
			set => SetProperty(ref _attachedObjectInfo, value);
		}

		[Ordinal(5)] 
		[RED("affectedAppearanceSlots")] 
		public CArray<TweakDBID> AffectedAppearanceSlots
		{
			get => GetProperty(ref _affectedAppearanceSlots);
			set => SetProperty(ref _affectedAppearanceSlots, value);
		}
	}
}
