using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnlocVariantId : CVariable
	{
		private CRUID _ruid;

		[Ordinal(0)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get
			{
				if (_ruid == null)
				{
					_ruid = (CRUID) CR2WTypeManager.Create("CRUID", "ruid", cr2w, this);
				}
				return _ruid;
			}
			set
			{
				if (_ruid == value)
				{
					return;
				}
				_ruid = value;
				PropertySet(this);
			}
		}

		public scnlocVariantId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
