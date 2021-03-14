using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialAreaSpawnEvent : redEvent
	{
		private CName _bracketID;
		private CUInt32 _areaID;
		private wCHandle<inkWidget> _widget;

		[Ordinal(0)] 
		[RED("bracketID")] 
		public CName BracketID
		{
			get
			{
				if (_bracketID == null)
				{
					_bracketID = (CName) CR2WTypeManager.Create("CName", "bracketID", cr2w, this);
				}
				return _bracketID;
			}
			set
			{
				if (_bracketID == value)
				{
					return;
				}
				_bracketID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("areaID")] 
		public CUInt32 AreaID
		{
			get
			{
				if (_areaID == null)
				{
					_areaID = (CUInt32) CR2WTypeManager.Create("Uint32", "areaID", cr2w, this);
				}
				return _areaID;
			}
			set
			{
				if (_areaID == value)
				{
					return;
				}
				_areaID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get
			{
				if (_widget == null)
				{
					_widget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "widget", cr2w, this);
				}
				return _widget;
			}
			set
			{
				if (_widget == value)
				{
					return;
				}
				_widget = value;
				PropertySet(this);
			}
		}

		public gameuiTutorialAreaSpawnEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
