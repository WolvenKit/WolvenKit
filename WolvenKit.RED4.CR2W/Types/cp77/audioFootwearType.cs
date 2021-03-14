using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootwearType : audioAudioMetadata
	{
		private CArray<CName> _itemNames;

		[Ordinal(1)] 
		[RED("itemNames")] 
		public CArray<CName> ItemNames
		{
			get
			{
				if (_itemNames == null)
				{
					_itemNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "itemNames", cr2w, this);
				}
				return _itemNames;
			}
			set
			{
				if (_itemNames == value)
				{
					return;
				}
				_itemNames = value;
				PropertySet(this);
			}
		}

		public audioFootwearType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
