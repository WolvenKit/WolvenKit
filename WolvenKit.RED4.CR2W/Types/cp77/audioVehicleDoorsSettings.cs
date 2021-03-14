using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDoorsSettings : CVariable
	{
		private CName _openEvent;
		private CName _closeEvent;

		[Ordinal(0)] 
		[RED("openEvent")] 
		public CName OpenEvent
		{
			get
			{
				if (_openEvent == null)
				{
					_openEvent = (CName) CR2WTypeManager.Create("CName", "openEvent", cr2w, this);
				}
				return _openEvent;
			}
			set
			{
				if (_openEvent == value)
				{
					return;
				}
				_openEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("closeEvent")] 
		public CName CloseEvent
		{
			get
			{
				if (_closeEvent == null)
				{
					_closeEvent = (CName) CR2WTypeManager.Create("CName", "closeEvent", cr2w, this);
				}
				return _closeEvent;
			}
			set
			{
				if (_closeEvent == value)
				{
					return;
				}
				_closeEvent = value;
				PropertySet(this);
			}
		}

		public audioVehicleDoorsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
