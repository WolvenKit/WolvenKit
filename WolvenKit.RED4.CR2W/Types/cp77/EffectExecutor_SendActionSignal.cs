using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_SendActionSignal : gameEffectExecutor_Scripted
	{
		private CName _signalName;
		private CFloat _signalDuration;

		[Ordinal(1)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetProperty(ref _signalName);
			set => SetProperty(ref _signalName, value);
		}

		[Ordinal(2)] 
		[RED("signalDuration")] 
		public CFloat SignalDuration
		{
			get => GetProperty(ref _signalDuration);
			set => SetProperty(ref _signalDuration, value);
		}

		public EffectExecutor_SendActionSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
