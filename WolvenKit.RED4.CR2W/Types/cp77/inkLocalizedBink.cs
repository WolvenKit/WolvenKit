using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLocalizedBink : CVariable
	{
		private CArray<inkBinkLanguageDescriptor> _binks;

		[Ordinal(0)] 
		[RED("binks")] 
		public CArray<inkBinkLanguageDescriptor> Binks
		{
			get
			{
				if (_binks == null)
				{
					_binks = (CArray<inkBinkLanguageDescriptor>) CR2WTypeManager.Create("array:inkBinkLanguageDescriptor", "binks", cr2w, this);
				}
				return _binks;
			}
			set
			{
				if (_binks == value)
				{
					return;
				}
				_binks = value;
				PropertySet(this);
			}
		}

		public inkLocalizedBink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
