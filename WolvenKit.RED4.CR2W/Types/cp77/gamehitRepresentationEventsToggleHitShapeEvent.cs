using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsToggleHitShapeEvent : redEvent
	{
		private CBool _enable;
		private CName _hitShapeName;
		private CBool _hierarchical;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("hitShapeName")] 
		public CName HitShapeName
		{
			get => GetProperty(ref _hitShapeName);
			set => SetProperty(ref _hitShapeName, value);
		}

		[Ordinal(2)] 
		[RED("hierarchical")] 
		public CBool Hierarchical
		{
			get => GetProperty(ref _hierarchical);
			set => SetProperty(ref _hierarchical, value);
		}

		public gamehitRepresentationEventsToggleHitShapeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
