using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Rotation_CurrentRotation : gameTransformAnimation_Rotation
	{
		private Quaternion _offset;

		[Ordinal(0)] 
		[RED("offset")] 
		public Quaternion Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		public gameTransformAnimation_Rotation_CurrentRotation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
