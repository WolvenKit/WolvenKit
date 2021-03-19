using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExitFromVehicle : AIVehicleTaskAbstract
	{
		private CBool _useFastExit;
		private CBool _tryBlendToWalk;

		[Ordinal(0)] 
		[RED("useFastExit")] 
		public CBool UseFastExit
		{
			get => GetProperty(ref _useFastExit);
			set => SetProperty(ref _useFastExit, value);
		}

		[Ordinal(1)] 
		[RED("tryBlendToWalk")] 
		public CBool TryBlendToWalk
		{
			get => GetProperty(ref _tryBlendToWalk);
			set => SetProperty(ref _tryBlendToWalk, value);
		}

		public ExitFromVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
