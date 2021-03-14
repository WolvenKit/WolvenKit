using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotCardPreviewPopupEvent : redEvent
	{
		private CHandle<TarotCardPreviewData> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<TarotCardPreviewData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<TarotCardPreviewData>) CR2WTypeManager.Create("handle:TarotCardPreviewData", "data", cr2w, this);
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

		public TarotCardPreviewPopupEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
