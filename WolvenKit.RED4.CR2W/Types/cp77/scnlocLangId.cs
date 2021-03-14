using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnlocLangId : CVariable
	{
		private CUInt8 _langId;

		[Ordinal(0)] 
		[RED("langId")] 
		public CUInt8 LangId
		{
			get
			{
				if (_langId == null)
				{
					_langId = (CUInt8) CR2WTypeManager.Create("Uint8", "langId", cr2w, this);
				}
				return _langId;
			}
			set
			{
				if (_langId == value)
				{
					return;
				}
				_langId = value;
				PropertySet(this);
			}
		}

		public scnlocLangId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
