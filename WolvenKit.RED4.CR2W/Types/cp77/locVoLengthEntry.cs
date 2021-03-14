using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class locVoLengthEntry : CVariable
	{
		private CRUID _stringId;
		private CFloat _femaleLength;
		private CFloat _maleLength;

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
		[RED("femaleLength")] 
		public CFloat FemaleLength
		{
			get
			{
				if (_femaleLength == null)
				{
					_femaleLength = (CFloat) CR2WTypeManager.Create("Float", "femaleLength", cr2w, this);
				}
				return _femaleLength;
			}
			set
			{
				if (_femaleLength == value)
				{
					return;
				}
				_femaleLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maleLength")] 
		public CFloat MaleLength
		{
			get
			{
				if (_maleLength == null)
				{
					_maleLength = (CFloat) CR2WTypeManager.Create("Float", "maleLength", cr2w, this);
				}
				return _maleLength;
			}
			set
			{
				if (_maleLength == value)
				{
					return;
				}
				_maleLength = value;
				PropertySet(this);
			}
		}

		public locVoLengthEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
