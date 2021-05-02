using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseDeviceStatus : ActionEnum
	{
		private CBool _isRestarting;

		[Ordinal(25)] 
		[RED("isRestarting")] 
		public CBool IsRestarting
		{
			get => GetProperty(ref _isRestarting);
			set => SetProperty(ref _isRestarting, value);
		}

		public BaseDeviceStatus(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
