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
			get => GetProperty(ref _iconRecord);
			set => SetProperty(ref _iconRecord, value);
		}

		public gameinteractionsChoiceCaptionIconPart(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
