using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsclothClothCapsuleExportData : ISerializable
	{
		private CArray<physicsclothExportedCapsule> _capsules;

		[Ordinal(0)] 
		[RED("capsules")] 
		public CArray<physicsclothExportedCapsule> Capsules
		{
			get
			{
				if (_capsules == null)
				{
					_capsules = (CArray<physicsclothExportedCapsule>) CR2WTypeManager.Create("array:physicsclothExportedCapsule", "capsules", cr2w, this);
				}
				return _capsules;
			}
			set
			{
				if (_capsules == value)
				{
					return;
				}
				_capsules = value;
				PropertySet(this);
			}
		}

		public physicsclothClothCapsuleExportData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
