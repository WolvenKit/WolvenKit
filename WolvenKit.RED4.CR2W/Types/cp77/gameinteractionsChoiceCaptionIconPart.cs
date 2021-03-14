using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceCaptionIconPart : gameinteractionsChoiceCaptionPart
	{
		private wCHandle<gamedataChoiceCaptionIconPart_Record> _iconRecord;

		[Ordinal(0)] 
		[RED("iconRecord")] 
		public wCHandle<gamedataChoiceCaptionIconPart_Record> IconRecord
		{
			get
			{
				if (_iconRecord == null)
				{
					_iconRecord = (wCHandle<gamedataChoiceCaptionIconPart_Record>) CR2WTypeManager.Create("whandle:gamedataChoiceCaptionIconPart_Record", "iconRecord", cr2w, this);
				}
				return _iconRecord;
			}
			set
			{
				if (_iconRecord == value)
				{
					return;
				}
				_iconRecord = value;
				PropertySet(this);
			}
		}

		public gameinteractionsChoiceCaptionIconPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
