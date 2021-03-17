using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTPPRepresentationComponent : entIComponent
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

		public gameTPPRepresentationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
