using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerRewireMap : audioAudioMetadata
	{
		private CArray<CName> _includes;
		private CArray<audioVoiceTriggerRewireMapItem> _items;

		[Ordinal(1)] 
		[RED("includes")] 
		public CArray<CName> Includes
		{
			get
			{
				if (_includes == null)
				{
					_includes = (CArray<CName>) CR2WTypeManager.Create("array:CName", "includes", cr2w, this);
				}
				return _includes;
			}
			set
			{
				if (_includes == value)
				{
					return;
				}
				_includes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("items")] 
		public CArray<audioVoiceTriggerRewireMapItem> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<audioVoiceTriggerRewireMapItem>) CR2WTypeManager.Create("array:audioVoiceTriggerRewireMapItem", "items", cr2w, this);
				}
				return _items;
			}
			set
			{
				if (_items == value)
				{
					return;
				}
				_items = value;
				PropertySet(this);
			}
		}

		public audioVoiceTriggerRewireMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
