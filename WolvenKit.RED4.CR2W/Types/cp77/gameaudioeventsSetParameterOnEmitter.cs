using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsSetParameterOnEmitter : gameaudioeventsEmitterEvent
	{
		private CName _paramName;
		private CFloat _paramValue;

		[Ordinal(1)] 
		[RED("paramName")] 
		public CName ParamName
		{
			get => GetProperty(ref _paramName);
			set => SetProperty(ref _paramName, value);
		}

		[Ordinal(2)] 
		[RED("paramValue")] 
		public CFloat ParamValue
		{
			get => GetProperty(ref _paramValue);
			set => SetProperty(ref _paramValue, value);
		}

		public gameaudioeventsSetParameterOnEmitter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
