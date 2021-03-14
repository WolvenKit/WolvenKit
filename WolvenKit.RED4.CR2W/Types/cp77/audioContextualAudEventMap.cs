using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioContextualAudEventMap : audioAudioMetadata
	{
		private CArray<audioContextualAudEventMapItem> _contextualAudEventMapItems;

		[Ordinal(1)] 
		[RED("contextualAudEventMapItems")] 
		public CArray<audioContextualAudEventMapItem> ContextualAudEventMapItems
		{
			get
			{
				if (_contextualAudEventMapItems == null)
				{
					_contextualAudEventMapItems = (CArray<audioContextualAudEventMapItem>) CR2WTypeManager.Create("array:audioContextualAudEventMapItem", "contextualAudEventMapItems", cr2w, this);
				}
				return _contextualAudEventMapItems;
			}
			set
			{
				if (_contextualAudEventMapItems == value)
				{
					return;
				}
				_contextualAudEventMapItems = value;
				PropertySet(this);
			}
		}

		public audioContextualAudEventMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
