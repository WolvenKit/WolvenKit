using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_LeftHandItem : animAnimFeature
	{
		private CBool _itemInLeftHand;

		[Ordinal(0)] 
		[RED("itemInLeftHand")] 
		public CBool ItemInLeftHand
		{
			get => GetProperty(ref _itemInLeftHand);
			set => SetProperty(ref _itemInLeftHand, value);
		}

		public animAnimFeature_LeftHandItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
