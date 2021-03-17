using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameCollisionLogic : inkWidgetLogicController
	{
		private Vector2 _colliderPositionOffset;
		private Vector2 _colliderSizeOffset;

		[Ordinal(1)] 
		[RED("colliderPositionOffset")] 
		public Vector2 ColliderPositionOffset
		{
			get => GetProperty(ref _colliderPositionOffset);
			set => SetProperty(ref _colliderPositionOffset, value);
		}

		[Ordinal(2)] 
		[RED("colliderSizeOffset")] 
		public Vector2 ColliderSizeOffset
		{
			get => GetProperty(ref _colliderSizeOffset);
			set => SetProperty(ref _colliderSizeOffset, value);
		}

		public gameuiSideScrollerMiniGameCollisionLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
