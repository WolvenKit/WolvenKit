using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayChoiceOption : CVariable
	{
		private scnscreenplayItemId _itemId;
		private scnscreenplayOptionUsage _usage;
		private scnlocLocstringId _locstringId;

		[Ordinal(0)] 
		[RED("itemId")] 
		public scnscreenplayItemId ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (scnscreenplayItemId) CR2WTypeManager.Create("scnscreenplayItemId", "itemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("usage")] 
		public scnscreenplayOptionUsage Usage
		{
			get
			{
				if (_usage == null)
				{
					_usage = (scnscreenplayOptionUsage) CR2WTypeManager.Create("scnscreenplayOptionUsage", "usage", cr2w, this);
				}
				return _usage;
			}
			set
			{
				if (_usage == value)
				{
					return;
				}
				_usage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("locstringId")] 
		public scnlocLocstringId LocstringId
		{
			get
			{
				if (_locstringId == null)
				{
					_locstringId = (scnlocLocstringId) CR2WTypeManager.Create("scnlocLocstringId", "locstringId", cr2w, this);
				}
				return _locstringId;
			}
			set
			{
				if (_locstringId == value)
				{
					return;
				}
				_locstringId = value;
				PropertySet(this);
			}
		}

		public scnscreenplayChoiceOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
