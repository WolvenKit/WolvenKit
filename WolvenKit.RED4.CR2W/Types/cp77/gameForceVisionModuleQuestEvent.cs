using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameForceVisionModuleQuestEvent : redEvent
	{
		private CName _moduleName;
		private CArray<CName> _meshComponentNames;

		[Ordinal(0)] 
		[RED("moduleName")] 
		public CName ModuleName
		{
			get
			{
				if (_moduleName == null)
				{
					_moduleName = (CName) CR2WTypeManager.Create("CName", "moduleName", cr2w, this);
				}
				return _moduleName;
			}
			set
			{
				if (_moduleName == value)
				{
					return;
				}
				_moduleName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("meshComponentNames")] 
		public CArray<CName> MeshComponentNames
		{
			get
			{
				if (_meshComponentNames == null)
				{
					_meshComponentNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "meshComponentNames", cr2w, this);
				}
				return _meshComponentNames;
			}
			set
			{
				if (_meshComponentNames == value)
				{
					return;
				}
				_meshComponentNames = value;
				PropertySet(this);
			}
		}

		public gameForceVisionModuleQuestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
