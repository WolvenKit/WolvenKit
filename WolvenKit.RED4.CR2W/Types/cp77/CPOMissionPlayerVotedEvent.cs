using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CPOMissionPlayerVotedEvent : redEvent
	{
		private CName _compatibleDeviceName;

		[Ordinal(0)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get
			{
				if (_compatibleDeviceName == null)
				{
					_compatibleDeviceName = (CName) CR2WTypeManager.Create("CName", "compatibleDeviceName", cr2w, this);
				}
				return _compatibleDeviceName;
			}
			set
			{
				if (_compatibleDeviceName == value)
				{
					return;
				}
				_compatibleDeviceName = value;
				PropertySet(this);
			}
		}

		public CPOMissionPlayerVotedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
