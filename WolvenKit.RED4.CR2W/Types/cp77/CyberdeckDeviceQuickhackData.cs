using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberdeckDeviceQuickhackData : CVariable
	{
		private wCHandle<gamedataUIIcon_Record> _uIIcon;
		private wCHandle<gamedataObjectAction_Record> _objectActionRecord;

		[Ordinal(0)] 
		[RED("UIIcon")] 
		public wCHandle<gamedataUIIcon_Record> UIIcon
		{
			get
			{
				if (_uIIcon == null)
				{
					_uIIcon = (wCHandle<gamedataUIIcon_Record>) CR2WTypeManager.Create("whandle:gamedataUIIcon_Record", "UIIcon", cr2w, this);
				}
				return _uIIcon;
			}
			set
			{
				if (_uIIcon == value)
				{
					return;
				}
				_uIIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ObjectActionRecord")] 
		public wCHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get
			{
				if (_objectActionRecord == null)
				{
					_objectActionRecord = (wCHandle<gamedataObjectAction_Record>) CR2WTypeManager.Create("whandle:gamedataObjectAction_Record", "ObjectActionRecord", cr2w, this);
				}
				return _objectActionRecord;
			}
			set
			{
				if (_objectActionRecord == value)
				{
					return;
				}
				_objectActionRecord = value;
				PropertySet(this);
			}
		}

		public CyberdeckDeviceQuickhackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
