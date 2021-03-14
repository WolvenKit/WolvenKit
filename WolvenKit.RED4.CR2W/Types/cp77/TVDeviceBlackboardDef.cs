using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TVDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Int32 _previousChannel;
		private gamebbScriptID_Int32 _currentChannel;

		[Ordinal(7)] 
		[RED("PreviousChannel")] 
		public gamebbScriptID_Int32 PreviousChannel
		{
			get
			{
				if (_previousChannel == null)
				{
					_previousChannel = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "PreviousChannel", cr2w, this);
				}
				return _previousChannel;
			}
			set
			{
				if (_previousChannel == value)
				{
					return;
				}
				_previousChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("CurrentChannel")] 
		public gamebbScriptID_Int32 CurrentChannel
		{
			get
			{
				if (_currentChannel == null)
				{
					_currentChannel = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "CurrentChannel", cr2w, this);
				}
				return _currentChannel;
			}
			set
			{
				if (_currentChannel == value)
				{
					return;
				}
				_currentChannel = value;
				PropertySet(this);
			}
		}

		public TVDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
