using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITeleportCommand : AICommand
	{
		private Vector4 _position;
		private CFloat _rotation;
		private CBool _doNavTest;

		[Ordinal(4)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(5)] 
		[RED("rotation")] 
		public CFloat Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(6)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get => GetProperty(ref _doNavTest);
			set => SetProperty(ref _doNavTest, value);
		}

		public AITeleportCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
