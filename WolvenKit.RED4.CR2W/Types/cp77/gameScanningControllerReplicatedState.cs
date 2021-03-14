using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningControllerReplicatedState : ISerializable
	{
		private CArray<entEntityID> _taggedObjectIDs;

		[Ordinal(0)] 
		[RED("taggedObjectIDs")] 
		public CArray<entEntityID> TaggedObjectIDs
		{
			get
			{
				if (_taggedObjectIDs == null)
				{
					_taggedObjectIDs = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "taggedObjectIDs", cr2w, this);
				}
				return _taggedObjectIDs;
			}
			set
			{
				if (_taggedObjectIDs == value)
				{
					return;
				}
				_taggedObjectIDs = value;
				PropertySet(this);
			}
		}

		public gameScanningControllerReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
