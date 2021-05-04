using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WoundedTriggeredPrereq : gameIScriptablePrereq
	{
		private CUInt32 _currValue;

		[Ordinal(0)] 
		[RED("currValue")] 
		public CUInt32 CurrValue
		{
			get => GetProperty(ref _currValue);
			set => SetProperty(ref _currValue, value);
		}

		public WoundedTriggeredPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
