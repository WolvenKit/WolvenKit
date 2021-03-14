using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEntityUserComponentResolution : CVariable
	{
		private CRUID _id;
		private raRef<entEntityTemplate> _include;
		private CEnum<entEntityUserComponentResolutionMode> _mode;

		[Ordinal(0)] 
		[RED("id")] 
		public CRUID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CRUID) CR2WTypeManager.Create("CRUID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("include")] 
		public raRef<entEntityTemplate> Include
		{
			get
			{
				if (_include == null)
				{
					_include = (raRef<entEntityTemplate>) CR2WTypeManager.Create("raRef:entEntityTemplate", "include", cr2w, this);
				}
				return _include;
			}
			set
			{
				if (_include == value)
				{
					return;
				}
				_include = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<entEntityUserComponentResolutionMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<entEntityUserComponentResolutionMode>) CR2WTypeManager.Create("entEntityUserComponentResolutionMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		public entEntityUserComponentResolution(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
