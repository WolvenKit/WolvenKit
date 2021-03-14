using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMountAIEvent : AIAIEvent
	{
		private CHandle<gameMountEventData> _data;

		[Ordinal(2)] 
		[RED("data")] 
		public CHandle<gameMountEventData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<gameMountEventData>) CR2WTypeManager.Create("handle:gameMountEventData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public gameMountAIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
