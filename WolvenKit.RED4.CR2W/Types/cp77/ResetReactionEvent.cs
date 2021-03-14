using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResetReactionEvent : redEvent
	{
		private CHandle<AIReactionData> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<AIReactionData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<AIReactionData>) CR2WTypeManager.Create("handle:AIReactionData", "data", cr2w, this);
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

		public ResetReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
