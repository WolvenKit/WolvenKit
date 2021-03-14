using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShutdownModule : redEvent
	{
		private CInt32 _module;

		[Ordinal(0)] 
		[RED("module")] 
		public CInt32 Module
		{
			get
			{
				if (_module == null)
				{
					_module = (CInt32) CR2WTypeManager.Create("Int32", "module", cr2w, this);
				}
				return _module;
			}
			set
			{
				if (_module == value)
				{
					return;
				}
				_module = value;
				PropertySet(this);
			}
		}

		public ShutdownModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
