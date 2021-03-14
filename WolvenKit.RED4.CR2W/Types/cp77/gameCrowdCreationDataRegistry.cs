using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdCreationDataRegistry : ISerializable
	{
		private CArray<gameCrowdCreationData> _creationData;

		[Ordinal(0)] 
		[RED("creationData")] 
		public CArray<gameCrowdCreationData> CreationData
		{
			get
			{
				if (_creationData == null)
				{
					_creationData = (CArray<gameCrowdCreationData>) CR2WTypeManager.Create("array:gameCrowdCreationData", "creationData", cr2w, this);
				}
				return _creationData;
			}
			set
			{
				if (_creationData == value)
				{
					return;
				}
				_creationData = value;
				PropertySet(this);
			}
		}

		public gameCrowdCreationDataRegistry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
