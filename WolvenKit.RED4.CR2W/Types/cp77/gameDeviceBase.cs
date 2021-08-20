using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDeviceBase : gameObject
	{
		private CBool _isLogicReady;

		[Ordinal(40)] 
		[RED("isLogicReady")] 
		public CBool IsLogicReady
		{
			get => GetProperty(ref _isLogicReady);
			set => SetProperty(ref _isLogicReady, value);
		}

		public gameDeviceBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
