using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeItemCreated : redEvent
	{
		private CHandle<PerksMenuAttributeItemController> _perksMenuAttributeItem;

		[Ordinal(0)] 
		[RED("perksMenuAttributeItem")] 
		public CHandle<PerksMenuAttributeItemController> PerksMenuAttributeItem
		{
			get => GetProperty(ref _perksMenuAttributeItem);
			set => SetProperty(ref _perksMenuAttributeItem, value);
		}

		public PerksMenuAttributeItemCreated(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
