using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TeleportCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _position;
		private CHandle<AIArgumentMapping> _rotation;
		private CHandle<AIArgumentMapping> _doNavTest;

		[Ordinal(1)] 
		[RED("position")] 
		public CHandle<AIArgumentMapping> Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(2)] 
		[RED("rotation")] 
		public CHandle<AIArgumentMapping> Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(3)] 
		[RED("doNavTest")] 
		public CHandle<AIArgumentMapping> DoNavTest
		{
			get => GetProperty(ref _doNavTest);
			set => SetProperty(ref _doNavTest, value);
		}

		public TeleportCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
