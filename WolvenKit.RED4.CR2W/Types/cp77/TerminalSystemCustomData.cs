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
			get
			{
				if (_connectedDevices == null)
				{
					_connectedDevices = (CInt32) CR2WTypeManager.Create("Int32", "connectedDevices", cr2w, this);
				}
				return _connectedDevices;
			}
			set
			{
				if (_connectedDevices == value)
				{
					return;
				}
				_connectedDevices = value;
				PropertySet(this);
			}
		}

		public TerminalSystemCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
