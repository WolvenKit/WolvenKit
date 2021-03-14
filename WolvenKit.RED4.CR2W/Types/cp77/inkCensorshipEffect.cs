using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCensorshipEffect : inkGlitchEffect
	{
		private CEnum<CensorshipFlags> _censorshipFlags;

		[Ordinal(7)] 
		[RED("censorshipFlags")] 
		public CEnum<CensorshipFlags> CensorshipFlags
		{
			get
			{
				if (_censorshipFlags == null)
				{
					_censorshipFlags = (CEnum<CensorshipFlags>) CR2WTypeManager.Create("CensorshipFlags", "censorshipFlags", cr2w, this);
				}
				return _censorshipFlags;
			}
			set
			{
				if (_censorshipFlags == value)
				{
					return;
				}
				_censorshipFlags = value;
				PropertySet(this);
			}
		}

		public inkCensorshipEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
