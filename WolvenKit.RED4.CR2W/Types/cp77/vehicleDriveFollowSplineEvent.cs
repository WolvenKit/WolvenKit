using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveFollowSplineEvent : redEvent
	{
		private NodeRef _splineRef;
		private CBool _backwards;
		private CBool _reverseSpline;

		[Ordinal(0)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetProperty(ref _splineRef);
			set => SetProperty(ref _splineRef, value);
		}

		[Ordinal(1)] 
		[RED("backwards")] 
		public CBool Backwards
		{
			get => GetProperty(ref _backwards);
			set => SetProperty(ref _backwards, value);
		}

		[Ordinal(2)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get => GetProperty(ref _reverseSpline);
			set => SetProperty(ref _reverseSpline, value);
		}

		public vehicleDriveFollowSplineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
