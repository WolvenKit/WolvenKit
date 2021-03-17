using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Position_InitialPosition : gameTransformAnimation_Position
	{
		private Vector3 _offset;
		private CBool _offsetInWorldSpace;

		[Ordinal(0)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(1)] 
		[RED("offsetInWorldSpace")] 
		public CBool OffsetInWorldSpace
		{
			get => GetProperty(ref _offsetInWorldSpace);
			set => SetProperty(ref _offsetInWorldSpace, value);
		}

		public gameTransformAnimation_Position_InitialPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
