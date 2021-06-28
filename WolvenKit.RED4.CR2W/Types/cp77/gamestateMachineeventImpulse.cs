using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventImpulse : gamestateMachineeventBaseEvent
	{
		private Vector4 _impulse;

		[Ordinal(1)] 
		[RED("impulse")] 
		public Vector4 Impulse
		{
			get => GetProperty(ref _impulse);
			set => SetProperty(ref _impulse, value);
		}

		public gamestateMachineeventImpulse(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
