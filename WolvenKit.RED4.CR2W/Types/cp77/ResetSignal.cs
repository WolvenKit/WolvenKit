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
			get
			{
				if (_signalName == null)
				{
					_signalName = (CName) CR2WTypeManager.Create("CName", "signalName", cr2w, this);
				}
				return _signalName;
			}
			set
			{
				if (_signalName == value)
				{
					return;
				}
				_signalName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("signalTable")] 
		public CHandle<gameBoolSignalTable> SignalTable
		{
			get
			{
				if (_signalTable == null)
				{
					_signalTable = (CHandle<gameBoolSignalTable>) CR2WTypeManager.Create("handle:gameBoolSignalTable", "signalTable", cr2w, this);
				}
				return _signalTable;
			}
			set
			{
				if (_signalTable == value)
				{
					return;
				}
				_signalTable = value;
				PropertySet(this);
			}
		}

		public ResetSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
