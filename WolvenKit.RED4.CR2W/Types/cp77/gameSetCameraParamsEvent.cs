using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetCameraParamsEvent : redEvent
	{
		private CName _paramsName;

		[Ordinal(0)] 
		[RED("paramsName")] 
		public CName ParamsName
		{
			get => GetProperty(ref _paramsName);
			set => SetProperty(ref _paramsName, value);
		}

		public gameSetCameraParamsEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
