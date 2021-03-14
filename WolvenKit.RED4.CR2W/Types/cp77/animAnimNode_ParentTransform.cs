using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ParentTransform : animAnimNode_OnePoseInput
	{
		private CArray<animAnimTransformMappingEntry> _mapping;

		[Ordinal(12)] 
		[RED("mapping")] 
		public CArray<animAnimTransformMappingEntry> Mapping
		{
			get
			{
				if (_mapping == null)
				{
					_mapping = (CArray<animAnimTransformMappingEntry>) CR2WTypeManager.Create("array:animAnimTransformMappingEntry", "mapping", cr2w, this);
				}
				return _mapping;
			}
			set
			{
				if (_mapping == value)
				{
					return;
				}
				_mapping = value;
				PropertySet(this);
			}
		}

		public animAnimNode_ParentTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
