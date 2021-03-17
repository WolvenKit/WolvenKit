using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpConveyorLine : CVariable
	{
		private NodeRef _spline;
		private CName _template;
		private CBool _reverseDirection;
		private CArray<Vector2> _physicsValidRanges;

		[Ordinal(0)] 
		[RED("spline")] 
		public NodeRef Spline
		{
			get => GetProperty(ref _spline);
			set => SetProperty(ref _spline, value);
		}

		[Ordinal(1)] 
		[RED("template")] 
		public CName Template
		{
			get => GetProperty(ref _template);
			set => SetProperty(ref _template, value);
		}

		[Ordinal(2)] 
		[RED("reverseDirection")] 
		public CBool ReverseDirection
		{
			get => GetProperty(ref _reverseDirection);
			set => SetProperty(ref _reverseDirection, value);
		}

		[Ordinal(3)] 
		[RED("physicsValidRanges")] 
		public CArray<Vector2> PhysicsValidRanges
		{
			get => GetProperty(ref _physicsValidRanges);
			set => SetProperty(ref _physicsValidRanges, value);
		}

		public cpConveyorLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
