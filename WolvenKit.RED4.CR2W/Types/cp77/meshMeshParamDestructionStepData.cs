using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDestructionStepData : meshMeshParameter
	{
		private CArray<physicsDestructionHierarchyOffset> _offsets;
		private CString _isInstantRemovable;

		[Ordinal(0)] 
		[RED("offsets")] 
		public CArray<physicsDestructionHierarchyOffset> Offsets
		{
			get
			{
				if (_offsets == null)
				{
					_offsets = (CArray<physicsDestructionHierarchyOffset>) CR2WTypeManager.Create("array:physicsDestructionHierarchyOffset", "offsets", cr2w, this);
				}
				return _offsets;
			}
			set
			{
				if (_offsets == value)
				{
					return;
				}
				_offsets = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isInstantRemovable")] 
		public CString IsInstantRemovable
		{
			get
			{
				if (_isInstantRemovable == null)
				{
					_isInstantRemovable = (CString) CR2WTypeManager.Create("String", "isInstantRemovable", cr2w, this);
				}
				return _isInstantRemovable;
			}
			set
			{
				if (_isInstantRemovable == value)
				{
					return;
				}
				_isInstantRemovable = value;
				PropertySet(this);
			}
		}

		public meshMeshParamDestructionStepData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
