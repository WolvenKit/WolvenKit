using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class locVoLineEntry : CVariable
	{
		private CRUID _stringId;
		private raRef<locVoResource> _femaleResPath;
		private raRef<locVoResource> _maleResPath;

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
		[RED("femaleResPath")] 
		public raRef<locVoResource> FemaleResPath
		{
			get
			{
				if (_femaleResPath == null)
				{
					_femaleResPath = (raRef<locVoResource>) CR2WTypeManager.Create("raRef:locVoResource", "femaleResPath", cr2w, this);
				}
				return _femaleResPath;
			}
			set
			{
				if (_femaleResPath == value)
				{
					return;
				}
				_femaleResPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maleResPath")] 
		public raRef<locVoResource> MaleResPath
		{
			get
			{
				if (_maleResPath == null)
				{
					_maleResPath = (raRef<locVoResource>) CR2WTypeManager.Create("raRef:locVoResource", "maleResPath", cr2w, this);
				}
				return _maleResPath;
			}
			set
			{
				if (_maleResPath == value)
				{
					return;
				}
				_maleResPath = value;
				PropertySet(this);
			}
		}

		public locVoLineEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
