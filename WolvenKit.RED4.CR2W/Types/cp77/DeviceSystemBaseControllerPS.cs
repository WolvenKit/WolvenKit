using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceSystemBaseControllerPS : MasterControllerPS
	{
		private CBool _quickHacksEnabled;

		[Ordinal(104)] 
		[RED("quickHacksEnabled")] 
		public CBool QuickHacksEnabled
		{
			get => GetProperty(ref _quickHacksEnabled);
			set => SetProperty(ref _quickHacksEnabled, value);
		}

		public DeviceSystemBaseControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
