using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TerminalSystemCustomData : WidgetCustomData
	{
		private CInt32 _connectedDevices;

		[Ordinal(0)] 
		[RED("connectedDevices")] 
		public CInt32 ConnectedDevices
		{
			get => GetProperty(ref _connectedDevices);
			set => SetProperty(ref _connectedDevices, value);
		}

		public TerminalSystemCustomData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
