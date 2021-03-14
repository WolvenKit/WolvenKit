using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceSubtitleEntry : CVariable
	{
		private CRUID _stringId;
		private CString _femaleVariant;
		private CString _maleVariant;

		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get
			{
				if (_stringId == null)
				{
					_stringId = (CRUID) CR2WTypeManager.Create("CRUID", "stringId", cr2w, this);
				}
				return _stringId;
			}
			set
			{
				if (_stringId == value)
				{
					return;
				}
				_stringId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		public localizationPersistenceSubtitleEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
