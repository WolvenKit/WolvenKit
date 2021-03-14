using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioRagdollSubSystem : gameaudioISoundComponentSubSystem
	{
		private CName _defaultMaterialMetadata;
		private CName _customDismembermentSettings;
		private CName _lookupMatrixName;

		[Ordinal(0)] 
		[RED("defaultMaterialMetadata")] 
		public CName DefaultMaterialMetadata
		{
			get
			{
				if (_defaultMaterialMetadata == null)
				{
					_defaultMaterialMetadata = (CName) CR2WTypeManager.Create("CName", "defaultMaterialMetadata", cr2w, this);
				}
				return _defaultMaterialMetadata;
			}
			set
			{
				if (_defaultMaterialMetadata == value)
				{
					return;
				}
				_defaultMaterialMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("customDismembermentSettings")] 
		public CName CustomDismembermentSettings
		{
			get
			{
				if (_customDismembermentSettings == null)
				{
					_customDismembermentSettings = (CName) CR2WTypeManager.Create("CName", "customDismembermentSettings", cr2w, this);
				}
				return _customDismembermentSettings;
			}
			set
			{
				if (_customDismembermentSettings == value)
				{
					return;
				}
				_customDismembermentSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lookupMatrixName")] 
		public CName LookupMatrixName
		{
			get
			{
				if (_lookupMatrixName == null)
				{
					_lookupMatrixName = (CName) CR2WTypeManager.Create("CName", "lookupMatrixName", cr2w, this);
				}
				return _lookupMatrixName;
			}
			set
			{
				if (_lookupMatrixName == value)
				{
					return;
				}
				_lookupMatrixName = value;
				PropertySet(this);
			}
		}

		public gameaudioRagdollSubSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
