using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animTEMP_IKTargetsControllerBodyType : CVariable
	{
		private CName _genderTag;
		private CName _bodyTypeTag;
		private CArray<animIKChainSettings> _ikChainSettings;

		[Ordinal(0)] 
		[RED("genderTag")] 
		public CName GenderTag
		{
			get
			{
				if (_genderTag == null)
				{
					_genderTag = (CName) CR2WTypeManager.Create("CName", "genderTag", cr2w, this);
				}
				return _genderTag;
			}
			set
			{
				if (_genderTag == value)
				{
					return;
				}
				_genderTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bodyTypeTag")] 
		public CName BodyTypeTag
		{
			get
			{
				if (_bodyTypeTag == null)
				{
					_bodyTypeTag = (CName) CR2WTypeManager.Create("CName", "bodyTypeTag", cr2w, this);
				}
				return _bodyTypeTag;
			}
			set
			{
				if (_bodyTypeTag == value)
				{
					return;
				}
				_bodyTypeTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ikChainSettings")] 
		public CArray<animIKChainSettings> IkChainSettings
		{
			get
			{
				if (_ikChainSettings == null)
				{
					_ikChainSettings = (CArray<animIKChainSettings>) CR2WTypeManager.Create("array:animIKChainSettings", "ikChainSettings", cr2w, this);
				}
				return _ikChainSettings;
			}
			set
			{
				if (_ikChainSettings == value)
				{
					return;
				}
				_ikChainSettings = value;
				PropertySet(this);
			}
		}

		public animTEMP_IKTargetsControllerBodyType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
