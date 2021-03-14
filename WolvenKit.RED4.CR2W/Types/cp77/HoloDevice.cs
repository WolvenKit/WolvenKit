using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoloDevice : InteractiveDevice
	{
		private CName _questFactName;

		[Ordinal(93)] 
		[RED("questFactName")] 
		public CName QuestFactName
		{
			get
			{
				if (_questFactName == null)
				{
					_questFactName = (CName) CR2WTypeManager.Create("CName", "questFactName", cr2w, this);
				}
				return _questFactName;
			}
			set
			{
				if (_questFactName == value)
				{
					return;
				}
				_questFactName = value;
				PropertySet(this);
			}
		}

		public HoloDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
