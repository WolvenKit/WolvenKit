using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceOnScreenEntry : CVariable
	{
		private CUInt64 _primaryKey;
		private CString _secondaryKey;
		private CString _femaleVariant;
		private CString _maleVariant;

		[Ordinal(0)] 
		[RED("primaryKey")] 
		public CUInt64 PrimaryKey
		{
			get
			{
				if (_primaryKey == null)
				{
					_primaryKey = (CUInt64) CR2WTypeManager.Create("Uint64", "primaryKey", cr2w, this);
				}
				return _primaryKey;
			}
			set
			{
				if (_primaryKey == value)
				{
					return;
				}
				_primaryKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("secondaryKey")] 
		public CString SecondaryKey
		{
			get
			{
				if (_secondaryKey == null)
				{
					_secondaryKey = (CString) CR2WTypeManager.Create("String", "secondaryKey", cr2w, this);
				}
				return _secondaryKey;
			}
			set
			{
				if (_secondaryKey == value)
				{
					return;
				}
				_secondaryKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("femaleVariant")] 
		public CString FemaleVariant
		{
			get
			{
				if (_femaleVariant == null)
				{
					_femaleVariant = (CString) CR2WTypeManager.Create("String", "femaleVariant", cr2w, this);
				}
				return _femaleVariant;
			}
			set
			{
				if (_femaleVariant == value)
				{
					return;
				}
				_femaleVariant = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maleVariant")] 
		public CString MaleVariant
		{
			get
			{
				if (_maleVariant == null)
				{
					_maleVariant = (CString) CR2WTypeManager.Create("String", "maleVariant", cr2w, this);
				}
				return _maleVariant;
			}
			set
			{
				if (_maleVariant == value)
				{
					return;
				}
				_maleVariant = value;
				PropertySet(this);
			}
		}

		public localizationPersistenceOnScreenEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
