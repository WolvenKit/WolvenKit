using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResetSignal : redEvent
	{
		private CName _signalName;
		private CHandle<gameBoolSignalTable> _signalTable;

		[Ordinal(0)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetProperty(ref _signalName);
			set => SetProperty(ref _signalName, value);
		}

		[Ordinal(1)] 
		[RED("signalTable")] 
		public CHandle<gameBoolSignalTable> SignalTable
		{
			get => GetProperty(ref _signalTable);
			set => SetProperty(ref _signalTable, value);
		}

		public ResetSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
