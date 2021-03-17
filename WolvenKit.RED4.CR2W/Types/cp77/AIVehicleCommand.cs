using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIVehicleCommand : AICommand
	{
		private CBool _useKinematic;
		private CBool _needDriver;

		[Ordinal(4)] 
		[RED("useKinematic")] 
		public CBool UseKinematic
		{
			get => GetProperty(ref _useKinematic);
			set => SetProperty(ref _useKinematic, value);
		}

		[Ordinal(5)] 
		[RED("needDriver")] 
		public CBool NeedDriver
		{
			get => GetProperty(ref _needDriver);
			set => SetProperty(ref _needDriver, value);
		}

		public AIVehicleCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
