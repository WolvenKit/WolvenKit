using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundConfig : ISerializable
	{
		private CName _woundName;
		private CEnum<entdismembermentResourceSetE> _resourceSet;

		[Ordinal(0)] 
		[RED("WoundName")] 
		public CName WoundName
		{
			get
			{
				if (_woundName == null)
				{
					_woundName = (CName) CR2WTypeManager.Create("CName", "WoundName", cr2w, this);
				}
				return _woundName;
			}
			set
			{
				if (_woundName == value)
				{
					return;
				}
				_woundName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ResourceSet")] 
		public CEnum<entdismembermentResourceSetE> ResourceSet
		{
			get
			{
				if (_resourceSet == null)
				{
					_resourceSet = (CEnum<entdismembermentResourceSetE>) CR2WTypeManager.Create("entdismembermentResourceSetE", "ResourceSet", cr2w, this);
				}
				return _resourceSet;
			}
			set
			{
				if (_resourceSet == value)
				{
					return;
				}
				_resourceSet = value;
				PropertySet(this);
			}
		}

		public entdismembermentWoundConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
