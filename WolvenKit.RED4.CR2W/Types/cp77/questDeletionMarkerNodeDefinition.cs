using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDeletionMarkerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CArray<CUInt16> _deletedNodeIds;

		[Ordinal(2)] 
		[RED("deletedNodeIds")] 
		public CArray<CUInt16> DeletedNodeIds
		{
			get
			{
				if (_deletedNodeIds == null)
				{
					_deletedNodeIds = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "deletedNodeIds", cr2w, this);
				}
				return _deletedNodeIds;
			}
			set
			{
				if (_deletedNodeIds == value)
				{
					return;
				}
				_deletedNodeIds = value;
				PropertySet(this);
			}
		}

		public questDeletionMarkerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
