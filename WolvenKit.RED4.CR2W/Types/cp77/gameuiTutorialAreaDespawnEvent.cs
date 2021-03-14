using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialAreaDespawnEvent : redEvent
	{
		private CName _bracketID;
		private CUInt32 _areaID;

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

		public gameuiTutorialAreaDespawnEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
