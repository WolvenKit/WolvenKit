using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ManagePersonalLinkChangeEvent : redEvent
	{
		private CBool _shouldEquip;

		[Ordinal(0)] 
		[RED("shouldEquip")] 
		public CBool ShouldEquip
		{
			get => GetProperty(ref _shouldEquip);
			set => SetProperty(ref _shouldEquip, value);
		}

		public ManagePersonalLinkChangeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
